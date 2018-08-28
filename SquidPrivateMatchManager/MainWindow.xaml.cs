using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            this.DataContext = this.viewModel;
        }

        private Team GetAlphaTeam()
        {
            return new Team(Alpha1ComboBox.Text, Alpha2ComboBox.Text, Alpha3ComboBox.Text, Alpha4ComboBox.Text);
        }

        private Team GetBravoTeam()
        {
            return new Team(Bravo1ComboBox.Text, Bravo2ComboBox.Text, Bravo3ComboBox.Text, Bravo4ComboBox.Text);
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
        }

        private void AlphaWinButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel.RegistoryBattleHistory(this.RuleComboBox.Text, this.StageComboBox.Text, this.GetAlphaTeam(), this.GetBravoTeam());
        }

        private void BravoWinButton_Click(object sender, RoutedEventArgs e)
        {
            this.viewModel.RegistoryBattleHistory(this.RuleComboBox.Text, this.StageComboBox.Text, this.GetBravoTeam(), this.GetAlphaTeam());
        }

        private void EntryNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                this.viewModel.RegistEntrants(this.EntryNameTextBox.Text);
            }
        }
    }
}
