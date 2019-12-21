using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerc1INDES
{
    public partial class HorseRice : Form
    {
        
        private const int SPEED_MIN_INIT = 50;
        private const int SPEED_MAX_INIT = 110;
        private const int SPEED_MIN_CURRENT = 40;
        private const int SPEED_MAX_CURRENT = 100;
        private const int SPEED_MIN_FINISH = 60;
        private const int SPEED_MAX_FINISH = 120;
        private const string NUMERO_CORRIDA_INICIO = "A corrida numero ";
        private const string NUMERO_CORRIDA_FIM = " vai comecar daqui um poco.";
        private const string NUMERO_CORRIDA_PENDANTE = " esta em progresso.";
        private const int LOCATION_X_APOSTA_JOGADOR = 10;
        private const int LOCATION_Y_APOSTA_JOGADOR = 20;
        private const int WIDTH_PANEL_APOSTA_JOGADOR = 200;
        private const int HEIGTH_PANEL_APOSTA_JOGADOR = 200;


        private ApostaJogadore[] apostaJogadores;
        private Panel[] adicionarJogadore;
        private bool[] jogadoreExist;
        private const int maxPlayer = 5;

        private LinkedList<Pista> pistas;
        private Random random;
        private int numeroCorrida;
        private int startEndRace;
        private int endRace;
        private int process;
        private bool isEndRace;
        private LinkedList<Pista> cavalosVencedores;

        public HorseRice()
        {
            InitializeComponent();
            random = new Random();
            pistas = new LinkedList<Pista>();
            cavalosVencedores = new LinkedList<Pista>();
            jogadoreExist = new bool[maxPlayer];
            apostaJogadores = new ApostaJogadore[maxPlayer];
            adicionarJogadore = new Panel[maxPlayer];
            for (int i = 0; i < maxPlayer; i++)
            {
                adicionarJogadore[i] = new Panel();
                adicionarJogadore[i].Click += new EventHandler(this.adicionarJ);
                adicionarJogadore[i].BackgroundImage = global::Exerc1INDES.Properties.Resources.add;
                adicionarJogadore[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            numeroCorrida = 0;
            createRace(random.Next(4,10));
        }

        private void createRace(int nbRace)
        {
            if (nbRace <= 0)
                return;

            removeJogadore();
            refresh();

            numeroCorrida++;
            lbl_numeroCorrida.Text = NUMERO_CORRIDA_INICIO + numeroCorrida + NUMERO_CORRIDA_FIM;

            // clear the last information 
            for(int i = 0; i < maxPlayer; i++)
            {
                if (jogadoreExist[i])
                    apostaJogadores[i].clearCavalos();
            }
            pnl_corrida.Controls.Clear();
            pistas.Clear();
            process = 0;
            isEndRace = false;
            cavalosVencedores.Clear();

            int widthPanelRace = pnl_corrida.Height;
            int lengthPanelRace = pnl_corrida.Width;
            int lengthPista = widthPanelRace / nbRace;
            endRace = lengthPanelRace - 80 - 50;
            startEndRace = Convert.ToInt32(lengthPanelRace * 0.8) - 50;

            for (int i = 0; i < nbRace; i++)
            {
                int speedInit = random.Next(SPEED_MIN_INIT, SPEED_MAX_INIT);
                int speedCurrent = random.Next(SPEED_MIN_CURRENT, SPEED_MAX_CURRENT);
                int speedFinish = random.Next(SPEED_MIN_FINISH, SPEED_MAX_FINISH);
                Cavalo cavalo;
                Boolean isSimilarName;
                do
                {
                    cavalo = new Cavalo(speedInit, speedCurrent, speedFinish);
                    isSimilarName = false;

                    for (int j = 0; j < pistas.Count(); j++)
                    {
                        if (cavalo.ToString().Equals(pistas.ElementAt(j).getCavalo().ToString()))
                        {
                            isSimilarName = true;
                            break;
                        }   
                    }
                } while (isSimilarName);
                Pista pista = new Pista(cavalo, lengthPista * i, lengthPanelRace, lengthPista);
                pistas.AddLast(pista);
                if(i % 2 == 0)
                {
                    pista.BackgroundImage = global::Exerc1INDES.Properties.Resources.relvaClara;
                    pista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                else
                {
                    pista.BackgroundImage = global::Exerc1INDES.Properties.Resources.relvaEscura;
                    pista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                }
                pnl_corrida.Controls.Add(pista);
                for(int j = 0; j < maxPlayer; j++)
                {
                    if (jogadoreExist[j])
                        apostaJogadores[j].addCavalo(cavalo.ToString());
                }
            }
        }

        private void inRace()
        {
            bool isFinish = false;
            

            foreach (Pista p in pistas)
            {
                // avancar o cavalo
                switch (process)
                {
                    case int n when (n < 4):
                        p.nextInit();
                        break;
                    default:
                        if (isEndRace)
                            p.nextEnd();
                        else
                            p.next();
                        break;
                }
                // check if acabou e o vencedor
                if (p.getPosicaoCavalo() >= endRace)
                {
                    isFinish = true;
                    cavalosVencedores.AddLast(p);
                }

                // check if endRace
                if (p.getPosicaoCavalo() > startEndRace)
                {
                    isEndRace = true;
                }
            }

            if (isFinish)
            {
                timer.Stop();
                checkWinner();
                createRace(random.Next(4,10));
            }
        }

        // check the winner and show the winner
        private void checkWinner()
        {
            if (cavalosVencedores.Count == 0)
                return;
            if(cavalosVencedores.Count == 1)
            {
                cavalosVencedores.ElementAt(0).setPosicaoFinish();
                DisplayWinner(cavalosVencedores.ElementAt(0).getCavalo());
                return;
            }

            Pista melhor = cavalosVencedores.ElementAt(0);

            for( int i = 1; i < cavalosVencedores.Count(); i++)
            {
                if(melhor.getPosicaoCavalo() < cavalosVencedores.ElementAt(i).getPosicaoCavalo())
                {
                    melhor = cavalosVencedores.ElementAt(i);
                }
                else
                {
                    cavalosVencedores.ElementAt(i).setBeforeFinish();
                }
            }

            melhor.setPosicaoFinish();
            DisplayWinner(melhor.getCavalo());
        }

        private void DisplayWinner(Cavalo c)
        {
            string nomeCavalo = c.ToString();
            string msgVictory = "O cavalo ";
            msgVictory += nomeCavalo;
            msgVictory += " ganhou a corrida\n\n";
            int novoDineiro;
            for (int i = 0; i < maxPlayer; i++)
            {
                if (jogadoreExist[i] && apostaJogadores[i].getCavalo() != "")
                {
                    if (apostaJogadores[i].getCavalo().Equals(nomeCavalo))
                    {
                        novoDineiro = apostaJogadores[i].getValorAposta() * pistas.Count();
                        msgVictory += apostaJogadores[i].getNomeJogadore() + " ganho " + novoDineiro + " €\n";
                        apostaJogadores[i].addMoney(novoDineiro);
                    }
                    else
                    {
                        novoDineiro = apostaJogadores[i].getValorAposta();
                        msgVictory += apostaJogadores[i].getNomeJogadore() + " perdeu " + novoDineiro + " €\n";
                    }
                }
            }

            MessageBox.Show(msgVictory, "Informação da corrida");
        }

        private void Btn_Run_Click(object sender, EventArgs e)
        {
            // perde a aposta
            for (int i = 0; i < maxPlayer; i++)
                if(jogadoreExist[i])
                    apostaJogadores[i].perdeAposta();
            lbl_numeroCorrida.Text = NUMERO_CORRIDA_INICIO + numeroCorrida + NUMERO_CORRIDA_PENDANTE;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            inRace();
            process++;
        }

        private void Btn_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Regras do jogo");
        }

        private void Btn_creditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este trabalho foi realizado por \nAlexandre Marques nº1190200 \nCassandra Ranginha nº1191184 \nDaniel nº ");
        }

        private void adicionarJ(object sender, EventArgs e)
        {
            string name = "toto";

            for(int j = 0; j < maxPlayer; j++)
            {
                if (adicionarJogadore[j].Equals(sender))
                {
                    jogadoreExist[j] = true;
                    apostaJogadores[j] = new ApostaJogadore(name, 200);
                    for(int i = 0; i < pistas.Count(); i++)
                    {
                        apostaJogadores[j].addCavalo(pistas.ElementAt(i).getCavalo().ToString());
                    }
                }
            }

            refresh();
        }

        private void removeJogadore()
        {
            for(int i = 0; i < maxPlayer; i++)
            {
                if(jogadoreExist[i] && apostaJogadores[i].isBankroute())
                {
                    jogadoreExist[i] = false;
                    MessageBox.Show(apostaJogadores[i].getNomeJogadore() + " entrou em bankroute", "Um jogadore saiu do jogo");
                }
            }
        }

        private void refresh()
        {
            gbx_aposta.Controls.Clear();
            gbx_aposta.Controls.Add(this.btn_Run);
            btn_Run.Select();

            for (int i = 0; i < maxPlayer; i++)
            {
                int X = LOCATION_X_APOSTA_JOGADOR + i * WIDTH_PANEL_APOSTA_JOGADOR;

                if (jogadoreExist[i])
                {
                    apostaJogadores[i].Location = new System.Drawing.Point(X, LOCATION_Y_APOSTA_JOGADOR);
                    apostaJogadores[i].Width = WIDTH_PANEL_APOSTA_JOGADOR;
                    apostaJogadores[i].Height = HEIGTH_PANEL_APOSTA_JOGADOR;
                    gbx_aposta.Controls.Add(apostaJogadores[i]);
                }
                else
                {
                    adicionarJogadore[i].Location = new System.Drawing.Point(X, LOCATION_Y_APOSTA_JOGADOR);
                    adicionarJogadore[i].Width = WIDTH_PANEL_APOSTA_JOGADOR;
                    adicionarJogadore[i].Height = HEIGTH_PANEL_APOSTA_JOGADOR;
                    gbx_aposta.Controls.Add(adicionarJogadore[i]);
                }
            }
        }
    }
}
