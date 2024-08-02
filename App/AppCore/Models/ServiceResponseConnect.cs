namespace App.AppCore.Models
{
    /* --> † 22/03/2022 - Luiz Lenire. <-- */

    public sealed class ServiceResponseConnect<T> : ServiceResultConnect
    {
        #region --> Public properties. <--

        public T obj { get; set; }

        #endregion --> Public properties. <--
    }
}
