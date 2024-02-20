using RestSharp;

namespace Core
{
    public class APIHelper
    {
        public static string Post(APIConfig config, object body,
            Dictionary<string, string> headers, Dictionary<string, string> queryParams)
        {
            var client = new RestClient(config.BaseUrl);
            var request = new RestRequest(config.Endpoint, Method.Post);
            
            request.AddHeaders(headers);
            
            foreach (var query in queryParams)
            {
                request.AddQueryParameter(query.Key, query.Value);
            }

            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);

            var response = client.Execute(request);
            return response.Content;
        }
    }
}
