﻿using System;

namespace TP
{
    class Program
    {
        static void Main(string[] args)
        {
            Personnage p1 = new Personnage();
            Personnage p2 = new Personnage();

            p1.Attaquer(p2, 250);
            p2.Soigner(p2, 500);

            p2.Attaquer(p1, 1250);
            p1.Soigner(p1, 100);

            Console.ReadLine();
        }
    }
}
