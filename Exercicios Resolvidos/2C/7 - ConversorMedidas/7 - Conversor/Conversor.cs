using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Conversor
{
    public static class Conversor
    {
        public static double KgG(double x)
        {
            return x * 1000;
        }
        public static double GKg(double x)
        {
            return x / 1000;
        }
        public static double KgT(double x)
        {
            return x / 1000;
        }
        public static double KgLb(double x)
        {
            return x * 2.2046;
        }
        public static double LbKg(double x)
        {
            return x / 2.2046;
        }

        public static double CK(double x)
        {
            return x + 273;
        }

        public static double CF(double x)
        {
            return (x * 9 / 5) + 32;
        }

        public static double FC(double x)
        {
            return (x - 32) / 1.8;
        }
        public static double FK(double x)
        {
            return (x - 32) / 1.8 + 273;
        }
        public static double KC(double x)
        {
            return x - 273;
        }
        public static double KF(double x)
        {
            return (x - 273.15) * 1.8000 + 32.00;
        }
        public static double MetroKm(double x)
        {
            return x / 1000;
        }
        public static double KmMetro(double x)
        {
            return x * 1000;
        }
        public static double MetroPes(double x)
        {
            return x * 3.2808;
        }
        public static double PesMetro(double x)
        {
            return x / 3.2808;
        }
        public static double KmMilha(double x)
        {
            return x / 0.62137;
        }
        public static double MilhaKm(double x)
        {
            return x * 0.62137;
        }
        public static double PesPolegada(double x)
        {
            return x * 12;
        }
        public static double PolegadaPes(double x)
        {
            return x / 12;
        }
        public static double MetroPolegada(double x)
        {
            return x * 39.370;
        }
        public static double PolegadaMetro(double x)
        {
            return x / 39.370;
        }

    }
}