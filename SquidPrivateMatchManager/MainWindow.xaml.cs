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
            viewModel.Entrants.Add(new Entrant() { Name = "A", Wins = 1 });
            viewModel.Entrants.Add(new Entrant() { Name = "B", Wins = 2 });
            viewModel.Entrants.Add(new Entrant() { Name = "C", Wins = 3 });
            viewModel.Entrants.Add(new Entrant() { Name = "D", Wins = 4 });
            viewModel.Entrants.Add(new Entrant() { Name = "E", Wins = 5 });
            viewModel.Entrants.Add(new Entrant() { Name = "F", Wins = 6 });
            viewModel.Entrants.Add(new Entrant() { Name = "G", Wins = 7 });
            viewModel.Entrants.Add(new Entrant() { Name = "H", Wins = 8 });

            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 09, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winner1 = "A",
                Winner2 = "B",
                Winner3 = "C",
                Winner4 = "D",
                Loser1 = "E",
                Loser2 = "F",
                Loser3 = "G",
                Loser4 = "H"
            });
            viewModel.BattleHistories.Add(new BattleHistory()
            {
                Date = new DateTime(2018, 1, 1, 10, 00, 00),
                Rule = "ガチヤグラ",
                Stage = "ホッケふ頭",
                Winner1 = "A",
                Winner2 = "B",
                Winner3 = "E",
                Winner4 = "F",
                Loser1 = "C",
                Loser2 = "D",
                Loser3 = "G",
                Loser4 = "H"
            });

            this.Entrants.ItemsSource = viewModel.Entrants;
            this.BattleHistories.ItemsSource = viewModel.BattleHistories;
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
                default:
                    break;
            }
        }
    }
}
