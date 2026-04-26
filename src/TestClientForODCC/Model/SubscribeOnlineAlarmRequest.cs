using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 在线告警订阅请求
    /// </summary>
    public class SubscribeOnlineAlarmRequest
    {
        /// <summary>
        /// 是否订阅。true：订阅告警；false: 停止订阅。
        /// </summary>
        public bool subscribe { get; set; }
    }
}
