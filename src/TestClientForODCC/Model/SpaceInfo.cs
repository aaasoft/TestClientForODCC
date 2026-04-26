using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 空间对象
    /// </summary>
    public abstract class SpaceInfo
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
        /// 空间名称 任意字符串。
        /// </summary>
        [StringLength(64)]
        public string name { get; set; }
        /// <summary>
        /// 节点类型 1:空间节点 2:设备节点 3:点位节点
        /// </summary>
        public int node_type { get; set; } = 1;
        /// <summary>
        /// 空间类型 用户自定义。推存使用“DC、楼宇、房间、匙域”等。
        /// </summary>
        [StringLength(64)]
        public string space_type { get; set; }
        /// <summary>
        /// 子节点
        /// </summary>
        public object[] nodes { get; set; }
    }

    /// <summary>
    /// 带空间子节点的空间信息对象
    /// </summary>
    public class SpaceInfo_WithSpaceInfoChildren : SpaceInfo
    {
        /// <summary>
        /// 设备节点
        /// </summary>
        public new List<SpaceInfo> nodes { get; set; } = new List<SpaceInfo>();
    }

    /// <summary>
    /// 带设备子节点的空间信息对象
    /// </summary>
    public class SpaceInfo_WithDeviceChildren : SpaceInfo
    {
        /// <summary>
        /// 设备节点
        /// </summary>
        public new List<DeviceInfo> nodes { get; set; } = new List<DeviceInfo>();
    }
}
