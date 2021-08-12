using Exiled.API.Features;


namespace RoundStartedMsg
{
    public class EventHandlers
    {

        public void OnRoundStarted()
        {
            Map.Broadcast(Plugin.Singleton.Config.HowLong, Plugin.Singleton.Config.OnRoundStarted);
        }
    }
}
