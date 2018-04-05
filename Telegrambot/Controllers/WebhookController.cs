using RavSoft.GoogleTranslator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Telegram.Bot.Types;

namespace Telegrambot.Controllers
{
    public class WebhookController : ApiController
    {

        Telegram.Bot.TelegramBotClient Bot;
        Translator Translate = new Translator();
        public WebhookController()
        {
            Bot = new Telegram.Bot.TelegramBotClient("438518161:AAG5xVKFbV4uLf_6CtbyocQhbBv7hHLyL5A");
        }
        [HttpPost]
        public async Task<IHttpActionResult> UpdateMsg(Update update)
        {
            try
            {
                if (update.Message.Text == "/start")
                {
                    await Bot.SendTextMessageAsync(update.Message.From.Id, "Welcome To My Bot");
                }
                else {

                    string TranslateRequst = Translate.Translate(update.Message.Text, "Persian", "English" );
                    await Bot.SendTextMessageAsync(update.Message.From.Id, TranslateRequst);
                }

            }
            catch (Exception ex)
            {

                throw;
            }
           
            return Ok(update);
        }
        }
}
