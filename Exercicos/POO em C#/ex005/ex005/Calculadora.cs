﻿using System;

namespace ex005 {
    class Calculadora
    {
        static double Pi = 3.14;
        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }

    }
}
