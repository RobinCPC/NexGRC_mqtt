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

using mqtt_plugin.View.HomeItem;

namespace mqtt_plugin.Controller
{
    [Export(typeof(NexModule))]
    class MQController : NexModule, IntMQService
    {
        // Service
        private INexCoreService mCoreService = null;
        private IHomeService mHomeService = null;
        private IFunctionPageService mFuncPageService = null;
        private IDeviceManagerService mDeviceService = null;

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
            // Get Service
            mHomeService = core_service.GetService<IHomeService>(typeof(IHomeService));
            mFuncPageService = core_service.GetService<IFunctionPageService>(typeof(IFunctionPageService));
            mDeviceService = core_service.GetService<IDeviceManagerService>(typeof(IDeviceManagerService));

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
            NexMessageBox.Show("MQTT Plugin test!\n\n", "Testing Close Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion

    }
}
