using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 增加在线数据订阅策略响应
    /// </summary>
    public class AddOnlineDataStrategyResponse
    {
        /// <summary>
        /// 订阅策略 id。由监控系统生成幵负责管理每个用户的订阅策略。取值应大于等于 0。
        /// </summary>
        public int strategy_id { get; set; }
    }
}
