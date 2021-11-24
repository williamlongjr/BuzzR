using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzIn
{
    public class Buzzer
    {
        public event EventHandler<BuzzedInEventArgs> BuzzingIn;
        public Team AssignedTeam { get; set; }

        public int? BuzzedInPosition { get; set; }

        public bool IsActive { get; set; }

        public long? BuzzedInDateTime { get; set; }

        public void BuzzIn()
        {
            if (!IsActive) return;
            BuzzedInDateTime = DateTime.Now.Ticks;
            IsActive = false;
            BuzzingIn?.Invoke(this, new BuzzedInEventArgs(BuzzedInDateTime.Value));
        }

        public void ResetToReady()
        {
            IsActive = true;
            BuzzedInDateTime = null;
            BuzzedInPosition = null;
        }
    }

    public class BuzzedInEventArgs : EventArgs
    {
        public long BuzzedInDateTime { get; set; }

        public BuzzedInEventArgs(long buzzedInDateTime)
        {
            BuzzedInDateTime = buzzedInDateTime;
        }
    }
}
