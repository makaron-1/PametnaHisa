namespace PametnaHisa
{
    partial class Form5
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
            this.Spust = new System.Windows.Forms.Button();
            this.Dvig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Potrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Spust
            // 
            this.Spust.Location = new System.Drawing.Point(30, 118);
            this.Spust.Name = "Spust";
            this.Spust.Size = new System.Drawing.Size(75, 23);
            this.Spust.TabIndex = 0;
            this.Spust.Text = "Spusti roleto";
            this.Spust.UseVisualStyleBackColor = true;
            this.Spust.Click += new System.EventHandler(this.Spust_Click);
            // 
            // Dvig
            // 
            this.Dvig.Location = new System.Drawing.Point(111, 118);
            this.Dvig.Name = "Dvig";
            this.Dvig.Size = new System.Drawing.Size(75, 23);
            this.Dvig.TabIndex = 1;
            this.Dvig.Text = "Dvigni roleto";
            this.Dvig.UseVisualStyleBackColor = true;
            this.Dvig.Click += new System.EventHandler(this.Dvig_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vpiši vrsto rolete:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Potrdi
            // 
            this.Potrdi.Location = new System.Drawing.Point(64, 167);
            this.Potrdi.Name = "Potrdi";
            this.Potrdi.Size = new System.Drawing.Size(75, 23);
            this.Potrdi.TabIndex = 4;
            this.Potrdi.Text = "Vredu";
            this.Potrdi.UseVisualStyleBackColor = true;
            this.Potrdi.Click += new System.EventHandler(this.Potrdi_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 202);
            this.Controls.Add(this.Potrdi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dvig);
            this.Controls.Add(this.Spust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form5";
            this.Text = "Nastavitve Roleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Spust;
        private System.Windows.Forms.Button Dvig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Potrdi;
    }
}