using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace TestBot
{
    internal class MainMenuState : State
    {
        internal override async Task UpdateHandler(User user, Telegram.Bot.ITelegramBotClient arg1, Update arg2)
        {
            if (arg2.CallbackQuery == null)
                return;

            if (arg2.CallbackQuery.Data == "main_state1")
            { // ответные действия
            
            }
            else if (arg2.CallbackQuery.Data == "main_state2")
            {

            }

            await Task.CompletedTask; // заглушка
        }
    }
}