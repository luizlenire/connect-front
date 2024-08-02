using System.ComponentModel.DataAnnotations;

namespace App.AppCore.API_ConnectWork.Models
{
    /* --> † 22/03/2022 - Luiz Lenire. <-- */

    public sealed class ConnectLogin
    {
        #region --> Public properties. <--

        [Required(ErrorMessage = "É necessario informar um username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "É necessario informar um password.")]
        public string Password { get; set; }

        #endregion --> Public properties. <--
    }
}
