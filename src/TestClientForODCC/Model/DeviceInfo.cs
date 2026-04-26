using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 设备对象
    /// </summary>
    public class DeviceInfo
    {
        /// <summary>
        /// 全局 ID 本地监控系统内唯一。使用长度为 32 个字符的标准 GUID, 格式为“xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx”，其中每个 x 是0-9 或 a-f 范围内的一个字符。例如：6F9619FF-8B86-D011-B42D-00C04FC964FF。
        /// </summary>
        [StringLength(36)]
        public string guid { get; set; }
        /// <summary>
        /// 路径标识 只能用字母、数字和下划线，丌同层级下可重复。
        /// </summary>
        [StringLength(64)]
        public string tag { get; set; }
        /// <summary>
        /// 绝对路径 父级及以上 tag 的组合。路径以“/”作为分隔符。例：/A/B 。
        /// </summary>
        [StringLength(1024)]
        public string path { get; set; }
        /// <summary>
        /// 设备名称 任意字符串。
        /// </summary>
        [StringLength(64)]
        public string name { get; set; }
        /// <summary>
        /// 节点类型 1:空间节点 2:设备节点 3:点位节点
        /// </summary>
        public int node_type { get; set; } = 2;
        /// <summary>
        /// 设备类型 用户自定义。推荐使用《互联网数据中心-基础设施监控指标规范》中定义的“与业 id+大类 id+子类 id”。
        /// </summary>
        [StringLength(64)]
        public string device_type { get; set; }
        /// <summary>
        /// 点位列表
        /// </summary>
        public List<PointInfo> nodes { get; set; } = new List<PointInfo>();

        /// <summary>
        /// 原始编号
        /// </summary>
        [JsonIgnore]
        public string raw_id { get; set; }

        public DeviceData ToDeviceData(IEnumerable<PointInfo> points = null)
        {
            return new DeviceData()
            {
                guid = guid,
                points = (points ?? nodes).Select(t => t.ToPointData()).ToArray(),
                status = 1
            };
        }
    }
}
