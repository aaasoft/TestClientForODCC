using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 获取离线数据请求
    /// </summary>
    public class GetOfflineDataRequest
    {
        /// <summary>
        /// 策略 id。由监控系统生成幵负责管理每个用户的订阅策略。取值应大于等于 0。
        /// </summary>
        public int strategy_id { get; set; }
        /// <summary>
        /// 开始时间。UNIX 时间戳。
        /// </summary>
        public long begin_time { get; set; }
        /// <summary>
        /// 结束时间。UNIX 时间戳。
        /// </summary>
        public long end_time { get; set; }
    }
}
