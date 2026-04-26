using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 获取配置请求
    /// </summary>
    public class GetConfigRequest
    {
        /// <summary>
        /// 集成平台端的配置信息版本号。最大长度 64 字节。集成平台初始化时，参数为 null。后续获取配置时，该参数为监控系统最后应答的“version”值。
        /// </summary>
        [StringLength(64)]
        public string version { get; set; }
    }
}
