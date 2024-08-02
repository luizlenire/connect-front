using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Extensions
{
    /* --> † 24/03/2022 - Luiz Lenire. <-- */

    public class BaseController : PageModel
    {
        #region --> Public properties. <--

        public enum NotificationType
        {
            Success = 1,
            Error = 2,
            Info = 3
        }
        public enum NotificationPosition
        {
            Top = 1,
            TopStart = 2,
            TopEnd = 3,
            Center = 4,
            CenterStart = 5,
            CenterEnd = 6,
            Bottom = 7,
            BottomStart = 8,
            BottomEnd = 9
        }

        #endregion --> Public properties. <--

        #region --> Private properties. <--

        private string position = "";

        #endregion --> Private properties. <--

        #region --> Public methods. <--

        public void BasicMessage(string title, string message, NotificationType notificationType)
        {
            TempData["notification"] = $"Swal.fire('{title}','{message}', '{notificationType.ToString().ToLower()}')";
        }

        public void AdvancedMessage(string title, string message, NotificationType notificationType, NotificationPosition notificationPosition, bool showConfirmButton = false, int timer = 2000, bool toast = true)
        {
            SetPosition(notificationPosition.ToString());

            TempData["notification"] = "Swal.fire({customClass:{confirmButton:'btn btn-primary',cancelButton:'btn btn-danger'},position:'" + position + "',type:'" + notificationType.ToString().ToLower() +
                "',title:'" + title + "',text: '" + message + "',showConfirmButton: " + showConfirmButton.ToString().ToLower() + ",confirmButtonColor: '#4F0DA2',toast: "
                + toast.ToString().ToLower() + ",timer: " + timer + "}); ";
        }

        public void TimerMessageMessage(string title, string message, NotificationType notificationType)
        {
            TempData["notification"] = @" 
let timerInterval
Swal.fire({
            title: '" + title + @"',
  html: 'Você será redirecionado em <b></b> segundos.',
  timer: 2000,
  timerProgressBar: true,
  didOpen: () => {
      Swal.showLoading()
    const b = Swal.getHtmlContainer().querySelector('b')
    timerInterval = setInterval(() => {
        b.textContent = Swal.getTimerLeft()
    }, 100)
  },
  willClose: () => {
      clearInterval(timerInterval)
  }
}).then((result) => {             
                if (result.dismiss === Swal.DismissReason.timer)
                {
                    console.log('I was closed by the timer')
                }
            })";
        }

        #endregion --> Public methods. <--

        #region --> Private methods. <--

        private void SetPosition(string position)
        {
            if (position == "Top") this.position = "top";
            if (position == "TopStart") this.position = "top-start";
            if (position == "TopEnd") this.position = "top-end";
            if (position == "Center") this.position = "center";
            if (position == "CenterStart") this.position = "center-start";
            if (position == "CenterEnd") this.position = "center-end";
            if (position == "Bottom") this.position = "bottom";
            if (position == "BottomStart") this.position = "bottom-start";
            if (position == "BottomEnd") this.position = "bottom-end";
        }

        #endregion --> Private methods. <--
    }
}
