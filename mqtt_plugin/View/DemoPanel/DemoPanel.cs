using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NEXCOM.GRC.Framework;

namespace mqtt_plugin
{
    public partial class DemoPanel : NexPanel
    {
        private readonly IntMQService mMQservice = null;
        private readonly MiniGRCControl mMiniGRCControl = null;

        public DemoPanel(IntMQService service, MiniGRCControl control )
        {
            mMQservice = service;
            mMiniGRCControl = control;

            InitializeComponent();

            InitDataBinding();
        }

        private void InitDataBinding()
        {
            mRb_External.DataBindings.Add("Checked", mMiniGRCControl, "IsExternalMode", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void mBt_back_Click(object sender, EventArgs e)
        {
            mMQservice.FuncPageService.ShowFunctionPanel();
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

        private void mBt_red_Click(object sender, EventArgs e)
        {
            if (mMiniGRCControl.IsExternalMode == true)
            {
                return;
            }

            string msg = "";
            mMiniGRCControl.RunScript(0, ref msg);
        }

        private void mBt_green_Click(object sender, EventArgs e)
        {
            if (mMiniGRCControl.IsExternalMode == true)
            {
                return;
            }

            string msg = "";
            mMiniGRCControl.RunScript(1, ref msg);
        }

        private void mBt_blue_Click(object sender, EventArgs e)
        {
            if (mMiniGRCControl.IsExternalMode == true)
            {
                return;
            }

            string msg = "";
            mMiniGRCControl.RunScript(2, ref msg);
        }

        private void mBt_yellow_Click(object sender, EventArgs e)
        {
            if (mMiniGRCControl.IsExternalMode == true)
            {
                return;
            }

            string msg = "";
            mMiniGRCControl.RunScript(3, ref msg);
        }

        private void DemoPanel_Load(object sender, EventArgs e)
        {
            int interval = 10;
            int x_center = this.Width/2;
            int y_center = this.Height/2;

            mBt_red.Location = new Point(x_center - mBt_red.Width - interval, y_center - mBt_red.Height - interval);

            mBt_green.Location = new Point(x_center + interval, y_center - mBt_green.Height - interval);

            mBt_blue.Location = new Point(x_center - mBt_blue.Width - interval, y_center + interval);

            mBt_yellow.Location = new Point(x_center + interval, y_center + interval);

        }

        public void SetMessage(string msg)
        {
            this.mLb_msg.Text = msg;
        }
    }
}
