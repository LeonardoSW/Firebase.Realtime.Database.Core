namespace Firebase.Realtime.Database.Core.Services
{
    public class FirebaseClient
    {
        private readonly IHttpClientFactory _httpClient;
        public string UrlDatabase { get; set; }
        public string Auth { get; set; }

        public FirebaseClient(string urlBase, string authKey)
        {
            UrlDatabase = urlBase;
            Auth = authKey;
        }

        public string GetCollection(string collection)
            => $"{collection}.json";
    }
}
