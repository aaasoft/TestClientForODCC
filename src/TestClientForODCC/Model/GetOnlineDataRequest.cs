using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 获取在线数据请求
    /// </summary>
    public class GetOnlineDataRequest
    {
        /// <summary>
        /// 空间节点 guid 数组。
        /// </summary>
        public string[] space_guids { get; set; }
        /// <summary>
        /// 设备节点 guid 数组。
        /// </summary>
        public string[] device_guids { get; set; }
        /// <summary>
        /// 测点节点 guid 数组。
        /// </summary>
        public string[] point_guids { get; set; }
    }
}
