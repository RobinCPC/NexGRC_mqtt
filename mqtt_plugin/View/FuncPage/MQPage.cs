﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NEXCOM.Utility;
using NEXCOM.Modules.Function;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

using MiniGRC;

namespace mqtt_plugin
{
    public partial class MQPage : NEXCOM.Modules.Function.NexFunctionPage
    {
        private readonly IntMQService mMQService = null;
        private readonly MQModel mMQModel = null;
        private readonly MiniGRCControl mMiniGRCControl = null;
        private readonly SystemManager mSystemManager = null;
        private readonly ScriptController mScriptController = null;

        public MQPage(IntMQService mq_service)
        {
            mMQService = mq_service;
            mMQModel = mq_service.MQModel;
            mMiniGRCControl = mq_service.MiniGRCControl;
            mSystemManager = mq_service.MiniService.SystemManager;
            mScriptController = mq_service.MiniService.ScriptController;

            this.PageName = "MQTT";
            this.PageCloseEvent += PageClose;

            InitializeComponent();

            InitPage();

            this.mqtt_timer.Start();
        }

        
        private void InitPage()
        {
            textBox_ip.Text = mMQModel.MQTT_ADDRESS;
            textBox_port.Text = mMQModel.MQTT_PORT.ToString();

            textBox_Rec.DataBindings.Add("Text", mMQModel, "ReciveData");

            mLb_state.Text = "State : " + (mMQModel.IsClientConnect == true ? "Connect" : "Disconnect");


            mRb_External.DataBindings.Add("Checked", mMiniGRCControl, "IsExternalMode", false, DataSourceUpdateMode.OnPropertyChanged);
        }
     
        private void PageClose(NexFunctionPage page)
        {
            this.mqtt_timer.Stop();
        }

        private void btn_mqtt_Click(object sender, EventArgs e)
        {
            int port = 0;
            if(int.TryParse(textBox_port.Text, out port) == false)
            {
                NexMessageBox.Show("Port value is invalid ! \n");
                return;
            }

            mMQModel.Connent(textBox_ip.Text, port);            
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            mMQModel.Disconnect();
        }

        private void mqtt_timer_Tick(object sender, EventArgs e)
        {
            // Check if need to change JogRatio (moving speed)
            if(mMQModel.FacialIndex != "")
            {
                //copy Received mqtt messages
                textBox_facial.Text = mMQModel.FacialIndex;
                mMQModel.FacialIndex = "";

                int fac_index = -1;
                if(int.TryParse(textBox_facial.Text, out fac_index) == true)
                {
                    switch (fac_index)
                    {
                        case 0:
                            Console.WriteLine("Facial Index is 0, Not Detect!");
                            mMQService.DeviceService.CurrentGroupObject.JogRatio = 100;
                            break;
                        case 1:
                            Console.WriteLine("Facial Index is 1, Detect Authorized Person");
                            mMQService.DeviceService.CurrentGroupObject.JogRatio = 0;
                            break;
                        case 2:
                            Console.WriteLine("Facial Index is 2, Detect Unauthorized Person");
                            mMQService.DeviceService.CurrentGroupObject.JogRatio = 10;
                            break;
                        default:
                            Console.WriteLine("Facial Index is unknown");
                            break;
                    }
                }
            }
           
            mLb_Color_index.Text = "Color Index : " + mMiniGRCControl.ExternalColorIndex.ToString();
            mMiniGRCControl.UpdateColorMessage(mLb_Color_index.Text);

            mLb_state.Text = "State : " + (mMQModel.IsClientConnect == true ? "Connect" : "Disconnect");
            if(mMQModel.ReciveData == "")
            {
                return;
            }

            //copy Received mqtt messages
            textBox_Rec.Text = mMQModel.ReciveData;
            mMQModel.ReciveData = "";

            // Check if need to run script
            if(mMiniGRCControl.IsExternalMode == false)
            {
                return;
            }

            int index = 0;
            if (int.TryParse(textBox_Rec.Text, out index) == false)
            {
                return;
            }

            string msg = "";
            if(mSystemManager.SystemState == SysState.running)
            {
                mScriptController.ExternalLEDIndex = index;
                return;
            }
            mMiniGRCControl.RunScript(index, ref msg);
          
        }

        private void mBt_Show_demo_Click(object sender, EventArgs e)
        {
            mMiniGRCControl.ShowDemoPanel();
        }

        private void mRb_manual_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void mRb_External_CheckedChanged(object sender, EventArgs e)
        {
            if (mRb_External.Checked == true)
            {
                mRb_External.ForeColor = System.Drawing.Color.FromArgb(0xfa, 0xfa, 0xfa);
                mRb_External.BackColor = System.Drawing.Color.FromArgb(0x1b, 0x8a, 0x82);

                mRb_manual.ForeColor = System.Drawing.Color.FromArgb(0x4c, 0x4c, 0x4c);
                mRb_manual.BackColor = System.Drawing.Color.FromArgb(0xab, 0xd4, 0xcf);
            }
            else
            {
                mRb_External.ForeColor = System.Drawing.Color.FromArgb(0x4c, 0x4c, 0x4c);
                mRb_External.BackColor = System.Drawing.Color.FromArgb(0xab, 0xd4, 0xcf);

                mRb_manual.ForeColor = System.Drawing.Color.FromArgb(0xfa, 0xfa, 0xfa);
                mRb_manual.BackColor = System.Drawing.Color.FromArgb(0x1b, 0x8a, 0x82);
            }
        }

        private void mBt_reset_color_Click(object sender, EventArgs e)
        {
            mMiniGRCControl.ResetColorIndex();
        }
    }
}
