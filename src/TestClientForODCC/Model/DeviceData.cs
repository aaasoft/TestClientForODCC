using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    public class DeviceData
    {
        /// <summary>
        /// 设备对象 guid。见设备对象定义。
        /// </summary>
        public string guid { get; set; }
        /// <summary>
        /// 设备的状态。0 表示通信中断，1 表示通信正常。
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 测点数组。相应设备的测点列表。
        /// </summary>
        public PointData[] points { get; set; }
    }
}
