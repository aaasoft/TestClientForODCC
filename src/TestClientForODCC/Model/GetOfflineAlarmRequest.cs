using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 离线告警拉取请求
    /// </summary>
    public class GetOfflineAlarmRequest
    {
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
