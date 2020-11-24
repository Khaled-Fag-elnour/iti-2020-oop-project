using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace online_elections
{
    class VoteInfo
    {
        private readonly int voterId;
        private readonly int candId;
        private readonly DateTime time;

        public VoteInfo(int voterId, int candId)
        {
            time = DateTime.Now;
            this.voterId = voterId;
            this.candId = candId;
        }

        public override string ToString()
        {
            return string.Format("Voter ID = {0}, Candidate ID = {1}, time of vote: {2}", voterId, candId, time);
        }

        public static void StoreInformation(VoteInfo newVote)
        {
            try
            {
                using (StreamWriter sw = File.AppendText("C:/Temp/Votes_Information.txt"))
                {
                    sw.WriteLine("-{0}\n\n", newVote.ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
