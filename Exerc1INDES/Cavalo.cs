using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1INDES
{
    class Cavalo
    {
        private int speedInit;
        private int speedCurrent;
        private int speedFinish;
        private string nomeCavalo;
        private static Random random;

        public Cavalo(int SInit, int SCurrent, int SFinish)
        {
            speedInit = SInit;
            speedCurrent = SCurrent;
            speedFinish = SFinish;

            random = new Random();

            createName();
        }

        public int getSpeedInit()
        {
            return speedInit;
        }

        public int getSpeedCurrent()
        {
            return speedCurrent;
        }
        public int getSpeedFinish()
        {
            return speedFinish;
        }

        override
        public string ToString()
        {
            return nomeCavalo;
        }

        private void createName()
        {
            //lettre autorisé pour la génération d'un nom aléatoire
            String letraMaiuscula = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String consoante = "bcdfghjklmnpqrstvwxz";
            String vogais = "aeiouy";

            int numeroLetra = random.Next(1, 10);

            // la première lettre doit toujours être une majuscule
            int j =  random.Next(0,letraMaiuscula.Length - 1);
            nomeCavalo += letraMaiuscula.ElementAt(j);

            // completer le nom en alternant voyelle et consonne
            for (int i = 0; i < numeroLetra; i = i + 2)
            {
                j = random.Next(0, vogais.Length - 1);
                nomeCavalo += vogais.ElementAt(j);

                if (i + 1 < numeroLetra)
                {
                    j = random.Next(0, consoante.Length - 1);
                    nomeCavalo += consoante.ElementAt(j);
                }
            }
        }
    }
}
