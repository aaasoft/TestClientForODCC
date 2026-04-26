using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 心跳信息
    /// </summary>
    public class HeartBeatInfo
    {
        /// <summary>
        /// 时间。UNIX 时间戳。
        /// </summary>
        public long heartbeat_time { get; set; }
    }
}
