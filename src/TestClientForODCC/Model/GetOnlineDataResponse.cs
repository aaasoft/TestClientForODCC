using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 获取在线数据响应
    /// </summary>
    public class GetOnlineDataResponse
    {
        /// <summary>
        /// 设备数组。设备列表。
        /// </summary>
        public DeviceData[] devices { get; set; }
    }
}
