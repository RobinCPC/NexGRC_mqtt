using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

using NEXCOM.Modules.Device;

namespace mqtt_plugin
{
    public class MQModel 
    {

        private const string Parent_Topic = "NexCOBOT/MiniBot7R/";
        private const string Cloud_Topic = "NexCOBOT/Cloud/";
        private string DurationString = "";

        private readonly IntMQService mMQService = null;
        private readonly IDeviceManagerService mDeviceService = null;

        private readonly string ClientId = "820D619B-E708-4238-A6B6-09B0E05E125D";

        private MqttClient mMQClient = null;
        private Timer mTimer = new Timer();
        
        public string MQTT_ADDRESS { get; private set; } = "127.0.0.1";
        public int MQTT_PORT { get; private set; } = 1883;

        public string ReciveData { get; set; } = "";

        public bool IsClientConnect
        {
            get
            {
                if(mMQClient == null)
                {
                    return false;
                }

                return mMQClient.IsConnected;
            }
        }

        public MQModel(IntMQService service)
        {
            this.mMQService = service;
            this.mDeviceService = service.DeviceService;

            this.mTimer.Interval = 1000;
            this.mTimer.Tick += timer_Tick;
        }

        public bool Connent(string address, int port)
        {
            if(IsClientConnect == true)
            {
                return false;
            }

            MQTT_ADDRESS = address;
            MQTT_PORT = port;

           
            if (mMQClient == null)
            {
                // Create Client Instance
                mMQClient = new MqttClient(MQTT_ADDRESS);

                // event handler to check if message are sent to the broker successfully.
                mMQClient.MqttMsgPublished += client_MqttMsgPublished;

                // event handler to check if receive message
                mMQClient.MqttMsgPublishReceived += client_MqttMsgReceived;
              
            }
            
            try
            {
                byte code = mMQClient.Connect(ClientId);
            }
            catch
            {
                return false;
            }

            ushort msgIdrev = mMQClient.Subscribe(new string[] { Cloud_Topic + "LedColor" },
                                          new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

            StartPublishMsg();
            return true;
        }

        public void Disconnect()
        {
            StopPublishMsg();

            if (IsClientConnect == false)
            {
                return;
            }

            if (mMQClient != null)
            {
                mMQClient.Disconnect();
            }
        }

        public void StartPublishMsg()
        {
            this.mTimer.Start();
        }

        public void StopPublishMsg()
        {
            this.mTimer.Stop();
        }
     
        void timer_Tick(object sender, EventArgs e)
        {
            if (IsClientConnect == false)
            {
                return;
            }


            // Update Total Power on Time
            TimeSpan Duration = DateTime.Now - MQController.mStartTime;
            DurationString = Duration.Days.ToString() + "Days" + Duration.Hours.ToString() + "Hours" +
                                    Duration.Minutes.ToString() + "Minutes" + Duration.Seconds.ToString() + "Seconds";

            // publish power-on time
            ushort msgId = mMQClient.Publish(Parent_Topic + "TotalPowerOnTime", // Topic
                                              Encoding.UTF8.GetBytes(Duration.ToString()), // message body
                                              MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                              false); // retained


            if(mMQService.DeviceService.CurrentGroupObject == null)
            {
                return;
            }

            GroupObject group = mMQService.DeviceService.CurrentGroupObject;

            // publish jog ratio
            mMQClient.Publish(Parent_Topic + "JogRatio", // Topic
                                              Encoding.UTF8.GetBytes(group.JogRatio.ToString()), // message body
                                              MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                              false); // retained

            // publish angle (deg) of each joint
            for (int i = 0; i < 7; ++i)
            {
                mMQClient.Publish(Parent_Topic + "Joint" + (i + 1).ToString(), // Topic
                                                  Encoding.UTF8.GetBytes(group.GroupStatus.AcsActPos[i].ValueString), // message body
                                                  MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                                  false); // retained
            }

            // publish the position & orientation of end-effector
            string[] coord = { "X", "Y", "Z", "A", "B", "C" };
            for (int i = 0; i < 6; ++i)
            {
                mMQClient.Publish(Parent_Topic + coord[i], // Topic
                                                  Encoding.UTF8.GetBytes(group.GroupStatus.McsActPos[i].ValueString), // message body
                                                  MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                                  false); // retained
            }

            mMQClient.Publish(Parent_Topic + "State", // Topic
                                              Encoding.UTF8.GetBytes(group.GroupStatus.GroupState.ToString()), // message body
                                              MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, // QoS level
                                              false); // retained
        }


        void client_MqttMsgPublished(Object sender, MqttMsgPublishedEventArgs e)
        {
            //Console.WriteLine("MessageId = " + e.MessageId + " Published = " + e.IsPublished);
        }

        void client_MqttMsgReceived(object sender, MqttMsgPublishEventArgs e)
        {
            this.ReciveData = Encoding.UTF8.GetString(e.Message);
        
            //string rec_str = "Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic;
            //Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
            //rec_payload = rec_str;
            //// Catch Color index send from Dashboard
            //if (e.Topic.Contains("LedColor"))
            //{
            //    color_index = Convert.ToInt16(Encoding.UTF8.GetString(e.Message));
            //}
        }



    }
}
