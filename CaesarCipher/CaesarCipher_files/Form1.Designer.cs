namespace kripto_zadaca1_lucija
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtxtUnos = new System.Windows.Forms.RichTextBox();
            this.txtKljucnaRijec = new System.Windows.Forms.TextBox();
            this.txtPozicija = new System.Windows.Forms.TextBox();
            this.btnSifriraj = new System.Windows.Forms.Button();
            this.btnDesifriraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtIspis = new System.Windows.Forms.RichTextBox();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtxtUnos
            // 
            this.rtxtUnos.Location = new System.Drawing.Point(47, 214);
            this.rtxtUnos.Name = "rtxtUnos";
            this.rtxtUnos.Size = new System.Drawing.Size(320, 316);
            this.rtxtUnos.TabIndex = 0;
            this.rtxtUnos.Text = "";
            // 
            // txtKljucnaRijec
            // 
            this.txtKljucnaRijec.Location = new System.Drawing.Point(44, 598);
            this.txtKljucnaRijec.Name = "txtKljucnaRijec";
            this.txtKljucnaRijec.Size = new System.Drawing.Size(100, 22);
            this.txtKljucnaRijec.TabIndex = 2;
            // 
            // txtPozicija
            // 
            this.txtPozicija.Location = new System.Drawing.Point(185, 598);
            this.txtPozicija.Name = "txtPozicija";
            this.txtPozicija.Size = new System.Drawing.Size(100, 22);
            this.txtPozicija.TabIndex = 3;
            // 
            // btnSifriraj
            // 
            this.btnSifriraj.Location = new System.Drawing.Point(426, 578);
            this.btnSifriraj.Name = "btnSifriraj";
            this.btnSifriraj.Size = new System.Drawing.Size(83, 42);
            this.btnSifriraj.TabIndex = 4;
            this.btnSifriraj.Text = "Šifriraj";
            this.btnSifriraj.UseVisualStyleBackColor = true;
            this.btnSifriraj.Click += new System.EventHandler(this.btnSifriraj_Click);
            // 
            // btnDesifriraj
            // 
            this.btnDesifriraj.Location = new System.Drawing.Point(548, 578);
            this.btnDesifriraj.Name = "btnDesifriraj";
            this.btnDesifriraj.Size = new System.Drawing.Size(83, 42);
            this.btnDesifriraj.TabIndex = 5;
            this.btnDesifriraj.Text = "Dešifriraj";
            this.btnDesifriraj.UseVisualStyleBackColor = true;
            this.btnDesifriraj.Click += new System.EventHandler(this.btnDesifriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ključna riječ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pozicija";
            // 
            // rtxtIspis
            // 
            this.rtxtIspis.Location = new System.Drawing.Point(426, 214);
            this.rtxtIspis.Name = "rtxtIspis";
            this.rtxtIspis.Size = new System.Drawing.Size(320, 316);
            this.rtxtIspis.TabIndex = 9;
            this.rtxtIspis.Text = "";
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(47, 25);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(699, 147);
            this.rtxtOpis.TabIndex = 13;
            this.rtxtOpis.Text = resources.GetString("rtxtOpis.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.rtxtIspis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesifriraj);
            this.Controls.Add(this.btnSifriraj);
            this.Controls.Add(this.txtPozicija);
            this.Controls.Add(this.txtKljucnaRijec);
            this.Controls.Add(this.rtxtUnos);
            this.Name = "Form1";
            this.Text = "Cezarova šifra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtUnos;
        private System.Windows.Forms.TextBox txtKljucnaRijec;
        private System.Windows.Forms.TextBox txtPozicija;
        private System.Windows.Forms.Button btnSifriraj;
        private System.Windows.Forms.Button btnDesifriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtIspis;
        private System.Windows.Forms.RichTextBox rtxtOpis;
    }
}

