namespace PametnaHisa
{
    partial class Form2
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
            this.da = new System.Windows.Forms.RadioButton();
            this.ne = new System.Windows.Forms.RadioButton();
            this.vrstaZarnice = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Potrdi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ne);
            this.groupBox1.Controls.Add(this.da);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dim mode:";
            // 
            // da
            // 
            this.da.AutoSize = true;
            this.da.Location = new System.Drawing.Point(14, 29);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(54, 28);
            this.da.TabIndex = 0;
            this.da.TabStop = true;
            this.da.Text = "DA";
            this.da.UseVisualStyleBackColor = true;
            // 
            // ne
            // 
            this.ne.AutoSize = true;
            this.ne.Location = new System.Drawing.Point(87, 29);
            this.ne.Name = "ne";
            this.ne.Size = new System.Drawing.Size(55, 28);
            this.ne.TabIndex = 1;
            this.ne.TabStop = true;
            this.ne.Text = "NE";
            this.ne.UseVisualStyleBackColor = true;
            // 
            // vrstaZarnice
            // 
            this.vrstaZarnice.Location = new System.Drawing.Point(12, 37);
            this.vrstaZarnice.Name = "vrstaZarnice";
            this.vrstaZarnice.Size = new System.Drawing.Size(142, 20);
            this.vrstaZarnice.TabIndex = 1;
            this.vrstaZarnice.Text = "Vpiši vrsto žarnice:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Vpiši moč žarnice:";
            // 
            // Potrdi
            // 
            this.Potrdi.Location = new System.Drawing.Point(54, 183);
            this.Potrdi.Name = "Potrdi";
            this.Potrdi.Size = new System.Drawing.Size(75, 23);
            this.Potrdi.TabIndex = 3;
            this.Potrdi.Text = "Vredu";
            this.Potrdi.UseVisualStyleBackColor = true;
            this.Potrdi.Click += new System.EventHandler(this.Potrdi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 216);
            this.Controls.Add(this.Potrdi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.vrstaZarnice);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Nastavitve Luč";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ne;
        private System.Windows.Forms.RadioButton da;
        private System.Windows.Forms.TextBox vrstaZarnice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Potrdi;
    }
}