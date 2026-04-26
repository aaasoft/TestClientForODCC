using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 点位事件模型
    /// </summary>
    public class PointEventModel
    {
        /// <summary>
        /// 告警唯一标识（流水号）。最大长度 64 字节。
        /// </summary>
        public string serial_no { get; set; }
        /// <summary>
        /// 告警关联的点位对象 guid。详见点位对象定义。
        /// </summary>
        public string guid { get; set; }
        /// <summary>
        /// 消息类型。1=触发，2=恢复。
        /// </summary>
        public int msg_type { get; set; }
        /// <summary>
        /// 告警产生/恢复时间。UNIX 时间戳。
        /// </summary>
        public long time { get; set; }
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
        /// 关联监测点的当前值。最大长度 64 字节。
        /// </summary>
        public string snapshot { get; set; }
        /// <summary>
        /// 告警处理建议。最大长度 1024 字节。
        /// </summary>
        public string suggestion { get; set; }
    }
}
