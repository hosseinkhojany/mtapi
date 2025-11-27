using System;

namespace MtApi5
{
    public class Mt5TimeBarArgs : EventArgs
    {
        internal Mt5TimeBarArgs(int expertHandle, string symbol, MqlRates rates, int periodInMinutes)
        {
            this.ExpertHandle = expertHandle;
            this.Rates = rates;
            this.Symbol = symbol;
            this.PeriodInMinutes = periodInMinutes;
        }

        public int ExpertHandle { get; }

        public int PeriodInMinutes { get; }

        public string Symbol { get; }

        public MqlRates Rates { get; }
    }
}
