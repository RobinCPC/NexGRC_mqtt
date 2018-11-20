using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NEXCOM.GRC.Framework;
using NEXCOM.Modules.Home;


namespace mqtt_plugin
{
    public class MQItem : NexHomeItem
    {
        private readonly IntMQService mMQService = null;

        private MQPage mMQPage = null;

        public MQItem(IntMQService mq_service)
        {
            mMQService = mq_service;

            this.ItemName = "MQTT";
            this.ItemPriority = 8;
            this.ItemImage = global::mqtt_plugin.Properties.Resources.mqtticon_green;

            this.ItemClickEvent = MQClickEven;
        }

        private void MQClickEven(NexHomeItem item)
        {
            Console.WriteLine("Open MQPage!");
            // Open or create FuncPage
            if(mMQService.FuncPageService.ActiveFunctionPage(mMQPage) == false)
            {
                mMQPage = new MQPage(mMQService);

                mMQService.FuncPageService.RegisterFunctionPage(mMQPage);
                mMQService.FuncPageService.ActiveFunctionPage(mMQPage);
            }
        }
    }
}
