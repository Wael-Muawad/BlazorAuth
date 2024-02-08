using Blazored.SessionStorage;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Last.Client.Utils
{
    public static class DIExtensions
    {

        public static void RegisterServices(this IServiceCollection services)
        {

            //services.AddScoped(ht => new HttpClient()
            //{
            //    BaseAddress = new Uri("https://qa-lynxedgeapis-identity-ae.azurewebsites.net/")
            //});
            //services.AddScoped<IAuthenticationService, AuthenticationService>();

            //services.AddBlazoredSessionStorage(config => {
            //    config.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
            //    //config.JsonSerializerOptions.IgnoreNullValues = true;
            //    config.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            //    config.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
            //    config.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
            //    config.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            //    config.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
            //    config.JsonSerializerOptions.WriteIndented = false;
            //});


        }
    }
}
