namespace PametnaHisa
{
    partial class FormGeslo
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
            this.txtGeslo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtGeslo
            // 
            this.txtGeslo.Location = new System.Drawing.Point(187, 87);
            this.txtGeslo.Name = "txtGeslo";
            this.txtGeslo.PasswordChar = '*';
            this.txtGeslo.Size = new System.Drawing.Size(174, 20);
            this.txtGeslo.TabIndex = 0;
            this.txtGeslo.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(113, 141);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(157, 43);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Confirm";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vnesi geslo:";
            // 
            // FormGeslo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtGeslo);
            this.Name = "FormGeslo";
            this.Text = "FormGeslo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGeslo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
    }
}