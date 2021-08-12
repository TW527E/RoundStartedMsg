using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RoundStartedMsg
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("How long does it last")]
        public ushort HowLong { get; set; } = 5;
        [Description("When Round Started Message")]
        public string OnRoundStarted { get; set; } = "<color=red>Go! Don't AFK!</color>";
    }
}
