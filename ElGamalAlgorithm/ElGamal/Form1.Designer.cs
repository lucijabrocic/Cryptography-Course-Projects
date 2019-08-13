namespace ElGamal
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
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlfa = new System.Windows.Forms.TextBox();
            this.btnSifriraj = new System.Windows.Forms.Button();
            this.rtxtIspis = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDesifriraj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtK = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(88, 83);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(114, 22);
            this.txtP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ElGamalov algoritam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "p:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "α:";
            // 
            // txtAlfa
            // 
            this.txtAlfa.Location = new System.Drawing.Point(88, 127);
            this.txtAlfa.Name = "txtAlfa";
            this.txtAlfa.Size = new System.Drawing.Size(114, 22);
            this.txtAlfa.TabIndex = 4;
            // 
            // btnSifriraj
            // 
            this.btnSifriraj.Location = new System.Drawing.Point(54, 352);
            this.btnSifriraj.Name = "btnSifriraj";
            this.btnSifriraj.Size = new System.Drawing.Size(148, 49);
            this.btnSifriraj.TabIndex = 6;
            this.btnSifriraj.Text = "Šifriraj";
            this.btnSifriraj.UseVisualStyleBackColor = true;
            this.btnSifriraj.Click += new System.EventHandler(this.btnSifriraj_Click);
            // 
            // rtxtIspis
            // 
            this.rtxtIspis.Location = new System.Drawing.Point(269, 80);
            this.rtxtIspis.Name = "rtxtIspis";
            this.rtxtIspis.Size = new System.Drawing.Size(259, 321);
            this.rtxtIspis.TabIndex = 7;
            this.rtxtIspis.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unos otvorenog teksta";
            // 
            // btnDesifriraj
            // 
            this.btnDesifriraj.Location = new System.Drawing.Point(547, 352);
            this.btnDesifriraj.Name = "btnDesifriraj";
            this.btnDesifriraj.Size = new System.Drawing.Size(198, 49);
            this.btnDesifriraj.TabIndex = 9;
            this.btnDesifriraj.Text = "Dešifriraj";
            this.btnDesifriraj.UseVisualStyleBackColor = true;
            this.btnDesifriraj.Click += new System.EventHandler(this.btnDesifriraj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "a:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "k:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(88, 173);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(114, 22);
            this.txtA.TabIndex = 12;
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(88, 217);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(114, 22);
            this.txtK.TabIndex = 13;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(54, 295);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(148, 22);
            this.txtM.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Unos šifrata";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(563, 295);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(71, 22);
            this.txtY1.TabIndex = 16;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(655, 295);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(71, 22);
            this.txtY2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "(";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = ",";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(732, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = ")";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(563, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(203, 154);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "- Za šifriranje treba unijeti sve parametre\n- Za dešifriranje treba unijeti šifra" +
    "t te parametre p, α (zbog ispisa) i a";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(560, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Upute:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 429);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDesifriraj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtIspis);
            this.Controls.Add(this.btnSifriraj);
            this.Controls.Add(this.txtAlfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlfa;
        private System.Windows.Forms.Button btnSifriraj;
        private System.Windows.Forms.RichTextBox rtxtIspis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDesifriraj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label11;
    }
}

