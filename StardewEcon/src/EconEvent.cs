﻿namespace StardewEcon
{
    class EconEvent : IEconEvent
    {
        public EconEvent(string headline, int item, int percent, int oldPrice)
        {
            this.Headline = headline;

            this.AffectedItem = item;
            this.PercentChange = percent;
            this.OldPrice = oldPrice;
        }

        public string Headline { get; }

        public int PercentChange { get; }

        public int AffectedItem { get; }

        public int OldPrice { get; }

        public int NewPrice {
            get
            {
                return OldPrice + (OldPrice * PercentChange) / 100;
            }
        }
    }
}
