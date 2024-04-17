
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btbAdicionar = new System.Windows.Forms.Button();
            this.lblSF = new System.Windows.Forms.Label();
            this.txtSA = new System.Windows.Forms.TextBox();
            this.txtDEP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(711, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "&X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 28F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(508, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "&LIMPAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "CALCULAR SALDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor do Saldo Atual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(53, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor dos Depósitos: ";
            // 
            // btbAdicionar
            // 
            this.btbAdicionar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btbAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btbAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.btbAdicionar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btbAdicionar.Location = new System.Drawing.Point(50, 526);
            this.btbAdicionar.Name = "btbAdicionar";
            this.btbAdicionar.Size = new System.Drawing.Size(407, 65);
            this.btbAdicionar.TabIndex = 3;
            this.btbAdicionar.Text = "&CALCULAR";
            this.btbAdicionar.UseCompatibleTextRendering = true;
            this.btbAdicionar.UseVisualStyleBackColor = false;
            this.btbAdicionar.Click += new System.EventHandler(this.btbAdicionar_Click);
            // 
            // lblSF
            // 
            this.lblSF.BackColor = System.Drawing.Color.Black;
            this.lblSF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSF.Cursor = System.Windows.Forms.Cursors.No;
            this.lblSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F);
            this.lblSF.ForeColor = System.Drawing.Color.Lime;
            this.lblSF.Location = new System.Drawing.Point(50, 359);
            this.lblSF.Name = "lblSF";
            this.lblSF.Size = new System.Drawing.Size(793, 151);
            this.lblSF.TabIndex = 5;
            this.lblSF.Text = "RESULTADO";
            this.lblSF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSA
            // 
            this.txtSA.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.txtSA.Location = new System.Drawing.Point(340, 137);
            this.txtSA.MaxLength = 999999999;
            this.txtSA.Name = "txtSA";
            this.txtSA.Size = new System.Drawing.Size(503, 65);
            this.txtSA.TabIndex = 1;
            this.txtSA.Text = "0";
            this.txtSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSA_MouseClick);
            this.txtSA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSA_KeyPress_1);
            // 
            // txtDEP
            // 
            this.txtDEP.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtDEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.txtDEP.Location = new System.Drawing.Point(340, 208);
            this.txtDEP.MaxLength = 999999999;
            this.txtDEP.Name = "txtDEP";
            this.txtDEP.Size = new System.Drawing.Size(503, 65);
            this.txtDEP.TabIndex = 2;
            this.txtDEP.Text = "0";
            this.txtDEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDEP.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDEP_MouseClick);
            this.txtDEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDEP_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor dos Saques: ";
            // 
            // txtSQ
            // 
            this.txtSQ.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtSQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 38.25F);
            this.txtSQ.Location = new System.Drawing.Point(340, 279);
            this.txtSQ.MaxLength = 999999999;
            this.txtSQ.Name = "txtSQ";
            this.txtSQ.Size = new System.Drawing.Size(503, 65);
            this.txtSQ.TabIndex = 9;
            this.txtSQ.Text = "0";
            this.txtSQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSQ.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSQ_MouseClick);
            this.txtSQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSQ_KeyPress_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(958, 757);
            this.ControlBox = false;
            this.Controls.Add(this.txtSQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDEP);
            this.Controls.Add(this.txtSA);
            this.Controls.Add(this.lblSF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbAdicionar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(244)))), ((int)(((byte)(71)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btbAdicionar;
        private System.Windows.Forms.Label lblSF;
        private System.Windows.Forms.TextBox txtSA;
        private System.Windows.Forms.TextBox txtDEP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSQ;
    }
}

