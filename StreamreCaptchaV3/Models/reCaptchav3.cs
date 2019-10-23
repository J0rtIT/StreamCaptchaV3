using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace StreamreCaptchaV3.Models
{
    public class reCaptchav3
    {
        public string SiteKey { get; }
        public string Secret { get; }

        public reCaptchav3()
        {
            SiteKey = "6LfIAL8UAAAAAELD5YKPsGnEVvwPnIN0cYcRirr3";
            Secret = "6LfIAL8UAAAAAF2vi9m8EBEaIH99j6LknrQ6jvXH";
        }

        public async Task<CaptchaV3Datos> VerificaToken(string Token)
        {
            var clienteWeb = new HttpClient();
            var resultadoGoogle = await clienteWeb.GetStringAsync($"https://www.google.com/recaptcha/api/siteverify?secret={Secret}&response={Token}");

            var final = JsonConvert.DeserializeObject<CaptchaV3Datos>(resultadoGoogle);
            return final;
        }

    }

    public class CaptchaV3Datos
    {
        public bool success { get; set; }
        public DateTime challenge_ts { get; set; }
        public string hostname { get; set; }
        public float score { get; set; }
        public string action { get; set; }
    }
}