using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 离线告警拉取响应
    /// </summary>
    public class GetOfflineAlarmResponse
    {
        /// <summary>
        /// 告警数组。
        /// </summary>
        public AlarmInfo[] alarms { get; set; }
    }
}
