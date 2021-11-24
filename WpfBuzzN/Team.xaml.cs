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
using WpfBuzzN.ViewModels;

namespace WpfBuzzN
{
    /// <summary>
    /// Interaction logic for Team.xaml
    /// </summary>
    public partial class Team : UserControl
    {
        public Team()
        {
            var teamViewModel = new TeamViewModel();
            teamViewModel.TeamName = "Team Z";
            teamViewModel.PlayerName = "Player 1";

            DataContext = teamViewModel;

            InitializeComponent();
        }

        private void TeamNameTextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TeamNameTextBox.IsEnabled = !TeamNameTextBox.IsEnabled;
        }
    }
}
