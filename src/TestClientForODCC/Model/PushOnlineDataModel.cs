using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    public class PushOnlineDataModel
    {
        /// <summary>
        /// 策略 id。由监控系统生成并负责管理每个用户的订阅策略。取值应大于等于 0。
        /// </summary>
        public int strategy_id { get; set; }
        /// <summary>
        /// 设备数组。设备列表。
        /// </summary>
        public IEnumerable<DeviceData> devices { get; set; }
    }
}
