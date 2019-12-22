using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerc1INDES
{
    class ApostaJogadore : Panel
    {
        private const string VALOR_TOTAL = "O vosso valor montante é de ";

        private NumericUpDown nub_valor_aposta;
        private Label lbl_nome_jogadore;
        private Label lblValor;
        private Label lbl_dineiro;
        private Label lbl_euro;
        private Label lblCavalo;
        private ComboBox cbx_cavalo;

        private Jogadore jogadore;

        public ApostaJogadore(string name, int beginMoney)
        {
            jogadore = new Jogadore(name, beginMoney);

            nub_valor_aposta = new NumericUpDown();
            lbl_nome_jogadore = new Label();
            lblValor = new Label();
            lbl_dineiro = new Label();
            lbl_euro = new Label();
            lblCavalo = new Label();
            cbx_cavalo = new ComboBox();

            // 
            // lbl_nome_jogadore
            // 
            this.lbl_nome_jogadore.AutoSize = true;
            this.lbl_nome_jogadore.Location = new System.Drawing.Point(18, 7);
            this.lbl_nome_jogadore.Name = "lbl_nome_jogadore";
            this.lbl_nome_jogadore.Size = new System.Drawing.Size(40, 13);
            this.lbl_nome_jogadore.Text = name;
            // 
            // nub_valor_aposta
            // 
            this.nub_valor_aposta.Location = new System.Drawing.Point(64, 35);
            this.nub_valor_aposta.Name = "nub_valor_aposta";
            this.nub_valor_aposta.Size = new System.Drawing.Size(100, 20);
            this.nub_valor_aposta.TabIndex = 7;
            // 
            // lblCavalo
            // 
            this.lblCavalo.AutoSize = true;
            this.lblCavalo.Location = new System.Drawing.Point(18, 75);
            this.lblCavalo.Name = "lblCavalo";
            this.lblCavalo.Size = new System.Drawing.Size(40, 13);
            this.lblCavalo.TabIndex = 6;
            this.lblCavalo.Text = "Cavalo";
            // 
            // cbx_cavalo
            // 
            this.cbx_cavalo.FormattingEnabled = true;
            this.cbx_cavalo.Location = new System.Drawing.Point(65, 72);
            this.cbx_cavalo.Name = "cbx_cavalo";
            this.cbx_cavalo.Size = new System.Drawing.Size(121, 21);
            this.cbx_cavalo.TabIndex = 5;
            // 
            // lbl_dineiro
            // 
            this.lbl_dineiro.AutoSize = true;
            this.lbl_dineiro.Location = new System.Drawing.Point(24, 163);
            this.lbl_dineiro.Name = "lbl_dineiro";
            this.lbl_dineiro.Size = new System.Drawing.Size(58, 13);
            this.lbl_dineiro.TabIndex = 4;
            this.lbl_dineiro.Text = "Valor Total";
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Location = new System.Drawing.Point(171, 37);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(13, 13);
            this.lbl_euro.TabIndex = 3;
            this.lbl_euro.Text = "€";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.SystemColors.Control;
            this.lblValor.Location = new System.Drawing.Point(24, 37);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor ";

            this.Controls.Add(this.nub_valor_aposta);
            this.Controls.Add(this.lbl_nome_jogadore);
            this.Controls.Add(this.lblCavalo);
            this.Controls.Add(this.cbx_cavalo);
            this.Controls.Add(this.lbl_dineiro);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.lblValor);

            refresh();
        }

        public int getValorAposta()
        {
            return Convert.ToInt32(nub_valor_aposta.Value);
        }

        public void addMoney(int value)
        {
            jogadore.addMoney(value);
            refresh();
        }

        private void refresh()
        {
            lbl_dineiro.Text = VALOR_TOTAL + jogadore.getValue();
            if (jogadore.getValue() < nub_valor_aposta.Value)
                nub_valor_aposta.Value = 0;
            nub_valor_aposta.Maximum = jogadore.getValue();
        }

        public void addCavalo(String nomeCavalo)
        {
            cbx_cavalo.Items.Add(nomeCavalo);
        }

        public void clearCavalos()
        {
            cbx_cavalo.Items.Clear();
            cbx_cavalo.Text = "";
        }

        public String getCavalo()
        {
            return cbx_cavalo.Text;
        }

        public String getNomeJogadore()
        {
            return jogadore.ToString();
        }

        public void perdeAposta()
        {
            if(cbx_cavalo.Text != "")
                jogadore.addMoney(getValorAposta() * -1);
            lbl_dineiro.Text = VALOR_TOTAL + jogadore.getValue();
        }

        public bool isBankroute()
        {
            return jogadore.getValue() <= 0 ? true : false;
        }
    }
}
