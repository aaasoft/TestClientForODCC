using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 断开连接响应参数
    /// </summary>
    public class LogoutResponse
    {
        /// <summary>
        /// 释放连接时间。UNIX 时间戳。
        /// </summary>
        public long logout_time { get; set; }
    }
}
