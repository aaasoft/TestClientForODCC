using System.ComponentModel.DataAnnotations;

namespace TestClientForODCC.Model
{
    /// <summary>
    /// ODCC请求
    /// </summary>
    /// <typeparam name="T">数据体类型</typeparam>
    public class ODCCRequest<T>
    {
        /// <summary>
        /// 协议版本号。
        /// </summary>
        [StringLength(64)]
        public string version { get; set; }
        /// <summary>
        /// 数据体
        /// </summary>
        public T data { get; set; }
    }
}
