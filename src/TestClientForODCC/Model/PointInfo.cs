using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 点位对象
    /// </summary>
    public class PointInfo
    {
        /// <summary>
        /// 点位 guid 点位 guid 规则为：设备 guid.id。
        /// </summary>
        [StringLength(64)]
        public string guid { get; set; }
        /// <summary>
        /// 点位 id 同一设备下点位 id 唯一。
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 设备名称 任意字符串。
        /// </summary>
        [StringLength(64)]
        public string name { get; set; }
        /// <summary>
        /// 节点类型 1:空间节点 2:设备节点 3:点位节点
        /// </summary>
        public int node_type { get; set; } = 3;
        /// <summary>
        /// 点位类型 点位分类：1=AI；2=DI；3=AO；4=DO；5=Alarm
        /// </summary>
        public int point_type { get; set; }
        /// <summary>
        /// 单位 点位的单位。
        /// </summary>
        [StringLength(64)]
        public string unit { get; set; }
        /// <summary>
        /// 值的含义 DI/DO 的取值含义。格式如：“1=开门;0=关门”。
        /// </summary>
        [StringLength(1024)]
        public string status_map { get; set; }
        /// <summary>
        /// 告警级别 告警级别，级别定义推荐使用附录 1。
        /// </summary>
        public int alarm_level { get; set; }
        /// <summary>
        /// 告警类别 设备的告警类别。推荐使用《互联网数据中心-基础设施监控指标规范》中定义的告警类别。
        /// </summary>
        public int alarm_type { get; set; }
        /// <summary>
        /// 上传周期 上传数据的时间间隔，单位为秒。取值应大于 0。
        /// </summary>
        public int period { get; set; }
        /// <summary>
        /// 变化百分比阈值 上传数据的百分比阈值。取值应大于等于 0。
        /// </summary>
        public float percentage { get; set; }

        public PointData ToPointData()
        {
            return new PointData()
            {
                id = id,
                value = Value,
                timestamp = Utils.DateUtils.ToUnixTimestamp(ValueUpdateTime)
            };
        }

        /// <summary>
        /// 变化绝对值阈值 上传数据的绝对值阈值。取值应大于等于 0。
        /// </summary>
        public float abs_value { get; set; }
        /// <summary>
        /// AO 控制范围AO 的合法控制范围。格式如：“min=15;max=30”。
        /// </summary>
        [StringLength(1024)]
        public string ao_bound { get; set; }

        private string _Value;
        /// <summary>
        /// 实时值
        /// </summary>
        [JsonIgnore]
        public string Value
        {
            get { return _Value; }
            set
            {
                PreValue = value;
                _Value = value;
                ValueUpdateTime = DateTime.Now;
            }
        }

        /// <summary>
        /// 上次实时值
        /// </summary>
        [JsonIgnore]
        public string PreValue { get; set; }

        /// <summary>
        /// 值的刷新时间
        /// </summary>
        [JsonIgnore]
        public DateTime ValueUpdateTime { get; set; }

        /// <summary>
        /// 点位所属的设备
        /// </summary>
        [JsonIgnore]
        public DeviceInfo Device { get; set; }

        public override int GetHashCode()
        {
            return guid.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var b = obj as PointInfo;
            if (b == null)
                return false;
            return guid == b.guid;
        }
    }
}
