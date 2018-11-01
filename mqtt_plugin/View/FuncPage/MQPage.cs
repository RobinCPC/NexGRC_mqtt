using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NEXCOM.Utility;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

using mqtt_plugin.Controller;

namespace mqtt_plugin.View.FuncPage
{
    public partial class MQPage : NEXCOM.Modules.Function.NexFunctionPage
    {
        private readonly IntMQService mMQService = null;

        public MqttClient myMQClient = null;
        private string MQTT_BROKER_ADDRESS = "";
        private int MQTT_TCP_PORT = 0;
        private string Parent_Topic = "NexCOBOT/MiniBot7R/";
        private string DurationString = "";
        

        public MQPage(IntMQService mq_service)
        {
            mMQService = mq_service;
            this.PageName = "MQTT";

            InitializeComponent();
        }

        private void btn_mqtt_Click(object sender, EventArgs e)
        {
            if(myMQClient == null)
            {
                MQTT_BROKER_ADDRESS = textBox_ip.Text;
                MQTT_TCP_PORT = Convert.ToInt16(textBox_port.Text);

                // Create Client Instance
                myMQClient = new MqttClient(MQTT_BROKER_ADDRESS);

                // Connect to Broker
                string clientId = Guid.NewGuid().ToString();
                byte code = myMQClient.Connect(clientId);

                // Start timer to publish data
                timer_mqtt.Start();

                // event handler to check if message are sent to the broker successfully.
                myMQClient.MqttMsgPublished += client_MqttMsgPublished;

                // event handler to check if receive message
                myMQClient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                // Subscribe to Topic
                //ushort msgIdrev = myMQClient.Subscribe(new string[] { Parent_Topic + "TotalPowerOnTime" }, 
                //                                       new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

                //myMQClient.Subscribe(new string[] { Parent_Topic + "JogRatio" }, 
                //                                       new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
            }
        }

        private void timer_mqtt_Tick(object sender, EventArgs e)
        {
            // Update Total Power on Time
            TimeSpan Duration = DateTime.Now - MQController.mStartTime;
            DurationString = Duration.Days.ToString() + "Days" + Duration.Hours.ToString() + "Hours" +
                                    Duration.Minutes.ToString() + "Minutes" + Duration.Seconds.ToString() + "Seconds";

            // publish power-on time
            ushort msgId = myMQClient.Publish(Parent_Topic + "TotalPowerOnTime", // Topic
                                              Encoding.UTF8.GetBytes(Duration.ToString()), // message body
                                              MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                              false); // retained

            // publish jog ratio
            myMQClient.Publish(Parent_Topic + "JogRatio", // Topic
                                              Encoding.UTF8.GetBytes(mMQService.DeviceService.GroupObjectList[0].JogRatio.ToString()), // message body
                                              MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                              false); // retained

            // publish angle (deg) of each joint
            for (int i = 0; i < 7; ++i)
            {
                myMQClient.Publish(Parent_Topic + "Joint" + (i + 1).ToString(), // Topic
                                                  Encoding.UTF8.GetBytes(mMQService.DeviceService.GroupObjectList[0].GroupStatus.AcsActPos[i].Value.ToString()), // message body
                                                  MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                                  false); // retained
            }

            // publish the position & orientation of end-effector
            string[] coord = { "X", "Y", "Z", "A", "B", "C" };
            for (int i = 0; i < 6; ++i)
            {
                myMQClient.Publish(Parent_Topic + coord[i], // Topic
                                                  Encoding.UTF8.GetBytes(mMQService.DeviceService.GroupObjectList[0].GroupStatus.McsActPos[i].Value.ToString()), // message body
                                                  MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                                  false); // retained
            }

            myMQClient.Publish(Parent_Topic + "State", // Topic
                                              Encoding.UTF8.GetBytes(mMQService.DeviceService.GroupObjectList[0].GroupStatus.GroupState.ToString()), // message body
                                              MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                              false); // retained

        }

        void client_MqttMsgPublished(Object sender, MqttMsgPublishedEventArgs e)
        {
            //Console.WriteLine("MessageId = " + e.MessageId + " Published = " + e.IsPublished);
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
        }

    }
}
