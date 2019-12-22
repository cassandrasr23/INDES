using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1INDES
{
    public class Cavalo
    {
        private const int SPEED_CANSADO = 2;
        private const int MIN_VOLTA_CANSADO = 5;
        private const int MAX_VOLTA_CANSADO = 20;

        private int speedInit;
        private int speedCurrent;
        private int speedFinish;
        private int saude;
        private int vitalidade;
        private int vitalidadeMax;
        private int voltaCansado;
        private int recupVitalidade;
        private int voltaComCansasoMax;
        private string nomeCavalo;
        private Random random;

        public Cavalo(string nome, int SInit, int SCurrent, int SFinish, int saude, int vitalidade)
        {
            nomeCavalo = nome;
            speedInit = SInit;
            speedCurrent = SCurrent;
            speedFinish = SFinish;
            this.saude = saude;
            vitalidadeMax = vitalidade;
            this.vitalidade = vitalidadeMax;
            voltaCansado = 0;
            recupVitalidade = 1;
            random = new Random();
            voltaComCansasoMax = random.Next(MIN_VOLTA_CANSADO, MAX_VOLTA_CANSADO);
        }

        public int getSpeedInit()
        {
            return speedInit;
        }

        public int getSpeedCurrent()
        {
            recuperacaoVitalidade();
            return vitalidade <= 0 ? speedCurrent / SPEED_CANSADO : speedCurrent;
        }
        public int getSpeedFinish()
        {
            recuperacaoVitalidade();
            return vitalidade <= 0 ? speedFinish / SPEED_CANSADO : speedFinish;
        }

        private void recuperacaoVitalidade()
        {
            if(vitalidade <= 0)
            {
                voltaCansado++;
                if (voltaCansado == voltaComCansasoMax)
                {
                    vitalidade = vitalidadeMax / recupVitalidade;
                    recupVitalidade *= 2;
                    voltaCansado = 0;
                    voltaComCansasoMax = random.Next(MIN_VOLTA_CANSADO, MAX_VOLTA_CANSADO);
                }
            }
        }

        public int getSaude()
        {
            return saude;
        }

        public int getVitalidadeMax()
        {
            return vitalidadeMax;
        }

        public int getVitalidadeCurrent()
        {
            return vitalidade;
        }

        public void loseVitalidade()
        {
            vitalidade -= speedCurrent / saude;
        }

        override
        public string ToString()
        {
            return nomeCavalo;
        }
    }
}
