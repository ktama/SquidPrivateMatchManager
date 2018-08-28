using System;

namespace SquidPrivateMatchManager
{
    public class BattleHistory
    {
        public DateTime Date { get; set; }
        public String DateString
        {
            get
            {
                return this.Date.ToString("MM/dd HH:mm");
            }
        }
        public string Rule { get; set; }
        public string Stage { get; set; }
        public Team Winners { get; set; }
        public Team Losers { get; set; }
        public string WinnersNames { get { return Winners.MembersNames; } }
        public string LosersNames { get { return Losers.MembersNames; } }

        public BattleHistory() { }

        public BattleHistory(DateTime date, string rule, string stage, Team winners, Team losers)
        {
            this.Date = date;
            this.Rule = rule;
            this.Stage = stage;
            this.Winners = winners;
            this.Losers = losers;
        }
    }
}
