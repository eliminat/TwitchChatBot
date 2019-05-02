using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchChat.Bot.Core
{
    public interface IAutomatedMessage
    {

        void Initialize(DateTime currentTime);

        bool IsItYourTimeToDisplay(DateTime currentTime);

        string GetMessageInstance(DateTime currentTime);
    }
}
