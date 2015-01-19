using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using AIMLbot;
using AIMLbot.Utils;

namespace Aimlo
{
    public class Aimlo
    {
        private const string UserId = "CityU.Scm.David";
        private readonly Bot _aimlBot;
        private readonly User _myUser;

        public Aimlo()
        {
            _aimlBot = new Bot();
            _myUser = new User(UserId, _aimlBot);
            Initialize();
        }

        private void Initialize()
        {
            _aimlBot.loadSettings();
            _aimlBot.isAcceptingUserInput = false;
            _aimlBot.loadAIMLFromFiles();
            _aimlBot.isAcceptingUserInput = true;
        }

        public string GetOutput(string input)
        {
            Request request = new Request(input, _myUser, _aimlBot);
            Result result = _aimlBot.Chat(request);
            return result.Output;
        }
    }
}