namespace TestClientForODCC.Model
{
    /// <summary>
    /// 建立连接请求参数
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// 用户名。只能为字母、数字和下划线；最大长度 64 字节。
        /// </summary>
        public string username { get; set; }
        /// <summary>
        /// 密码。md5 码，最大长度 64 字节。
        /// </summary>
        public string password { get; set; }
    }
}
