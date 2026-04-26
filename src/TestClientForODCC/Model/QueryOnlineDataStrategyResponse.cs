using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 查询在线数据订阅策略响应
    /// </summary>
    public class QueryOnlineDataStrategyResponse
    {
        /// <summary>
        /// 策略数组。
        /// </summary>
        public OnlineDataStrategy[] strategies { get; set; }
    }
}
