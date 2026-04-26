using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 推送点位事件模型
    /// </summary>
    public class PushPointEventsModel
    {
        /// <summary>
        /// 告警数组。
        /// </summary>
        public IEnumerable<PointEventModel> alarms { get; set; }
    }
}
