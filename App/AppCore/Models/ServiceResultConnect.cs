namespace App.AppCore.Models
{
    /* --> † 22/03/2022 - Luiz Lenire. <--*/

    public abstract class ServiceResultConnect
    {
        #region --> Public properties. <--

        public bool success { get; set; }

        public string message { get; set; }

        #endregion --> Public properties. <--
    }
}
