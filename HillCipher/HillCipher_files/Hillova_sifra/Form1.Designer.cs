namespace Hillova_sifra
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
            this.label1 = new System.Windows.Forms.Label();
            this.mat11 = new System.Windows.Forms.TextBox();
            this.mat12 = new System.Windows.Forms.TextBox();
            this.mat13 = new System.Windows.Forms.TextBox();
            this.mat23 = new System.Windows.Forms.TextBox();
            this.mat22 = new System.Windows.Forms.TextBox();
            this.mat21 = new System.Windows.Forms.TextBox();
            this.mat33 = new System.Windows.Forms.TextBox();
            this.mat32 = new System.Windows.Forms.TextBox();
            this.mat31 = new System.Windows.Forms.TextBox();
            this.rtxtUnos = new System.Windows.Forms.RichTextBox();
            this.rtxtIspis = new System.Windows.Forms.RichTextBox();
            this.btnSifriraj = new System.Windows.Forms.Button();
            this.btnDesifriraj = new System.Windows.Forms.Button();
            this.btnMat1 = new System.Windows.Forms.Button();
            this.rtxtOpis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrica 3x3:";
            // 
            // mat11
            // 
            this.mat11.Location = new System.Drawing.Point(70, 101);
            this.mat11.Name = "mat11";
            this.mat11.Size = new System.Drawing.Size(47, 22);
            this.mat11.TabIndex = 1;
            // 
            // mat12
            // 
            this.mat12.Location = new System.Drawing.Point(136, 101);
            this.mat12.Name = "mat12";
            this.mat12.Size = new System.Drawing.Size(47, 22);
            this.mat12.TabIndex = 2;
            // 
            // mat13
            // 
            this.mat13.Location = new System.Drawing.Point(205, 101);
            this.mat13.Name = "mat13";
            this.mat13.Size = new System.Drawing.Size(47, 22);
            this.mat13.TabIndex = 3;
            // 
            // mat23
            // 
            this.mat23.Location = new System.Drawing.Point(205, 143);
            this.mat23.Name = "mat23";
            this.mat23.Size = new System.Drawing.Size(47, 22);
            this.mat23.TabIndex = 6;
            // 
            // mat22
            // 
            this.mat22.Location = new System.Drawing.Point(136, 143);
            this.mat22.Name = "mat22";
            this.mat22.Size = new System.Drawing.Size(47, 22);
            this.mat22.TabIndex = 5;
            // 
            // mat21
            // 
            this.mat21.Location = new System.Drawing.Point(70, 143);
            this.mat21.Name = "mat21";
            this.mat21.Size = new System.Drawing.Size(47, 22);
            this.mat21.TabIndex = 4;
            // 
            // mat33
            // 
            this.mat33.Location = new System.Drawing.Point(205, 185);
            this.mat33.Name = "mat33";
            this.mat33.Size = new System.Drawing.Size(47, 22);
            this.mat33.TabIndex = 9;
            // 
            // mat32
            // 
            this.mat32.Location = new System.Drawing.Point(136, 185);
            this.mat32.Name = "mat32";
            this.mat32.Size = new System.Drawing.Size(47, 22);
            this.mat32.TabIndex = 8;
            // 
            // mat31
            // 
            this.mat31.Location = new System.Drawing.Point(70, 185);
            this.mat31.Name = "mat31";
            this.mat31.Size = new System.Drawing.Size(47, 22);
            this.mat31.TabIndex = 7;
            // 
            // rtxtUnos
            // 
            this.rtxtUnos.Location = new System.Drawing.Point(70, 372);
            this.rtxtUnos.Name = "rtxtUnos";
            this.rtxtUnos.Size = new System.Drawing.Size(338, 215);
            this.rtxtUnos.TabIndex = 10;
            this.rtxtUnos.Text = "";
            // 
            // rtxtIspis
            // 
            this.rtxtIspis.Location = new System.Drawing.Point(496, 372);
            this.rtxtIspis.Name = "rtxtIspis";
            this.rtxtIspis.Size = new System.Drawing.Size(313, 215);
            this.rtxtIspis.TabIndex = 11;
            this.rtxtIspis.Text = "";
            // 
            // btnSifriraj
            // 
            this.btnSifriraj.Location = new System.Drawing.Point(313, 264);
            this.btnSifriraj.Name = "btnSifriraj";
            this.btnSifriraj.Size = new System.Drawing.Size(95, 64);
            this.btnSifriraj.TabIndex = 12;
            this.btnSifriraj.Text = "Šifriraj";
            this.btnSifriraj.UseVisualStyleBackColor = true;
            this.btnSifriraj.Click += new System.EventHandler(this.btnSifriraj_Click);
            // 
            // btnDesifriraj
            // 
            this.btnDesifriraj.Location = new System.Drawing.Point(496, 264);
            this.btnDesifriraj.Name = "btnDesifriraj";
            this.btnDesifriraj.Size = new System.Drawing.Size(95, 64);
            this.btnDesifriraj.TabIndex = 13;
            this.btnDesifriraj.Text = "Dešifriraj";
            this.btnDesifriraj.UseVisualStyleBackColor = true;
            this.btnDesifriraj.Click += new System.EventHandler(this.btnDesifriraj_Click);
            // 
            // btnMat1
            // 
            this.btnMat1.Location = new System.Drawing.Point(313, 101);
            this.btnMat1.Name = "btnMat1";
            this.btnMat1.Size = new System.Drawing.Size(72, 49);
            this.btnMat1.TabIndex = 14;
            this.btnMat1.Text = "Matrica";
            this.btnMat1.UseVisualStyleBackColor = true;
            this.btnMat1.Click += new System.EventHandler(this.btnMat1_Click);
            // 
            // rtxtOpis
            // 
            this.rtxtOpis.Location = new System.Drawing.Point(487, 45);
            this.rtxtOpis.Name = "rtxtOpis";
            this.rtxtOpis.Size = new System.Drawing.Size(322, 137);
            this.rtxtOpis.TabIndex = 15;
            this.rtxtOpis.Text = "Napomene:\n- \"Matrica\" unese matricu koja se može koristiti za provjeru\n- uneseni " +
    "tekst ne mora nužno biti već sređen, npr. isto je unese li se \"UTORAK\" ili \"Utor" +
    "ak!\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 613);
            this.Controls.Add(this.rtxtOpis);
            this.Controls.Add(this.btnMat1);
            this.Controls.Add(this.btnDesifriraj);
            this.Controls.Add(this.btnSifriraj);
            this.Controls.Add(this.rtxtIspis);
            this.Controls.Add(this.rtxtUnos);
            this.Controls.Add(this.mat33);
            this.Controls.Add(this.mat32);
            this.Controls.Add(this.mat31);
            this.Controls.Add(this.mat23);
            this.Controls.Add(this.mat22);
            this.Controls.Add(this.mat21);
            this.Controls.Add(this.mat13);
            this.Controls.Add(this.mat12);
            this.Controls.Add(this.mat11);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hillova Šifra";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mat11;
        private System.Windows.Forms.TextBox mat12;
        private System.Windows.Forms.TextBox mat13;
        private System.Windows.Forms.TextBox mat23;
        private System.Windows.Forms.TextBox mat22;
        private System.Windows.Forms.TextBox mat21;
        private System.Windows.Forms.TextBox mat33;
        private System.Windows.Forms.TextBox mat32;
        private System.Windows.Forms.TextBox mat31;
        private System.Windows.Forms.RichTextBox rtxtUnos;
        private System.Windows.Forms.RichTextBox rtxtIspis;
        private System.Windows.Forms.Button btnSifriraj;
        private System.Windows.Forms.Button btnDesifriraj;
        private System.Windows.Forms.Button btnMat1;
        private System.Windows.Forms.RichTextBox rtxtOpis;
    }
}

