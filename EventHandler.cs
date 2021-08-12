using System;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using Player = Exiled.API.Features.Player;

namespace RoundStartedMsg
{
    public class EventHandler
    {

        public EventHandler()
        {
        }

        public void OnRoundStarted()
        {
            Map.Broadcast(RoundStartedMsg.RoundStartedMsgRef.Config.HowLong, RoundStartedMsg.RoundStartedMsgRef.Config.OnRoundStarted);
        }
    }
}
