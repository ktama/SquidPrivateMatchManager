using System.ComponentModel;

namespace SquidPrivateMatchManager
{
    public class Entrant : INotifyPropertyChanged
    {
        private string name;
        private uint wins;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public uint Wins
        {
            get
            {
                return wins;
            }
            set
            {
                wins = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Wins)));
            }
        }

        public bool IsBattleMember { get; set; } = false;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
