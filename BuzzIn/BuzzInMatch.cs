using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzIn
{
    public class BuzzInMatch
    {
        public List<Buzzer> Buzzers { get; set; } = new List<Buzzer>();

        public BuzzInMatch SetupMatch()
        {
            return this;
        }

        public Team AddTeam(Team team)
        {
            var newBuzzer = new Buzzer {AssignedTeam = team};
            newBuzzer.BuzzingIn += NewBuzzer_BuzzingIn;
            Buzzers.Add(newBuzzer);
            return team;
        }

        private void NewBuzzer_BuzzingIn(object sender, BuzzedInEventArgs e)
        {
            Buzzers.FirstOrDefault(_ => _.Equals(sender)).BuzzedInDateTime = e.BuzzedInDateTime;

            var orderedBuzzers = Buzzers.Where(_ => _.BuzzedInDateTime.HasValue).OrderBy(_ => _.BuzzedInDateTime).ToList();
            Buzzers.Where(_ => !_.BuzzedInDateTime.HasValue).ToList().ForEach(_ => _.BuzzedInPosition = null);

            orderedBuzzers.ForEach(m => m.BuzzedInPosition = orderedBuzzers.IndexOf(m)+1);


        }

        public void Start()
        {
            //Reset all buzzers
            Buzzers.ForEach(_ => _.ResetToReady());
        }

    }
}
