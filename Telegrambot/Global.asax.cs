 
using System;
 
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Telegram.Bot.Types.ReplyMarkups;
 

namespace Telegrambot
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

        
            Telegram.Bot.TelegramBotClient bot = new Telegram.Bot.TelegramBotClient("438518161:AAG5xVKFbV4uLf_6CtbyocQhbBv7hHLyL5A");
           bot.SetWebhookAsync("https://f5dbfba1.ngrok.io/api/webhook").Wait();
           
        }
    }
}
