using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;

namespace TestBot
{
    public class User
    {
        public long Id { get; internal set; }
        public string UserName { get; internal set; }

        public StateMachine State { get; set; }

        public User()
        {
            State = new StateMachine(this, new DefaultState());
        }
    }
}
