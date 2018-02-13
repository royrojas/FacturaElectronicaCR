using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace FacturaElectronicaCR_CS
{
    class TokenHacienda
    {

        public string accessToken { get; set; }
        public string refreshToken { get; set; }

        public async void GetTokenHacienda(string usuario, string password)
        {
            try
            {
                accessToken = "";
                refreshToken = "";

                string IDP_CLIENT_ID = "api-stag";
                string IDP_URI = "https://idp.comprobanteselectronicos.go.cr/auth/realms/rut-stag/protocol/openid-connect/token";

                HttpClient http = new HttpClient();
                List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
                param.Add(new KeyValuePair<string, string>("client_id", IDP_CLIENT_ID));
                param.Add(new KeyValuePair<string, string>("grant_type", "password"));
                param.Add(new KeyValuePair<string, string>("username", usuario));
                param.Add(new KeyValuePair<string, string>("password", password));
                FormUrlEncodedContent content = new FormUrlEncodedContent(param);

                HttpResponseMessage response = http.PostAsync(IDP_URI, content).Result;
                string res = await response.Content.ReadAsStringAsync();
                Token tk = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(res);
                if ((response.StatusCode != System.Net.HttpStatusCode.OK))
                {
                    throw new Exception(("Error: " + response.GetHashCode()));
                }

                accessToken = tk.access_token;
                refreshToken = tk.refresh_token;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
