using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

using MiniGRC;

namespace mqtt_plugin
{
    public class MiniGRCControl
    {
        private readonly IntMQService mMQService = null;
        private readonly IMiniService mMiniService = null;
        private readonly SystemManager mSystemManager = null;
        private readonly ScriptController mScriptController = null;

        private readonly DemoPanel mDemoPanel = null;
     
        public bool IsExternalMode { get; set; } = false;   

        public int ExternalColorIndex { get { return mScriptController.ExternalLEDIndex; } }

        public MiniGRCControl(IntMQService service)
        {
            mMQService = service;
            mMiniService = service.MiniService;
            mSystemManager = service.MiniService.SystemManager;
            mScriptController = service.MiniService.ScriptController;


            mDemoPanel = new DemoPanel(service, this);
            service.CoreService.RegisterPanel(mDemoPanel);
        }

        public void ShowDemoPanel()
        {
            mMQService.CoreService.ActivePanel(mDemoPanel);
        }

        public void UpdateColorMessage(string msg)
        {
            mDemoPanel.SetMessage(msg);
        }

        public void ResetColorIndex()
        {
            mScriptController.ExternalLEDIndex = -1;
        }

        public bool RunScript(int color_index, ref string msg)
        {
            if(mSystemManager.SystemState != SysState.standby)
            {
                msg = "System is not ready";
                return false;
            }

            mSystemManager.SwitchToRunning();

            if (mSystemManager.SystemState != SysState.running)
            {
                msg = "System state can not switch to running mode";
                return false;
            }

            mScriptController.ExternalLEDIndex = color_index;
            if (mScriptController.StartRun_Once(0) == false)
            {
                msg = "Run script fail";
                mScriptController.ExternalLEDIndex = -1;
                return false;
            }

            msg = "Success, index : "+ color_index.ToString();
            return true;
        }

      
    }
}
