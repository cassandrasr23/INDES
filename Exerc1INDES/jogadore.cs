using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc1INDES
{
    class Jogadore
    {
        private string name;
        private int dinheiro;

        public Jogadore(string name, int value)
        {
            this.name = name;
            this.dinheiro = value;
        }

        public int getValue()
        {
            return dinheiro;
        }

        public void addMoney(int valorVictoria)
        {
            dinheiro += valorVictoria;
        }

        override
        public String ToString()
        {
            return name;
        }
    }
}
