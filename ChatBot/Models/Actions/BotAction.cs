using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatBot.Models.Actions
{
    public abstract class BotAction
    {
        # region members

        public string InvokeString;
        

        public string Action()
        {
            return "";
        }

        # endregion
    }
}