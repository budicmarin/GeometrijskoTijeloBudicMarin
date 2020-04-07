using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskoTijeloBudicMarin
{
    class GeometrijskoTijelo
    {
        double volumen;
        double oplosje;
        static int BrojacTijela = 0;
        public GeometrijskoTijelo(double volumen, double oplošje)
        {
            this.oplosje = oplosje;
            this.volumen = volumen;
            BrojacTijela++;
        }
        public GeometrijskoTijelo()
        {
            BrojacTijela++;
        }

        public double Volumen { get => volumen; set => volumen = value; }
        public double Oplosje { get => oplosje; set => oplosje = value; }
        public override string ToString()
        {
            string rec = "" + BrojacTijela;
            return rec;
        }
    }
}
