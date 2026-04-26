using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 建立连接响应参数
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// 登录时间。采用 ISO 8601 UTC 时间，例：20150607T152000+08 。
        /// </summary>
        public DateTime login_time { get; set; }
        /// <summary>
        /// 最大保活时限。单位为秒。监控系统在 timeout 内未收到集成平台的任何请求，则讣为集成平台已掉线。
        /// </summary>
        public int timeout { get; set; }
    }
}
