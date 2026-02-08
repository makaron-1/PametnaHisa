namespace PametnaHisa
{
    partial class Form6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.velika = new System.Windows.Forms.RadioButton();
            this.Srednja = new System.Windows.Forms.RadioButton();
            this.mala = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ne = new System.Windows.Forms.RadioButton();
            this.da = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Potrdi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.velika);
            this.groupBox1.Controls.Add(this.Srednja);
            this.groupBox1.Controls.Add(this.mala);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Velikost klime:";
            // 
            // velika
            // 
            this.velika.AutoSize = true;
            this.velika.Location = new System.Drawing.Point(19, 84);
            this.velika.Name = "velika";
            this.velika.Size = new System.Drawing.Size(79, 28);
            this.velika.TabIndex = 2;
            this.velika.TabStop = true;
            this.velika.Text = "Velika";
            this.velika.UseVisualStyleBackColor = true;
            // 
            // Srednja
            // 
            this.Srednja.AutoSize = true;
            this.Srednja.Location = new System.Drawing.Point(18, 55);
            this.Srednja.Name = "Srednja";
            this.Srednja.Size = new System.Drawing.Size(93, 28);
            this.Srednja.TabIndex = 1;
            this.Srednja.TabStop = true;
            this.Srednja.Text = "Srednja";
            this.Srednja.UseVisualStyleBackColor = true;
            // 
            // mala
            // 
            this.mala.AutoSize = true;
            this.mala.Location = new System.Drawing.Point(19, 28);
            this.mala.Name = "mala";
            this.mala.Size = new System.Drawing.Size(90, 28);
            this.mala.TabIndex = 0;
            this.mala.TabStop = true;
            this.mala.Text = "Majhna";
            this.mala.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ne);
            this.groupBox2.Controls.Add(this.da);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 52);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Poletno hlajenje:";
            // 
            // ne
            // 
            this.ne.AutoSize = true;
            this.ne.Location = new System.Drawing.Point(128, 27);
            this.ne.Name = "ne";
            this.ne.Size = new System.Drawing.Size(55, 28);
            this.ne.TabIndex = 1;
            this.ne.TabStop = true;
            this.ne.Text = "NE";
            this.ne.UseVisualStyleBackColor = true;
            // 
            // da
            // 
            this.da.AutoSize = true;
            this.da.Location = new System.Drawing.Point(57, 27);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(54, 28);
            this.da.TabIndex = 0;
            this.da.TabStop = true;
            this.da.Text = "DA";
            this.da.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vpiši temperaturo klime:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Potrdi
            // 
            this.Potrdi.Location = new System.Drawing.Point(108, 305);
            this.Potrdi.Name = "Potrdi";
            this.Potrdi.Size = new System.Drawing.Size(75, 23);
            this.Potrdi.TabIndex = 3;
            this.Potrdi.Text = "Vredu";
            this.Potrdi.UseVisualStyleBackColor = true;
            this.Potrdi.Click += new System.EventHandler(this.Potrdi_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 340);
            this.Controls.Add(this.Potrdi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form6";
            this.Text = "Nastavitve Klima";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton velika;
        private System.Windows.Forms.RadioButton Srednja;
        private System.Windows.Forms.RadioButton mala;
        private System.Windows.Forms.RadioButton ne;
        private System.Windows.Forms.RadioButton da;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Potrdi;
    }
}