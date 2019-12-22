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
    public partial class InformacaoCavalo : Form
    {
        public InformacaoCavalo()
        {
            InitializeComponent();
            // size windows
            int count = HorseRice.getPista().Count();
            this.ClientSize = new System.Drawing.Size(674, count * 30);
            this.list_informacao_cavalo.Size = new System.Drawing.Size(674, count * 24);
            this.btn_Close.Location = new System.Drawing.Point(306, count * 25);
            // fill list
            foreach (Pista p in HorseRice.getPista())
            {
                Cavalo cavalo = p.getCavalo();
                ListViewItem lvi = new ListViewItem(cavalo.ToString());
                lvi.SubItems.Add(cavalo.getSpeedInit().ToString());
                lvi.SubItems.Add(cavalo.getSpeedCurrent().ToString());
                lvi.SubItems.Add(cavalo.getSpeedFinish().ToString());
                lvi.SubItems.Add(cavalo.getSaude().ToString());
                lvi.SubItems.Add(cavalo.getVitalidadeMax().ToString());
                list_informacao_cavalo.Items.Add(lvi);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
