namespace Exerc1INDES
{
    partial class HorseRice
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
            this.components = new System.ComponentModel.Container();
            this.gbx_aposta = new System.Windows.Forms.GroupBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_creditos = new System.Windows.Forms.Button();
            this.pnl_corrida = new System.Windows.Forms.Panel();
            this.lbl_numeroCorrida = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gbx_aposta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_aposta
            // 
            this.gbx_aposta.Controls.Add(this.btn_Run);
            this.gbx_aposta.Location = new System.Drawing.Point(12, 577);
            this.gbx_aposta.Name = "gbx_aposta";
            this.gbx_aposta.Size = new System.Drawing.Size(1360, 262);
            this.gbx_aposta.TabIndex = 1;
            this.gbx_aposta.TabStop = false;
            this.gbx_aposta.Text = "Aposta";
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(1241, 19);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(113, 171);
            this.btn_Run.TabIndex = 0;
            this.btn_Run.Text = "RUN!";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.Btn_Run_Click);
            // 
            // btn_info
            // 
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.Location = new System.Drawing.Point(1139, 12);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(98, 86);
            this.btn_info.TabIndex = 2;
            this.btn_info.Text = "INFO";
            this.btn_info.UseVisualStyleBackColor = true;
            this.btn_info.Click += new System.EventHandler(this.Btn_info_Click);
            // 
            // btn_creditos
            // 
            this.btn_creditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creditos.Location = new System.Drawing.Point(1253, 12);
            this.btn_creditos.Name = "btn_creditos";
            this.btn_creditos.Size = new System.Drawing.Size(119, 86);
            this.btn_creditos.TabIndex = 3;
            this.btn_creditos.Text = "Creditos";
            this.btn_creditos.UseVisualStyleBackColor = true;
            this.btn_creditos.Click += new System.EventHandler(this.Btn_creditos_Click);
            // 
            // pnl_corrida
            // 
            this.pnl_corrida.Location = new System.Drawing.Point(12, 142);
            this.pnl_corrida.Name = "pnl_corrida";
            this.pnl_corrida.Size = new System.Drawing.Size(1360, 400);
            this.pnl_corrida.TabIndex = 4;
            // 
            // lbl_numeroCorrida
            // 
            this.lbl_numeroCorrida.AutoSize = true;
            this.lbl_numeroCorrida.Location = new System.Drawing.Point(12, 17);
            this.lbl_numeroCorrida.Name = "lbl_numeroCorrida";
            this.lbl_numeroCorrida.Size = new System.Drawing.Size(28, 13);
            this.lbl_numeroCorrida.TabIndex = 5;
            this.lbl_numeroCorrida.Text = "todo";
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // HorseRice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1384, 851);
            this.Controls.Add(this.lbl_numeroCorrida);
            this.Controls.Add(this.pnl_corrida);
            this.Controls.Add(this.btn_creditos);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.gbx_aposta);
            this.MaximizeBox = false;
            this.Name = "HorseRice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horse Rice Race";
            this.gbx_aposta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbx_aposta;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_creditos;
        private System.Windows.Forms.Panel pnl_corrida;
        private System.Windows.Forms.Label lbl_numeroCorrida;
        private System.Windows.Forms.Timer timer;
    }
}

