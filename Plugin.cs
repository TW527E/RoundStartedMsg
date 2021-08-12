using Exiled.API.Features;
using Server = Exiled.Events.Handlers.Server;

namespace RoundStartedMsg
{
    public class Plugin : Plugin<Config>
    {


        public static Plugin Singleton;


        public override string Prefix => "RoundStartedMsg";



        private EventHandlers EventHandlers;

        public override void OnEnabled()
        {
            Singleton = this;
            EventHandlers = new EventHandlers();


            Server.RoundStarted += EventHandlers.OnRoundStarted;



            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Server.RoundStarted -= EventHandlers.OnRoundStarted;
            EventHandlers = null;
            Singleton = null;
            base.OnDisabled();
        }
    }
}

