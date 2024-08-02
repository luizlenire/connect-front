using App.AppCore.API_ConnectWork.Models;
using App.AppCore.Models;
using Newtonsoft.Json;
using RestSharp;

namespace App.AppCore.API_ConnectWork.Controllers
{
    /* --> † 22/03/2022 - Luiz Lenire. <-- */

    public abstract class CommonConnectWork
    {
        #region --> Public static properties. <--

        public const string Address = "";

        public const string Username = "";

        public const string Password = "";

        #endregion --> Public static properties. <--

        #region --> Private methods. <--

        protected ServiceResponseConnect<string> GetToken()
        {
            RestClient restClient = new(Address + "authentication/token/generate");
            RestRequest restRequest = new(Method.POST);
            restRequest.AddHeader("authorization", "Basic " + Username);
            restRequest.AddParameter("application/json", JsonConvert.SerializeObject(new ConnectLogin() { Username = Username, Password = Password }), ParameterType.RequestBody);

            return JsonConvert.DeserializeObject<ServiceResponseConnect<string>>(restClient.Execute(restRequest).Content);
        }

        #endregion --> Private methods. <--
    }
}
