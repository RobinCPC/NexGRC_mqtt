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
        private string Parent_Topic = "NexCOBOT/MiniBot6R/";
        private string Cloud_Topic = "NexCOBOT/Cloud/";
        private string DurationString = "";
        //  Variables for cloud command
        private int wait_cnt = 0;
        private int color_index = -1;
        private string rec_payload = "";
        

        public MQPage(IntMQService mq_service)
        {
            mMQService = mq_service;
            this.PageName = "MQTT";

            InitializeComponent();

            mLB_state.Text = "Status : " + ((myMQClient == null || myMQClient.IsConnected == false) ? "Disconnect" : "Connect");
        }

        ~MQPage()
        {
            // Stop timer and disconnect MQTT client
            timer_mqtt.Stop();
            if (myMQClient != null && myMQClient.IsConnected)
            {
                myMQClient.Disconnect();
                mLB_state.Text = "Status : Disconnect";
            }
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
                mLB_state.Text = "Status : Connect";

                // Start timer to publish data
                timer_mqtt.Interval = 1000;
                timer_mqtt.Start();

                // event handler to check if message are sent to the broker successfully.
                myMQClient.MqttMsgPublished += client_MqttMsgPublished;

                // event handler to check if receive message
                myMQClient.MqttMsgPublishReceived += client_MqttMsgReceived;

            }else if(myMQClient.IsConnected == false)
            {
                // Connect to Broker
                string clientId = Guid.NewGuid().ToString();
                byte code = myMQClient.Connect(clientId);
                mLB_state.Text = "Status : Connect";

                // Start timer to publish data
                timer_mqtt.Interval = 1000;
                timer_mqtt.Start();
            }
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            // Stop timer and disconnect MQTT client
            timer_mqtt.Stop();
            if (myMQClient != null && myMQClient.IsConnected)
            {
                myMQClient.Disconnect();
                mLB_state.Text = "Status : Disconnect";
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
            for (int i = 0; i < 6; ++i)
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

        void client_MqttMsgReceived(object sender, MqttMsgPublishEventArgs e)
        {
            //string rec_str = "Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic;
            //Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
            //rec_payload = rec_str;
        }

        private void btn_UdPnt_Click(object sender, EventArgs e)
        {
            // disable btn and reset color index
            this.btn_UdPnt.Enabled = false;
            color_index = -1;

            // set timer interval
            wait_cnt = System.Int32.Parse( textBox_sec.Text);
            textBox_wait.Text = textBox_sec.Text;
            timer_wait_cloud_cmd.Interval = 1000;  // wait 1 second to check if command send from cloud
            timer_wait_cloud_cmd.Start();

        }

        private void timer_wait_cloud_cmd_Tick(object sender, EventArgs e)
        {
            if(wait_cnt > 0)
            {
                wait_cnt -= 1;
                textBox_wait.Text = wait_cnt.ToString();

                // Check if colorindex send from dashboard
                if(color_index != -1)
                {
                    textBox_LED.Text = color_index.ToString();
                    textBox_Rec.Text = rec_payload;
                    btn_UdPnt.Enabled = true;
                    timer_wait_cloud_cmd.Stop();
                }

            }else if(wait_cnt <= 0)
            {
                // Check if colorindex send from dashboard
                if(color_index != -1)
                {
                    textBox_LED.Text = color_index.ToString();
                    textBox_Rec.Text = rec_payload;
                }else
                {
                    textBox_Rec.Text = "Do not receive color index! Used default color from script";
                    textBox_LED.Text = "Default";
                }
                btn_UdPnt.Enabled = true;
                timer_wait_cloud_cmd.Stop();
            }

        }
    }
}
