using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 获取配置响应
    /// </summary>
    public class GetConfigResponse
    {
        /// <summary>
        /// 监控系统端的配置信息版本号。最大长度 64 字节。
        /// </summary>
        [StringLength(64)]
        public string version { get; set; }
        /// <summary>
        /// 节点对象列表。当集成平台与监控系统的 version 一致时，该参数应为 null。参考 3.2 定义的设备对象与点位对象。
        /// </summary>
        public SpaceInfo[] nodes { get; set; }
    }
}
