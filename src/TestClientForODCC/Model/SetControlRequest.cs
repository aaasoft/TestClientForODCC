using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// 控制命令请求
    /// </summary>
    public class SetControlRequest
    {
        /// <summary>
        /// 点位对象 guid。详见点位对象定义。
        /// </summary>
        public string guid { get; set; }
        /// <summary>
        /// 要设置的值。最大长度 64 字节。
        /// </summary>
        [StringLength(64)]
        public string value { get; set; }
        /// <summary>
        /// 命令发起时间。UNIX 时间戳。
        /// </summary>
        public long time { get; set; }
    }
}
