using System.Net.Http.Json;
using System.Text.Json;
using Quick.Build;
using TestClientForODCC.Model;
using TestClientForODCC.Utils;

Console.WriteLine("欢迎使用ODCC测试客户端");
string url, user, password;

#if DEBUG
url = "http://127.0.0.1:3002";
user = "admin";
password = "admin";
#else
    Console.Write("URL地址:");
    url = Console.ReadLine();
    Console.Write("用户名:");
    user = Console.ReadLine();
    Console.Write("密码:");
    password = Console.ReadLine();
#endif
while (url.EndsWith("/"))
    url = url.Substring(0, url.Length - 1);
var httpClent = new HttpClient()
{
    BaseAddress = new Uri(url)
};
//登录
{
    Console.WriteLine("正在登录...");
    var apiUrl = $"{url}/north/login";
    var loginRequest = new ODCCRequest<LoginRequest>()
    {
        version = "",
        data = new()
        {
            username = user,
            password = CryptographyHelper.ComputeMD5Hash(password)
        }
    };
    try
    {
        var loginResponse = await HttpUtils.Post(httpClent, apiUrl, loginRequest,
            ModelsJsonSerializerContext.Default.ODCCRequestLoginRequest,
            ModelsJsonSerializerContext.Default.ODCCResponseLoginResponse);
        Console.WriteLine($"登录结果: error_code: {loginResponse.error_code}, error_msg: {loginResponse.error_msg}, login_time: {loginResponse.data.login_time}, timeout: {loginResponse.data.timeout}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"将JSON数据反序列化为对象时出错，原因：{ex}");
        return;
    }
}

while (true)
{
    Console.WriteLine("请选择：");
    var selectId = QbSelect.ArrowSelect(new Dictionary<string, string>()
    {
        ["1"] = "在线数据获取",
        ["0"] = "退出",
    }.ToArray());
    switch (selectId)
    {
        case "0":
            return;
        case "1":
            {
                break;
            }
    }
}