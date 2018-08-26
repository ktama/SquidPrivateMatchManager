using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SquidPrivateMatchManager
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            // テスト用データ
            viewModel.Entrants.Add(new Entrant() { Name = "アオリ", Wins = 1 });
            viewModel.Entrants.Add(new Entrant() { Name = "ホタル", Wins = 2 });
            viewModel.Entrants.Add(new Entrant() { Name = "アタリメ", Wins = 3 });
            viewModel.Entrants.Add(new Entrant() { Name = "３号", Wins = 4 });
            viewModel.Entrants.Add(new Entrant() { Name = "ヒメ", Wins = 5 });
            viewModel.Entrants.Add(new Entrant() { Name = "イイダ", Wins = 6 });
            viewModel.Entrants.Add(new Entrant() { Name = "４号", Wins = 7 });
            viewModel.Entrants.Add(new Entrant() { Name = "８号", Wins = 8 });

            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 09, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winners = new Team("アオリ","ホタル","アタリメ","３号"),
                Losers = new Team("ヒメ", "イイダ", "４号", "８号")
            });
            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 10, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
                Losers = new Team("アタリメ", "３号", "４号", "８号")
            });
            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 11, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
                Losers = new Team("アタリメ", "３号", "４号", "８号")
            });
            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 12, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
                Losers = new Team("アタリメ", "３号", "４号", "８号")
            });
            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 13, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
                Losers = new Team("アタリメ", "３号", "４号", "８号")
            });
            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 14, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
                Losers = new Team("アタリメ", "３号", "４号", "８号")
            });
            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 15, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
                Losers = new Team("アタリメ", "３号", "４号", "８号")
            });
            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 16, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winners = new Team("アオリ", "ホタル", "ヒメ", "イイダ"),
                Losers = new Team("アタリメ", "３号", "４号", "８号")
            });

            this.Entrants.ItemsSource = viewModel.Entrants;
            this.BattleHistories.ItemsSource = viewModel.BattleHistories;
            this.RuleBox.ItemsSource = viewModel.Rules;
            this.StageBox.ItemsSource = viewModel.Stages;
            UpdateEntrants();
        }

        private Team GetAlphaTeam()
        {
            return new Team(Alpha1.Text, Alpha2.Text, Alpha3.Text, Alpha4.Text);
        }

        private Team GetBravoTeam()
        {
            return new Team(Bravo1.Text, Bravo2.Text, Bravo3.Text, Bravo4.Text);
        }

        private void UpdateEntrants()
        {
            this.Alpha1.ItemsSource = viewModel.Members;
            this.Alpha2.ItemsSource = viewModel.Members;
            this.Alpha3.ItemsSource = viewModel.Members;
            this.Alpha4.ItemsSource = viewModel.Members;
            this.Bravo1.ItemsSource = viewModel.Members;
            this.Bravo2.ItemsSource = viewModel.Members;
            this.Bravo3.ItemsSource = viewModel.Members;
            this.Bravo4.ItemsSource = viewModel.Members;
        }

        private void Entrants_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "Name":
                    e.Column.Header = "名前";
                    e.Column.Width = 150;
                    break;
                case "Wins":
                    e.Column.Header = "勝利数";
                    break;
                case "IsBattleMember":
                    e.Column.Visibility = Visibility.Collapsed;
                    break;
                default:
                    break;
            }
        }

        private void ResultHistory_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Date":
                    e.Column.Visibility = Visibility.Collapsed;
                    break;
                case "DateString":
                    e.Column.Header = "日時";
                    break;
                case "Winners":
                    e.Column.Visibility = Visibility.Collapsed;
                    break;
                case "Losers":
                    e.Column.Visibility = Visibility.Collapsed;
                    break;
                case "WinnersNames":
                    e.Column.Header = "勝利チーム";
                    break;
                case "LosersNames":
                    e.Column.Header = "敗北チーム";
                    break;
                default:
                    break;
            }
        }

        private void Registry_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel.RegistEntrants(this.EntryNameTextBox.Text);
            UpdateEntrants();
        }

        private void AlphaWinButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel.RegistoryBattleHistory(this.RuleBox.Text, this.StageBox.Text, this.GetAlphaTeam(), this.GetBravoTeam());
        }

        private void BravoWinButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel.RegistoryBattleHistory(this.RuleBox.Text, this.StageBox.Text, this.GetBravoTeam(), this.GetAlphaTeam());
        }

    }
}
