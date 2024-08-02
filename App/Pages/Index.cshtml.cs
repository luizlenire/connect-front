using App.AppCore.API_ConnectWork.Models;
using App.AppCore.Models;
using App.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace App.Pages
{
    /* --> † 24/03/2022 - Luiz Lenire. <-- */

    public sealed class IndexModel : BaseController
    {
        #region --> Public properties. <--     

        [BindProperty(SupportsGet = true)]
        public ConnectLogin connectLogin { get; set; }

        [BindProperty(SupportsGet = true)]
        public int TypeOfSystem { get; set; }

        #endregion --> Public properties. <--

        #region --> Constructors. <--

        public IndexModel(IConfiguration _configuration)
        {
            IConfiguration configuration = _configuration;          
        }

        #endregion --> Constructors. <--

        #region --> Public methods. <--

        public IActionResult OnPost()
        {
            if (connectLogin.Username != default &&
                connectLogin.Username != default &&
                CartaoBarueri())
            {
                //return Redirect("ConnectWork/Index");
            }

            return default;
        }

        #endregion --> Public methods. <--

        #region --> Private methods. <--

        public bool CartaoBarueri()
        {
            ServiceResponseConnect<string> serviceResponseConnect = default;

            if (serviceResponseConnect != default && serviceResponseConnect.success)
            {
                HttpContext.Session.SetString("token", serviceResponseConnect.obj);
                return true;
            }
            else
            {
                BasicMessage("Alerta", serviceResponseConnect.message, NotificationType.Info);
                return default;
            }
        }

        #endregion --> Private methods. <--
    }
}
