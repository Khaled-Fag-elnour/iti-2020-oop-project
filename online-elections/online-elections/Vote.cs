using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_elections
{
    class Vote
    {
        private readonly int voterId;
        private readonly int candId;
        private readonly DateTime time;

        public Vote(int voterId, int candId)
        {
            time = DateTime.Now;
            this.voterId = voterId;
            this.candId = candId;
        }
    }
}
