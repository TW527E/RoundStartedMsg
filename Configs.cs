using Exiled.API.Interfaces;

namespace RoundStartedMsg
{
    public sealed class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [System.ComponentModel.Description("How long does it last")]
        public ushort HowLong { get; set; } = 5;
        [System.ComponentModel.Description("When Round Started Message")]
        public string OnRoundStarted { get; set; } = "<color=red>Go! Don't AFK!</color>";
    }
}
