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
        public readonly Plugin<Configs> plugin;
        public EventHandler(Plugin<Configs> plugin) => this.plugin = plugin;

        public EventHandler()
        {
        }

        public void OnRoundStarted()
        {
            Map.Broadcast(duration: RoundStartedMsg.RoundStartedMsgRef.Config.HowLong, message: RoundStartedMsg.RoundStartedMsgRef.Config.OnRoundStarted);
        }
    }
}
