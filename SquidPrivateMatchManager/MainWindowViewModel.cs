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
        public ObservableCollection<Entrant> Entrants { get; set; } = new ObservableCollection<Entrant>();
        public ObservableCollection<BattleHistory> BattleHistories { get; set; } = new ObservableCollection<BattleHistory>();

        public ObservableCollection<string> Rules { get; set; } = new ObservableCollection<string>()
        {
            "ナワバリ",
            "ガチエリア",
            "ガチヤグラ",
            "ガチホコ",
            "ガチアサリ",
        };

        public ObservableCollection<string> Stages { get; set; } = new ObservableCollection<string>()
        {
            "バッテラストリート",
            "フジツボスポーツクラブ",
            "ガンガゼ野外音楽堂",
            "コンブトラック",
            "海女美術大学",
            "チョウザメ造船",
            "タチウオパーキング",
            "ホッケふ頭",
            "マンタマリア号",
            "モズク農園",
            "エンガワ河川敷",
            "Bバスパーク",
            "ザトウマーケット",
            "ハコフグ倉庫",
            "デボン海洋博物館",
            "アジフライスタジアム",
            "ショッツル鉱山",
            "モンガラキャンプ場",
            "スメーシーワールド",
            "ホテルニューオートロ",
            "アンチョビットゲームズ",
            "ミステリーゾーン"
        };

        public ObservableCollection<string> Members
        {
            get
            {
                var tmp = Entrants.Where(entrant => entrant.IsBattleMember == false).ToList();
                return new ObservableCollection<string>(tmp.Select(entrant => entrant.Name));
            }
        }

        public Team AlphaTeam { get; set; }
        public Team BravoTeam { get; set; }

        public void RegistEntrants(string name)
        {
            Entrants.Add(new Entrant() { Name = name, Wins = 0 });
        }

        public void RegistoryBattleHistory(string rule, string stage, Team winTeam, Team loseTeam)
        {
            var date = DateTime.Now;
            BattleHistories.Insert(0, new BattleHistory(date, rule, stage, winTeam, loseTeam));

            foreach(var entrant in Entrants)
            {
                if(winTeam.MembersNames.Contains(entrant.Name))
                {
                    entrant.Wins++;
                }

            }
        }
    }
}
