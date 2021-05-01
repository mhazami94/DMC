using Azami.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Helpers;

namespace WebApp.ViewComponents
{
    public class ShowMessageComponent : ViewComponent
    {
        private ShowMessage _message;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (HttpContext != null && HttpContext.Session != null
                && !string.IsNullOrEmpty(HttpContext.Session.GetString("DMC_Message"))
                && !string.IsNullOrEmpty(HttpContext.Session.GetString("DMC_Message_Type"))
                && !string.IsNullOrEmpty(HttpContext.Session.GetString("DMC_Message_Show")))
            {
                _message = new ShowMessage
                {
                    Message = HttpContext.Session.GetString("DMC_Message"),
                    Type = HttpContext.Session.GetString("DMC_Message_Type").ToEnum<MessageType>(),
                    Show = true
                };

            }
            else
            {
                _message = new ShowMessage
                {
                    Show = false
                };
            }
            HttpContext.Session.Clear();
            return await Task.FromResult((IViewComponentResult)View("ShowMessage", _message));
        }
    }
}
