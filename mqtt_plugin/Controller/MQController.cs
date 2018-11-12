using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.Windows.Forms;

using NEXCOM.GRC.Framework;
using NEXCOM.Modules.Device;
using NEXCOM.Modules.Home;
using NEXCOM.Modules.Function;
using NEXCOM.Utility;

using MiniGRC;

namespace mqtt_plugin
{
    [Export(typeof(NexModule))]
    class MQController : NexModule, IntMQService
    {
        // Service
        private INexCoreService mCoreService = null;
        private IHomeService mHomeService = null;
        private IFunctionPageService mFuncPageService = null;
        private IDeviceManagerService mDeviceService = null;
        private IMiniService mMiniService = null;

        //model
        private MQModel mMQModel = null;
        private MiniGRCControl mMiniGRCControl = null;

        // Home Item
        private MQItem mMQItem = null;

        // Time Record
        public static DateTime mStartTime;

        // Constructor
        public MQController() : base("MQTT_Plugin", new Guid("A5439A35-D4CC-448E-B831-94D00A6EDFAD"))
        { }

        public DateTime StartTime
        {
            get { return mStartTime; }
        }

        #region NexModule
        public override bool PreInitModule(INexLogFormService log_service, IPluginService plugin_service)
        {
            // Check if missing any dependancy (reference, dll)
            return true;
        }

        public override bool InitModule(INexLogFormService log_service, INexCoreService core_service)
        {
            mCoreService = core_service;

            return true;
        }

        public override bool FinishInitModule(INexLogFormService log_service, INexCoreService core_service)
        {
            if(core_service.IsServiceExist(typeof(IMiniService)) == false)
            {
                log_service.WriteLogMessage("Load MQTT plugin faild,  IMiniService not found, please check MiniGRC7R.dll");
                return false;
            }

            // Get Service
            mMiniService = core_service.GetService<IMiniService>(typeof(IMiniService));
            mHomeService = core_service.GetService<IHomeService>(typeof(IHomeService));
            mFuncPageService = core_service.GetService<IFunctionPageService>(typeof(IFunctionPageService));
            mDeviceService = core_service.GetService<IDeviceManagerService>(typeof(IDeviceManagerService));

            //model
            mMQModel = new MQModel(this);
            mMiniGRCControl = new MiniGRCControl(this);

            // Home Item
            mMQItem = new MQItem(this);
            mHomeService.RegisterHomeItem(mMQItem);

            // Start Time
            mStartTime = DateTime.Now;

            //subscribe event
            core_service.EA_Subscribe(this, (int)EventId.CLOSE_MAIN_FORM, MainFormCloseEvent);

            return true;
        }
        #endregion NexModule

        #region receive event
        void MainFormCloseEvent(EventMessage eventMessage)
        {
            mMQModel.Disconnect();            
        }
        #endregion receive event

        #region interface
        public INexCoreService CoreService
        {
            get { return mCoreService; }
        }

        public IHomeService HomeService
        {
            get { return mHomeService; }
        }

        public IFunctionPageService FuncPageService
        {
            get { return mFuncPageService; }
        }

        public IDeviceManagerService DeviceService
        {
            get { return mDeviceService; }
        }

        public IMiniService MiniService { get { return mMiniService; } }

        public MQModel MQModel { get { return mMQModel; } }
        public MiniGRCControl MiniGRCControl { get { return mMiniGRCControl; } }

        #endregion

    }
}
