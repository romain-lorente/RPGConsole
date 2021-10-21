using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    public class Personnage
    {
        int Niveau;
        int PointsVie;
        int PointsVieMax = 1000;
        bool Vivant;

        public Personnage()
        {
            Niveau = 1;
            PointsVie = PointsVieMax;
            Vivant = true;
        }

        public void SubirDegats(int degats)
        {
            PointsVie -= degats;

            if (PointsVie <= 0)
            {
                Vivant = false;
                PointsVie = 0;
            }
        }

        public void Soigner(int soins)
        {
            if(Vivant)
            {
                PointsVie += soins;

                if(PointsVie > PointsVieMax)
                {
                    PointsVie = PointsVieMax;
                }
            }
        }

        public void Attaquer(Personnage cible)
        {
            cible.SubirDegats(100);
        }

        public void Soigner(Personnage cible)
        {
            cible.Soigner(100);
        }
    }
}
