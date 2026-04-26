using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 在线数据订阅策略
    /// </summary>
    public class OnlineDataStrategy
    {
        /// <summary>
        /// 订阅策略的 id。由监控系统生成幵负责管理每个用户的订阅策略。取值应大于等于 0。
        /// </summary>
        public int strategy_id { get; set; }
        /// <summary>
        /// 订阅策略名称。任意字符串，最大长度 64 字节。
        /// </summary>
        public string name { get; set; }
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
        /// <summary>
        /// 1=实时;2=周期;3=变化;4=周期+变化。
        /// </summary>
        public int mode { get; set; }
    }
}
