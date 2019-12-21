using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerc1INDES
{
    class Pista : System.Windows.Forms.Panel
    {

        private Cavalo cavalo;
        private Label lbl_nome_cavalo;
        private PictureBox pcb_cavalo;
        private PictureBox pbx_fim;
        private int length;

        public Pista(Cavalo c, int position, int length, int width)
        {
            cavalo = c;
            lbl_nome_cavalo = new Label();
            pbx_fim = new PictureBox();
            pcb_cavalo = new PictureBox();
            this.length = length;

            // 
            // pbx_fim
            // 
            this.pbx_fim.BackgroundImage = global::Exerc1INDES.Properties.Resources.meta;
            this.pbx_fim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx_fim.Location = new System.Drawing.Point(length - 80, 0);
            this.pbx_fim.Name = "pbx_fim";
            this.pbx_fim.Size = new System.Drawing.Size(80, width);
            this.pbx_fim.TabIndex = 0;
            this.pbx_fim.TabStop = false;
            // 
            // pcb_cavalo
            // 
            this.pcb_cavalo.Image = global::Exerc1INDES.Properties.Resources.black;
            this.pcb_cavalo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pcb_cavalo.Location = new System.Drawing.Point(80, 0);
            this.pcb_cavalo.Name = "pcb_cavalo";
            this.pcb_cavalo.Size = new System.Drawing.Size(50, width);
            this.pcb_cavalo.TabIndex = 0;
            this.pcb_cavalo.TabStop = false;
            // 
            // lbl_nome_cavalo
            // 
            this.lbl_nome_cavalo.Location = new System.Drawing.Point(0, 0);
            this.lbl_nome_cavalo.Name = "lbl_nome_cavalo";
            this.lbl_nome_cavalo.Size = new System.Drawing.Size(80, width);
            this.lbl_nome_cavalo.TabIndex = 1;
            this.lbl_nome_cavalo.Text = c.ToString();
            this.lbl_nome_cavalo.Click += new System.EventHandler(this.lbl_nome_cavalo_Click);
            this.lbl_nome_cavalo.MouseHover += new System.EventHandler(this.lbl_nome_cavalo_Mouse);

            this.Location = new System.Drawing.Point(0, position);
            this.Size = new System.Drawing.Size(length, width);
            this.Controls.Add(lbl_nome_cavalo);
            this.Controls.Add(pcb_cavalo);
            this.Controls.Add(pbx_fim);
        }

        public void next()
        {
            int X = pcb_cavalo.Location.X;
            int Y = pcb_cavalo.Location.Y;
            X += length * cavalo.getSpeedCurrent() / 10000;
            pcb_cavalo.Location = new System.Drawing.Point(X,Y);
        }

        public void nextInit()
        {
            int X = pcb_cavalo.Location.X;
            int Y = pcb_cavalo.Location.Y;
            X += length * cavalo.getSpeedInit() / 10000;
            pcb_cavalo.Location = new System.Drawing.Point(X, Y);
        }

        public void nextEnd()
        {
            int X = pcb_cavalo.Location.X;
            int Y = pcb_cavalo.Location.Y;
            X += length * cavalo.getSpeedFinish() / 10000;
            pcb_cavalo.Location = new System.Drawing.Point(X, Y);
        }

        public int getPosicaoCavalo()
        {
            return pcb_cavalo.Location.X;
        }

        public void setPosicaoFinish()
        {
            int X = pbx_fim.Location.X + 10;
            int Y = pcb_cavalo.Location.Y;
            pcb_cavalo.Location = new System.Drawing.Point(X, Y);
        }

        public void setBeforeFinish()
        {
            int X = pbx_fim.Location.X - pcb_cavalo.Size.Width;
            int Y = pcb_cavalo.Location.Y;
            pcb_cavalo.Location = new System.Drawing.Point(X, Y);
        }

        public Cavalo getCavalo()
        {
            return cavalo;
        }

        private void lbl_nome_cavalo_Click(object sender, EventArgs e)
        {
            string infoCavalo = "Nome do Cavalo :\t\t\t" + cavalo.ToString() + "\n";
            infoCavalo += "Velocidade initiale do Cavalo :\t" + cavalo.getSpeedInit() + "\n";
            infoCavalo += "Velocidade corrente do Cavalo :\t" + cavalo.getSpeedCurrent() + "\n";
            infoCavalo += "Valocidade finale do Cavalo :\t" + cavalo.getSpeedFinish() + "\n";

            MessageBox.Show(infoCavalo, "informação do cavalo");
        }

        private void lbl_nome_cavalo_Mouse(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
