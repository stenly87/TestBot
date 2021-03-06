using Telegram.Bot.Types;

namespace TestBot
{
    public class StateMachine
    {
        private readonly User user;
        State state;

        public StateMachine(User user, State defaultState)
        {
            this.user = user;
            SetState(defaultState);
        }

        public void SetState(State newState) => state = newState;

        internal void UpdateHandler(Telegram.Bot.ITelegramBotClient arg1, Update arg2)
        {// передаем команду текущему стейту. Если он ее не сможет обработать, то не судьба
            state.UpdateHandler(user, arg1, arg2);
        }
    }
}