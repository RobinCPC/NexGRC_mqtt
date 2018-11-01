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

using mqtt_plugin.Controller;

namespace mqtt_plugin.View.FuncPage
{
    public partial class MQPage : NEXCOM.Modules.Function.NexFunctionPage
    {
        private readonly IntMQService mMQService = null;

        public MQPage(IntMQService mq_service)
        {
            mMQService = mq_service;
            this.PageName = "MQTT";

            InitializeComponent();
        }
    }
}
