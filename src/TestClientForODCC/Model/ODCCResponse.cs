using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// ODCC响应
    /// </summary>
    /// <typeparam name="T">数据体类型</typeparam>
    public class ODCCResponse<T>
    {
        /// <summary>
        /// 错误码。0：正常；非 0：有错误，详见 5.1 错误码。
        /// </summary>
        public int error_code { get; set; }
        /// <summary>
        /// 错误描述。
        /// </summary>
        [StringLength(64)]
        public string error_msg { get; set; }
        /// <summary>
        /// 数据体
        /// </summary>
        public T data { get; set; }

        public static ODCCResponse<T> Ok(T data = default)
        {
            return new ODCCResponse<T>()
            {
                error_code = ErrorCodeConsts.CODE_0,
                error_msg = ErrorCodeConsts.CODE_0_MESSAGE,
                data = data
            };
        }

        public static ODCCResponse<T> Error(int error_code, string message, T data = default)
        {
            return new ODCCResponse<T>()
            {
                error_code = error_code,
                error_msg = message,
                data = data
            };
        }
    }
}
