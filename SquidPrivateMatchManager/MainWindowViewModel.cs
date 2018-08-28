using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace SquidPrivateMatchManager
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Entrant> entrants = new ObservableCollection<Entrant>();
        private ObservableCollection<BattleHistory> battleHistories = new ObservableCollection<BattleHistory>();

        public ObservableCollection<Entrant> Entrants
        {
            get
            {
                return entrants;
            }
            set
            {
                entrants = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Entrants)));
            }
        }
        public ObservableCollection<BattleHistory> BattleHistories
        {
            get
            {
                return battleHistories;
            }
            set
            {
                battleHistories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BattleHistories)));
            }
        }

        public ObservableCollection<string> Rules { get; } = new ObservableCollection<string>()
        {
            "ナワバリ",
            "ガチエリア",
            "ガチヤグラ",
            "ガチホコ",
            "ガチアサリ",
        };

        public ObservableCollection<string> Stages { get; } = new ObservableCollection<string>()
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

        public MainWindowViewModel()
        {
            #region テストデータ
            //Entrants.Add(new Entrant() { Name = "アオリ", Wins = 1 });
            //Entrants.Add(new Entrant() { Name = "ホタル", Wins = 2 });
            //Entrants.Add(new Entrant() { Name = "アタリメ", Wins = 3 });
            //Entrants.Add(new Entrant() { Name = "３号", Wins = 4 });
            //Entrants.Add(new Entrant() { Name = "ヒメ", Wins = 5 });
            //Entrants.Add(new Entrant() { Name = "イイダ", Wins = 6 });
            //Entrants.Add(new Entrant() { Name = "４号", Wins = 7 });
            //Entrants.Add(new Entrant() { Name = "８号", Wins = 8 });

            //BattleHistories.Add(new BattleHistory()
            //{
            //    Date = new DateTime(2018, 1, 1, 09, 00, 00),
            //    Rule = "ガチヤグラ",
            //    Stage = "ホッケふ頭",
            //    Winners = new Team("アオリ", "ホタル", "アタリメ", "３号"),
            //    Losers = new Team("ヒメ", "イイダ", "４号", "８号")
            //});
            //BattleHistories.Add(new BattleHistory()
            //{
            //    Date = new DateTime(2018, 1, 1, 10, 00, 00),
            //    Rule = "ガチヤグラ",
            //    Stage = "ホッケふ頭",
            //    Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
            //    Losers = new Team("アタリメ", "３号", "４号", "８号")
            //});
            //BattleHistories.Add(new BattleHistory()
            //{
            //    Date = new DateTime(2018, 1, 1, 11, 00, 00),
            //    Rule = "ガチヤグラ",
            //    Stage = "ホッケふ頭",
            //    Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
            //    Losers = new Team("アタリメ", "３号", "４号", "８号")
            //});
            //BattleHistories.Add(new BattleHistory()
            //{
            //    Date = new DateTime(2018, 1, 1, 12, 00, 00),
            //    Rule = "ガチヤグラ",
            //    Stage = "ホッケふ頭",
            //    Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
            //    Losers = new Team("アタリメ", "３号", "４号", "８号")
            //});
            //BattleHistories.Add(new BattleHistory()
            //{
            //    Date = new DateTime(2018, 1, 1, 13, 00, 00),
            //    Rule = "ガチヤグラ",
            //    Stage = "ホッケふ頭",
            //    Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
            //    Losers = new Team("アタリメ", "３号", "４号", "８号")
            //});
            //BattleHistories.Add(new BattleHistory()
            //{
            //    Date = new DateTime(2018, 1, 1, 14, 00, 00),
            //    Rule = "ガチヤグラ",
            //    Stage = "ホッケふ頭",
            //    Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
            //    Losers = new Team("アタリメ", "３号", "４号", "８号")
            //});
            //BattleHistories.Add(new BattleHistory()
            //{
            //    Date = new DateTime(2018, 1, 1, 15, 00, 00),
            //    Rule = "ガチヤグラ",
            //    Stage = "ホッケふ頭",
            //    Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
            //    Losers = new Team("アタリメ", "３号", "４号", "８号")
            //});
            //BattleHistories.Add(new BattleHistory()
            //{
            //    Date = new DateTime(2018, 1, 1, 16, 00, 00),
            //    Rule = "ガチヤグラ",
            //    Stage = "ホッケふ頭",
            //    Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
            //    Losers = new Team("アタリメ", "３号", "４号", "８号")
            //});
            #endregion

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RegistEntrants(string name)
        {
            Entrants.Add(new Entrant() { Name = name, Wins = 0 });
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Members)));
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
