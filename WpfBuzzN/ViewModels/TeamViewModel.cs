using BuzzIn;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBuzzN.ViewModels
{
    public class TeamViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string TeamName { get; set; } = "Team X";

        public ObservableCollection<Player> Players { get; set; } = new ObservableCollection<Player>();

        public void AddPlayer(string playerName)
        {
            Players?.Add(new Player(playerName));
        }

        public void ClearPlayers()
        {
            Players?.Clear();
        }

        public void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
