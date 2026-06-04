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
    var request = new ODCCRequest<LoginRequest>()
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
        var response = await HttpUtils.Post(httpClent, apiUrl, request,
            ModelsJsonSerializerContext.Default2.ODCCRequestLoginRequest,
            ModelsJsonSerializerContext.Default2.ODCCResponseLoginResponse);
        Console.WriteLine($"响应: error_code: {response.error_code}, error_msg: {response.error_msg}");
        Console.WriteLine($"登录结果: login_time: {response.data.login_time}, timeout: {response.data.timeout}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"登录时出错，原因：{ex}");
        return;
    }
}

while (true)
{
    Console.WriteLine("请选择：");
    var selectId = QbSelect.ArrowSelect(new Dictionary<string, string>()
    {
        ["1"] = "配置获取",
        ["2"] = "在线数据获取",
        ["0"] = "退出",
    }.ToArray());
    switch (selectId)
    {
        case "0":
            return;
        //配置获取
        case "1":
            {
                var apiUrl = $"{url}/north/config_get";
                var request = new ODCCRequest<GetConfigRequest>()
                {
                    version = "",
                    data = new()
                    {
                        version = ""
                    }
                };
                try
                {
                    var response = await HttpUtils.Post(httpClent, apiUrl, request,
                        ModelsJsonSerializerContext.Default2.ODCCRequestGetConfigRequest,
                        ModelsJsonSerializerContext.Default2.ODCCResponseGetConfigResponse);
                    Console.WriteLine($"响应: error_code: {response.error_code}, error_msg: {response.error_msg}");
                    Console.WriteLine($"配置: {JsonSerializer.Serialize(response.data.nodes, ModelsJsonSerializerContext.Default2.SpaceInfoArray)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"获取配置时出错，原因：{ex}");
                    return;
                }
                break;
            }
        //在线数据获取
        case "2":
            {
                Console.Write("位置编号:");
                var space_guid = Console.ReadLine();
                Console.Write("设备编号:");
                var device_guid = Console.ReadLine();
                Console.Write("点位编号:");
                var point_guid = Console.ReadLine();

                var apiUrl = $"{url}/north/online_data_get";
                var request = new ODCCRequest<GetOnlineDataRequest>()
                {
                    version = "",
                    data = new()
                    {
                        space_guids = string.IsNullOrEmpty(space_guid) ? null : space_guid.Split(','),
                        device_guids = string.IsNullOrEmpty(device_guid) ? null : device_guid.Split(','),
                        point_guids = string.IsNullOrEmpty(point_guid) ? null : point_guid.Split(','),
                    }
                };
                try
                {
                    var response = await HttpUtils.Post(httpClent, apiUrl, request,
                        ModelsJsonSerializerContext.Default2.ODCCRequestGetOnlineDataRequest,
                        ModelsJsonSerializerContext.Default2.ODCCResponseGetOnlineDataResponse);
                    Console.WriteLine($"响应: error_code: {response.error_code}, error_msg: {response.error_msg}");
                    Console.WriteLine($"数据: {JsonSerializer.Serialize(response.data.devices, ModelsJsonSerializerContext.Default2.DeviceDataArray)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"获取在线数据时出错，原因：{ex}");
                    return;
                }
                break;
            }
    }
}