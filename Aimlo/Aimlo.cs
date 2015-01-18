using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using AIMLbot;

namespace Aimlo
{
    public class Aimlo
    {
        private const string UserId = "CityU.Scm.David";
        private Bot AimlBot;
        private User myUser;

        public Aimlo()
        {
            AimlBot = new Bot();
            myUser = new User(UserId, AimlBot);
            Initialize();
        }

        public void Initialize()
        {
            AimlBot.loadSettings();
            AimlBot.isAcceptingUserInput = false;
            AimlBot.loadAIMLFromFiles();
            AimlBot.isAcceptingUserInput = true;
        }

        public string getOutput(string input)
        {
            Request request = new Request(input, myUser, AimlBot);
            Result result = AimlBot.Chat(request);
            return result.Output;
        }
    }
}
