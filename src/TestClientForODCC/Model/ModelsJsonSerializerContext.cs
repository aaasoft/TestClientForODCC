using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TestClientForODCC.Model;


[JsonSerializable(typeof(ODCCRequest<LoginRequest>))]
[JsonSerializable(typeof(ODCCResponse<LoginResponse>))]
[JsonSerializable(typeof(ODCCRequest<GetConfigRequest>))]
[JsonSerializable(typeof(ODCCResponse<GetConfigResponse>))]
[JsonSerializable(typeof(ODCCRequest<GetOnlineDataRequest>))]
[JsonSerializable(typeof(ODCCResponse<GetOnlineDataResponse>))]
[JsonSerializable(typeof(SpaceInfo[]))]
[JsonSerializable(typeof(DeviceData[]))]
public partial class ModelsJsonSerializerContext : JsonSerializerContext
{
    public static ModelsJsonSerializerContext Default2 { get; } = new ModelsJsonSerializerContext(new JsonSerializerOptions()
    {
        WriteIndented = true,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    });
}