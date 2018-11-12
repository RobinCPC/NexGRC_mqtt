using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NEXCOM.GRC.Framework;
using NEXCOM.Modules.Device;
using NEXCOM.Modules.Home;
using NEXCOM.Modules.Function;

using MiniGRC;

namespace mqtt_plugin
{
    public interface IntMQService
    {
        /// <summary>
        /// The interface of CoreService Object
        /// </summary>
        INexCoreService CoreService { get; }

        /// <summary>
        /// The interface of HomeService Object
        /// </summary>
        IHomeService HomeService { get; }

        /// <summary>
        /// The interface of FuncPageService Object
        /// </summary>
        IFunctionPageService FuncPageService { get; }

        /// <summary>
        /// The interface of DeviceManagerService Object
        /// </summary>
        IDeviceManagerService DeviceService { get; }

        IMiniService MiniService { get; }
        MQModel MQModel {get;}
        MiniGRCControl MiniGRCControl { get; }
    }
}
