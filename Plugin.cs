using System;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Server = Exiled.Events.Handlers.Server;

namespace RoundStartedMsg
{
	public class RoundStartedMsg : Plugin<Configs>
	{
		public static Plugin Singleton;

		public EventHandler eventHandlers;

		public RoundStartedMsg()
		{
			RoundStartedMsgRef = this;
		}

		public override void OnEnabled()
		{
                        Singleton = this;
			eventHandlers = new EventHandler();
			Server.RoundStarted += eventHandlers.OnRoundStarted;
			
			base.OnEnabled();
		}

		public override void OnDisabled()
		{        
		        Singleton = null;
			Server.RoundStarted += eventHandlers.OnRoundStarted;
			eventHandlers = null;
		}
	}
}
