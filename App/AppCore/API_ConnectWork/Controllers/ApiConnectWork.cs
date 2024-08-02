using App.AppCore.Models;

namespace App.AppCore.API_ConnectWork.Controllers
{
    /* --> † 22/03/2022 - Luiz Lenire. <-- */

    public sealed class ApiConnectWork : CommonConnectWork
    {
        #region --> Public properties. <--

        public ServiceResponseConnect<string> Testando()
        {
            ServiceResponseConnect<string> serviceResponseBnafar = GetToken();          

            return serviceResponseBnafar;
        }

        #endregion --> Public properties. <--
    }
}
