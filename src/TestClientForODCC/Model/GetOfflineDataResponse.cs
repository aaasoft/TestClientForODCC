using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 获取离线数据响应
    /// </summary>
    public class GetOfflineDataResponse
    {
        /// <summary>
        /// 策略 id。由监控系统生成幵负责管理每个用户的订阅策略。取值应大于等于 0。
        /// </summary>
        public int strategy_id { get; set; }
        /// <summary>
        /// 要推送的数据。
        /// </summary>
        public DeviceData[] devices { get; set; }
    }
}
