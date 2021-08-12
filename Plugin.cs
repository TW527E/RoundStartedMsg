using System;
using System.Collections.Generic;
using System.Linq;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using UnityEngine;
using Server = Exiled.Events.Handlers.Server;

namespace RoundStartedMsg
{
	public class RoundStartedMsg : Plugin<Configs>
	{
		public static RoundStartedMsg RoundStartedMsgRef { get; set; }

		public EventHandler eventHandlers;

		public RoundStartedMsg()
		{
			RoundStartedMsgRef = this;
		}

		public override void OnEnabled()
		{
			eventHandlers = new EventHandler();
			Server.RoundStarted += eventHandlers.OnRoundStarted;
		}

		public override void OnDisabled()
		{
			Server.RoundStarted += eventHandlers.OnRoundStarted;
			eventHandlers = null;
		}
	}
}
