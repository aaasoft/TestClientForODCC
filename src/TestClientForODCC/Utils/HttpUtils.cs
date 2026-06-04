using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace TestClientForODCC.Utils;

public class HttpUtils
{
    public static async Task<string> Post<TRequestData>(HttpClient httpClient, string apiUrl, TRequestData requestData, JsonTypeInfo<TRequestData> requestDataTypeInfo)
    {
        var formContent = JsonContent.Create(requestData, requestDataTypeInfo);

        Console.WriteLine("General:");
        Console.WriteLine("  Request URL: " + apiUrl);
        Console.WriteLine("  Request Method: " + "POST");
        Console.WriteLine("Request Headers:");
        foreach (var header in formContent.Headers)
        {
            Console.WriteLine($"  {header.Key}: {string.Join(",", header.Value)}");
        }
        Console.WriteLine("Content:");
        Console.WriteLine("  " + await formContent.ReadAsStringAsync());

        HttpResponseMessage rep;
        string responseStr;
        try
        {
            rep = await httpClient.PostAsync(apiUrl, formContent);
            Console.WriteLine("Response Headers:");
            foreach (var header in rep.Headers)
            {
                var headerKey = header.Key;
                var headerValue = string.Join(",", header.Value);
                if (headerKey == "token")
                {
                    httpClient.DefaultRequestHeaders.Add(headerKey, headerValue);
                }
                Console.WriteLine($"  {headerKey}: {headerValue}");
            }
        }
        catch (Exception ex)
        {
            throw new IOException("POST请求错误", ex);
        }
        try
        {
            Console.WriteLine("Response:");
            responseStr = await rep.Content.ReadAsStringAsync();
            Console.WriteLine($"  {responseStr}");
            return responseStr;
        }
        catch (Exception ex)
        {
            throw new IOException("从服务器读取数据错误", ex);
        }
    }

    public static async Task<TResponseData> Post<TRequestData, TResponseData>(HttpClient httpClient, string apiUrl, TRequestData requestData, JsonTypeInfo<TRequestData> requestDataTypeInfo, JsonTypeInfo<TResponseData> responseDataTypeInfo)
    {
        var responseStr = await Post(httpClient, apiUrl, requestData, requestDataTypeInfo);
        try
        {
            return JsonSerializer.Deserialize(responseStr, responseDataTypeInfo);
        }
        catch (Exception ex)
        {
            throw new IOException("将JSON数据反序列化为对象时出错", ex);
        }
    }
}
