namespace Ekaprojekti
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
            this.NimiLB = new System.Windows.Forms.Label();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.PeruutaBT = new System.Windows.Forms.Button();
            this.TekstiTB = new System.Windows.Forms.TextBox();
            this.ViestiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NimiLB
            // 
            this.NimiLB.AutoSize = true;
            this.NimiLB.Location = new System.Drawing.Point(302, 226);
            this.NimiLB.Name = "NimiLB";
            this.NimiLB.Size = new System.Drawing.Size(183, 29);
            this.NimiLB.TabIndex = 0;
            this.NimiLB.Text = "Anna etunimesi:";
            // 
            // MuutaBT
            // 
            this.MuutaBT.BackColor = System.Drawing.Color.Red;
            this.MuutaBT.Location = new System.Drawing.Point(535, 291);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(183, 104);
            this.MuutaBT.TabIndex = 1;
            this.MuutaBT.Text = "Muuta teksti";
            this.MuutaBT.UseVisualStyleBackColor = false;
            this.MuutaBT.Click += new System.EventHandler(this.MuutaBT_Click);
            // 
            // PeruutaBT
            // 
            this.PeruutaBT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PeruutaBT.Location = new System.Drawing.Point(813, 291);
            this.PeruutaBT.Name = "PeruutaBT";
            this.PeruutaBT.Size = new System.Drawing.Size(168, 104);
            this.PeruutaBT.TabIndex = 2;
            this.PeruutaBT.Text = "Peruuta";
            this.PeruutaBT.UseVisualStyleBackColor = false;
            this.PeruutaBT.Click += new System.EventHandler(this.PeruutaBT_Click);
            // 
            // TekstiTB
            // 
            this.TekstiTB.Location = new System.Drawing.Point(535, 220);
            this.TekstiTB.Name = "TekstiTB";
            this.TekstiTB.Size = new System.Drawing.Size(446, 35);
            this.TekstiTB.TabIndex = 3;
            // 
            // ViestiLB
            // 
            this.ViestiLB.AutoSize = true;
            this.ViestiLB.Location = new System.Drawing.Point(327, 458);
            this.ViestiLB.Name = "ViestiLB";
            this.ViestiLB.Size = new System.Drawing.Size(72, 29);
            this.ViestiLB.TabIndex = 4;
            this.ViestiLB.Text = "Viesti";
            this.ViestiLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 734);
            this.Controls.Add(this.ViestiLB);
            this.Controls.Add(this.TekstiTB);
            this.Controls.Add(this.PeruutaBT);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.NimiLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NimiLB;
        private System.Windows.Forms.Button MuutaBT;
        private System.Windows.Forms.Button PeruutaBT;
        private System.Windows.Forms.TextBox TekstiTB;
        private System.Windows.Forms.Label ViestiLB;
    }
}

