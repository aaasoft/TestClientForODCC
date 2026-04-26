using System;
using System.Text.Json.Serialization;

namespace TestClientForODCC.Model;


[JsonSerializable(typeof(ODCCRequest<LoginRequest>))]
[JsonSerializable(typeof(ODCCResponse<LoginResponse>))]
public partial class ModelsJsonSerializerContext : JsonSerializerContext
{

}