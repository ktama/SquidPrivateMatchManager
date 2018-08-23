using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Winner1 { get; set; }
        public string Winner2 { get; set; }
        public string Winner3 { get; set; }
        public string Winner4 { get; set; }
        public string Loser1 { get; set; }
        public string Loser2 { get; set; }
        public string Loser3 { get; set; }
        public string Loser4 { get; set; }
    }
}
