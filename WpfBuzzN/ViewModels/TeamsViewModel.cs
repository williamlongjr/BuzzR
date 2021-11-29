using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfBuzzN.ViewModels
{
    public class TeamsViewModel
    {
        public ObservableCollection<TeamViewModel> Teams { get; set; } = new ObservableCollection<TeamViewModel>();

        public TeamsViewModel()
        {
            Teams.Add(GetTeam1());
            Teams.Add(GetTeam2());
            Teams.Add(GetTeam3());
            Teams.Add(GetTeam4());
        }

        private TeamViewModel GetTeam1()
        {
            var newTeam = new TeamViewModel { TeamName = "Bears" };
            newTeam.AddPlayer("Jeff");
            newTeam.AddPlayer("Ross");
            return newTeam;
        }

        private TeamViewModel GetTeam2()
        {
            var newTeam = new TeamViewModel { TeamName = "Shizzles" };
            newTeam.AddPlayer("Bill");
            newTeam.AddPlayer("Bubba");
            return newTeam;
        }

        private TeamViewModel GetTeam3()
        {
            var newTeam = new TeamViewModel { TeamName = "Go" };
            newTeam.AddPlayer("Joe");
            newTeam.AddPlayer("Jane");
            return newTeam;
        }

        private TeamViewModel GetTeam4()
        {
            var newTeam = new TeamViewModel { TeamName = "Losers" };
            newTeam.AddPlayer("JimBob");
            return newTeam;
        }


    }
}
