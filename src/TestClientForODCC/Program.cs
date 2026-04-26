using System.Net.Http.Json;
using System.Text.Json;
using TestClientForODCC.Model;
using TestClientForODCC.Utils;

Console.WriteLine("Welcome to use TestClientForODCC");
string url, user, password;

#if DEBUG
url = "http://127.0.0.1:3002";
user = "admin";
password = "admin";
#else
    Console.Write("ODCC Url:");
    url = Console.ReadLine();
    Console.Write("User:");
    user = Console.ReadLine();
    Console.Write("Password:");
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
    Console.WriteLine("Begin login...");
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

    var formContent = JsonContent.Create(loginRequest, ModelsJsonSerializerContext.Default.ODCCRequestLoginRequest);

    Console.WriteLine("General:");
    Console.WriteLine("  Request URL: " + apiUrl);
    Console.WriteLine("  Request Method: " + "POST");
    Console.WriteLine("Request Headers:");
    foreach (var header in formContent.Headers)
    {
        Console.WriteLine($"  {header.Key}: {string.Join(",", header.Value)}");
    }
    Console.WriteLine("Form Data:");
    Console.WriteLine("  " + await formContent.ReadAsStringAsync());

    HttpResponseMessage rep;
    string responseStr;
    try
    {
        rep = await httpClent.PostAsync(apiUrl, formContent);
        Console.WriteLine("Response Headers:");
        foreach (var header in rep.Headers)
        {
            Console.WriteLine($"  {header.Key}: {string.Join(",", header.Value)}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Post error." + ex.ToString());
        return;
    }
    try
    {
        Console.WriteLine("Response:");
        responseStr = await rep.Content.ReadAsStringAsync();
        Console.WriteLine($"  {responseStr}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Read data from server error." + ex.ToString());
        return;
    }

    try
    {
        var loginResult = JsonSerializer.Deserialize(responseStr, ModelsJsonSerializerContext.Default.ODCCResponseLoginResponse);
        Console.WriteLine($"Login result: error_code: {loginResult.error_code}, error_msg: {loginResult.error_msg}, login_time: {loginResult.data.login_time}, timeout: {loginResult.data.timeout}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Deserialize json to object error.{ex}");
        return;
    }
}
Console.WriteLine("Test done.");
Console.ReadLine();