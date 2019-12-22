namespace Exerc1INDES
{
    partial class InformacaoCavalo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list_informacao_cavalo = new System.Windows.Forms.ListView();
            this.nameHorse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.speedInit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.speedCurrent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.speedFinish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.health = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vitality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_informacao_cavalo
            // 
            this.list_informacao_cavalo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHorse,
            this.speedInit,
            this.speedCurrent,
            this.speedFinish,
            this.health,
            this.vitality});
            this.list_informacao_cavalo.GridLines = true;
            this.list_informacao_cavalo.HideSelection = false;
            this.list_informacao_cavalo.Location = new System.Drawing.Point(0, 0);
            this.list_informacao_cavalo.Name = "list_informacao_cavalo";
            this.list_informacao_cavalo.Size = new System.Drawing.Size(674, 300);
            this.list_informacao_cavalo.TabIndex = 0;
            this.list_informacao_cavalo.UseCompatibleStateImageBehavior = false;
            this.list_informacao_cavalo.View = System.Windows.Forms.View.Details;
            // 
            // nameHorse
            // 
            this.nameHorse.Text = "Nome do Cavalo";
            this.nameHorse.Width = 120;
            // 
            // speedInit
            // 
            this.speedInit.Text = "Velocidade Inciale";
            this.speedInit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedInit.Width = 110;
            // 
            // speedCurrent
            // 
            this.speedCurrent.Text = "Velocidade curente";
            this.speedCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedCurrent.Width = 110;
            // 
            // speedFinish
            // 
            this.speedFinish.Text = "Velocidade finale";
            this.speedFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedFinish.Width = 110;
            // 
            // health
            // 
            this.health.Text = "Saude";
            this.health.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.health.Width = 110;
            // 
            // vitality
            // 
            this.vitality.Text = "Vitalidade maxima";
            this.vitality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vitality.Width = 110;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(306, 306);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // InformacaoCavalo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(674, 341);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.list_informacao_cavalo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InformacaoCavalo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informação dos cavalos da corrida";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_informacao_cavalo;
        private System.Windows.Forms.ColumnHeader nameHorse;
        private System.Windows.Forms.ColumnHeader speedInit;
        private System.Windows.Forms.ColumnHeader speedCurrent;
        private System.Windows.Forms.ColumnHeader speedFinish;
        private System.Windows.Forms.ColumnHeader health;
        private System.Windows.Forms.ColumnHeader vitality;
        private System.Windows.Forms.Button btn_Close;
    }
}