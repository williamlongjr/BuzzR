using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuzzIn;
using Microsoft.VisualBasic;

namespace SampleBuzzIn
{
    public partial class Form1 : Form
    {
        private BuzzInMatch _buzzInMatch;

        public Form1()
        {
            InitializeComponent();
            _buzzInMatch = new BuzzInMatch();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //var match = new BuzzIn.BuzzInMatch().AddTeam(new Team().AddPlayer(new Player()));
            _buzzInMatch.Start();
            btnTeam1.Enabled = true;
            btnTeam2.Enabled = true;
            btnTeam3.Enabled = true;
            btnTeam4.Enabled = true;
            ClearDebug();ShowDebug();
            lblPlace1.Visible = false;
            lblPlace2.Visible = false;
            lblPlace3.Visible = false;
            lblPlace4.Visible = false;
        }

        #region Add Team

        private void AddTeam_Click(object sender, EventArgs e)
        {
            var teamName = Interaction.InputBox("Enter Team Name", "Team Name", "Team 1");
            _buzzInMatch.AddTeam(new Team { TeamName = teamName });
            btnTeam1.Visible = true;
            btnAddPlayer1.Visible = true;
            btnTeam1.Text = teamName;

        }

        private void btnAddTeam2_Click(object sender, EventArgs e)
        {
            var teamName = Interaction.InputBox("Enter Team Name", "Team Name", "Team 2");
            _buzzInMatch.AddTeam(new Team { TeamName = teamName });
            btnTeam2.Text = teamName;
        }

        private void btnAddTeam3_Click(object sender, EventArgs e)
        {
            var teamName = Interaction.InputBox("Enter Team Name", "Team Name", "Team 3");
            _buzzInMatch.AddTeam(new Team { TeamName = teamName });
            btnTeam3.Text = teamName;
        }

        private void btnAddTeam4_Click(object sender, EventArgs e)
        {
            var teamName = Interaction.InputBox("Enter Team Name", "Team Name", "Team 4");
            _buzzInMatch.AddTeam(new Team { TeamName = teamName });
            btnTeam4.Text = teamName;
        }

        #endregion

        private void btnTeam1_Click(object sender, EventArgs e)
        {
            _buzzInMatch.Buzzers[0].BuzzIn();
            ClearDebug();ShowDebug();
            btnTeam1.Enabled = false;
        }

        private void btnTeam2_Click(object sender, EventArgs e)
        {
            _buzzInMatch.Buzzers[1].BuzzIn();
            ClearDebug(); ShowDebug();
            btnTeam2.Enabled = false;
        }

        private void btnTeam3_Click(object sender, EventArgs e)
        {
            _buzzInMatch.Buzzers[2].BuzzIn();
            ClearDebug(); ShowDebug();
            btnTeam3.Enabled = false;
        }

        private void btnTeam4_Click(object sender, EventArgs e)
        {
            _buzzInMatch.Buzzers[3].BuzzIn();
            ClearDebug(); ShowDebug();
            btnTeam4.Enabled = false;
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            ShowDebug();
        }

        private void ShowDebug()
        {
            _buzzInMatch.Buzzers.ForEach(_ =>
            {
                lstDebug.Items.Add($"{_.AssignedTeam.ToString()}");
                //lstDebug.Items.Add(_.BuzzedInDateTime.HasValue ? _.BuzzedInDateTime.Value : "");
                lstDebug.Items.Add(_.BuzzedInPosition.HasValue ? _.BuzzedInPosition.Value : "");
            });


            lblPlace1.ForeColor = Color.Black;
            lblPlace2.ForeColor = Color.Black;
            lblPlace3.ForeColor = Color.Black;
            lblPlace4.ForeColor = Color.Black;

            if (_buzzInMatch.Buzzers[0].BuzzedInPosition.HasValue)
            {
                lblPlace1.Visible = true;
                lblPlace1.Text = _buzzInMatch.Buzzers[0].BuzzedInPosition.Value.ToString();
                if (lblPlace1.Text == "1") lblPlace1.ForeColor = Color.Red;
            }

            if (_buzzInMatch.Buzzers[1].BuzzedInPosition.HasValue)
            {
                lblPlace2.Visible = true;
                lblPlace2.Text = _buzzInMatch.Buzzers[1].BuzzedInPosition.Value.ToString();
                if (lblPlace2.Text == "1") lblPlace2.ForeColor = Color.Red;
            }

            if (_buzzInMatch.Buzzers[2].BuzzedInPosition.HasValue)
            {
                lblPlace3.Visible = true;
                lblPlace3.Text = _buzzInMatch.Buzzers[2].BuzzedInPosition.Value.ToString();
                if (lblPlace3.Text == "1") lblPlace3.ForeColor = Color.Red;
            }

            if (_buzzInMatch.Buzzers[3].BuzzedInPosition.HasValue)
            {
                lblPlace4.Visible = true;
                lblPlace4.Text = _buzzInMatch.Buzzers[3].BuzzedInPosition.Value.ToString();
                if (lblPlace4.Text == "1") lblPlace4.ForeColor = Color.Red;
            }


        }

        private void btnClearDebug_Click(object sender, EventArgs e)
        {
            ClearDebug();
        }

        private void ClearDebug()
        {
            lstDebug.Items.Clear();
        }

        private void btnAddPlayer1_Click(object sender, EventArgs e)
        {
            var playerName = Interaction.InputBox("Enter Player Name", "Player Name", "Player");
            _buzzInMatch.Buzzers[0].AssignedTeam.AddPlayer(new Player {Name = playerName});
            lblPlayers1.Text = _buzzInMatch.Buzzers[0].AssignedTeam.ToString();
        }

        private void btnAddPlayer2_Click(object sender, EventArgs e)
        {
            var playerName = Interaction.InputBox("Enter Player Name", "Player Name", "Player");
            _buzzInMatch.Buzzers[1].AssignedTeam.AddPlayer(new Player { Name = playerName });
            lblPlayers2.Text = _buzzInMatch.Buzzers[1].AssignedTeam.ToString();
        }

        private void btnAddPlayer3_Click(object sender, EventArgs e)
        {
            var playerName = Interaction.InputBox("Enter Player Name", "Player Name", "Player");
            _buzzInMatch.Buzzers[2].AssignedTeam.AddPlayer(new Player { Name = playerName });
            lblPlayers3.Text = _buzzInMatch.Buzzers[2].AssignedTeam.ToString();
        }

        private void btnAddPlayer4_Click(object sender, EventArgs e)
        {
            var playerName = Interaction.InputBox("Enter Player Name", "Player Name", "Player");
            _buzzInMatch.Buzzers[3].AssignedTeam.AddPlayer(new Player { Name = playerName });
            lblPlayers4.Text = _buzzInMatch.Buzzers[3].AssignedTeam.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPlayers1.Text = string.Empty;
            lblPlayers2.Text = string.Empty;
            lblPlayers3.Text = string.Empty;
            lblPlayers4.Text = string.Empty;
        }
    }
}
