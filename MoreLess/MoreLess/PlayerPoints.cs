using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLess
{
    class PlayerPoints
    {
        public int PointsSum;
        public string PlayerId;
        public PlayerPoints(int _HowMuch) {
            PointsSum += _HowMuch;
        }
        public PlayerPoints(string _PlayerId)
        {
            PlayerId = _PlayerId;
        }
    }
}
