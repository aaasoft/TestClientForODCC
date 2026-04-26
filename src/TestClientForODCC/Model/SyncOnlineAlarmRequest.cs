using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 告警操作同步请求
    /// </summary>
    public class SyncOnlineAlarmRequest
    {
        /// <summary>
        /// 操作时间。UNIX 时间戳。
        /// </summary>
        public long time { get; set; }
        /// <summary>
        /// 操作人。最大长度 64 字节。
        /// </summary>
        public string by { get; set; }
        /// <summary>
        /// 消息类型。3=确认，4=清除。
        /// </summary>
        public int msg_type { get; set; }
        /// <summary>
        /// 告警列表。
        /// </summary>
        public SyncOnlineAlarmRequestItem[] alarms { get; set; }
    }

    /// <summary>
    /// 告警操作同步事件对象
    /// </summary>
    public class SyncOnlineAlarmRequestItem
    {
        /// <summary>
        /// 告警唯一标识（流水号）。最大长度 64 字节。
        /// </summary>
        public string serial_no { get; set; }
        /// <summary>
        /// 操作描述。最大长度 1024 字节。
        /// </summary>
        public string description { get; set; }
    }
}
