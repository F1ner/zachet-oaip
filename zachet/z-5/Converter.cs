using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_5
{
    class Converter
    {
        private double usdRate;
        private double eurRate;
        private double rubRate;

        public Converter(double usd, double eur, double rub)
        {
            usdRate = usd;
            eurRate = eur;
            rubRate = rub;
        }

        public double BYNtoUSD(double byn)
        {
            return byn / usdRate;
        }

        public double BYNtoEUR(double byn)
        {
            return byn / eurRate;
        }

        public double BYNtoRUB(double byn)
        {
            return byn / rubRate;
        }

        public double USDtoBYN(double usd)
        {
            return usd * usdRate;
        }

        public double EURtoBYN(double eur)
        {
            return eur * eurRate;
        }

        public double RUBtoBYN(double rub)
        {
            return rub * rubRate;
        }
    }

}
