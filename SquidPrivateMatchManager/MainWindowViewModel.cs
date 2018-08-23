using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquidPrivateMatchManager
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Entrant> Entrants = new ObservableCollection<Entrant>();
        public ObservableCollection<BattleHistory> BattleHistories = new ObservableCollection<BattleHistory>();

    }
}
