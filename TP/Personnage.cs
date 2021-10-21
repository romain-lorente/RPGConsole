using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public class Personnage
    {
        public int Niveau { get; }
        public int PointsVie { get; }
        public bool Vivant { get; }

        public Personnage()
        {
            Niveau = 1;
            PointsVie = 1000;
            Vivant = true;
        }
    }
}
