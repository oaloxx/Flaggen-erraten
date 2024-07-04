using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mohdKhair
{
    public class UserAndResults
    {
        private int NR;
        private string user;
        private int Results;

        public int NR1 { get => NR; set => NR = value; }
        public string User { get => user; set => user = value; }
        public int Results1 { get => Results; set => Results = value; }

        public UserAndResults(int nR1, string user, int results1)
        {
            NR1 = nR1;
            User = user;
            Results1 = results1;
        }
    }
}
