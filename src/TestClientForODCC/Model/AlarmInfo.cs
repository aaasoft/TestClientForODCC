using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 告警信息
    /// </summary>
    public class AlarmInfo
    {
        /// <summary>
        /// 告警唯一标识（流水号）。最大长度 64 字节。
        /// </summary>
        public string serial_no { get; set; }
        /// <summary>
        /// 告警产生源。产生此告警对应的告警点或设备的 guid。详见设备对象定义和点位对象定义。
        /// </summary>
        public string guid { get; set; }
        /// <summary>
        /// 告警触发时间。UNIX 时间戳。
        /// </summary>
        public long? trigger_time { get; set; }
        /// <summary>
        /// 告警内容。最大长度 1024 字节。
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 告警级别。
        /// </summary>
        public int alarm_level { get; set; }
        /// <summary>
        /// 设备的告警类别。
        /// </summary>
        public int alarm_type { get; set; }
        /// <summary>
        /// 告警发生时，关联监测点的值。最大长度 64字节。
        /// </summary>
        public string trigger_snapshot { get; set; }
        /// <summary>
        /// 告警发生时的处理方案。最大长度 1024 字节。
        /// </summary>
        public string suggestion { get; set; }
        /// <summary>
        /// 告警恢复时间，为空时表示未恢复。UNIX 时间戳。
        /// </summary>
        public long? recover_time { get; set; }
        /// <summary>
        /// 恢复时的当前值。最大长度 64 字节。
        /// </summary>
        public string recover_snapshot { get; set; }
        /// <summary>
        /// 告警确认时间，为空时表示未确认。UNIX 时间戳。
        /// </summary>
        public long? confirm_time { get; set; }
        /// <summary>
        /// 确认人。最大长度 64 字节。
        /// </summary>
        public string confirm_by { get; set; }
        /// <summary>
        /// 确认描述。最大长度 1024 字节。
        /// </summary>
        public string confirm_description { get; set; }
        /// <summary>
        /// 告警清除时间，为空时表示未清除。UNIX 时间戳。
        /// </summary>
        public long? remove_time { get; set; }
        /// <summary>
        /// 清除人。最大长度 64 字节。
        /// </summary>
        public string remove_by { get; set; }
        /// <summary>
        /// 清除描述。最大长度 1024 字节。
        /// </summary>
        public string remove_description { get; set; }
    }
}
