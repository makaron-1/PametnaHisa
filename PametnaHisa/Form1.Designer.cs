namespace PametnaHisa
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Klima = new System.Windows.Forms.RadioButton();
            this.Roleta = new System.Windows.Forms.RadioButton();
            this.Termostat = new System.Windows.Forms.RadioButton();
            this.Alarm = new System.Windows.Forms.RadioButton();
            this.Luc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnIzbris = new System.Windows.Forms.Button();
            this.btnVklopi = new System.Windows.Forms.Button();
            this.Stevilo = new System.Windows.Forms.TextBox();
            this.Poraba = new System.Windows.Forms.TextBox();
            this.stNaprav = new System.Windows.Forms.Label();
            this.prEnergije = new System.Windows.Forms.Label();
            this.izpis = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.primerjaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.celotnaPoraba = new System.Windows.Forms.TextBox();
            this.nightMode = new System.Windows.Forms.Button();
            this.vklopiVse = new System.Windows.Forms.Button();
            this.izklopiVse = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PametnaHisa.Properties.Resources.Ziher_hise_tloris_CARNIUM_NADSTROPJE_merilo_50;
            this.pictureBox1.InitialImage = global::PametnaHisa.Properties.Resources.Ziher_hise_tloris_CARNIUM_NADSTROPJE_merilo_50;
            this.pictureBox1.Location = new System.Drawing.Point(44, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Klima);
            this.groupBox1.Controls.Add(this.Roleta);
            this.groupBox1.Controls.Add(this.Termostat);
            this.groupBox1.Controls.Add(this.Alarm);
            this.groupBox1.Controls.Add(this.Luc);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Naprave";
            // 
            // Klima
            // 
            this.Klima.AutoSize = true;
            this.Klima.Location = new System.Drawing.Point(202, 29);
            this.Klima.Name = "Klima";
            this.Klima.Size = new System.Drawing.Size(50, 17);
            this.Klima.TabIndex = 4;
            this.Klima.TabStop = true;
            this.Klima.Text = "Klima";
            this.Klima.UseVisualStyleBackColor = true;
            this.Klima.CheckedChanged += new System.EventHandler(this.Klima_CheckedChanged);
            // 
            // Roleta
            // 
            this.Roleta.AutoSize = true;
            this.Roleta.Location = new System.Drawing.Point(97, 42);
            this.Roleta.Name = "Roleta";
            this.Roleta.Size = new System.Drawing.Size(56, 17);
            this.Roleta.TabIndex = 3;
            this.Roleta.TabStop = true;
            this.Roleta.Text = "Roleta";
            this.Roleta.UseVisualStyleBackColor = true;
            // 
            // Termostat
            // 
            this.Termostat.AutoSize = true;
            this.Termostat.Location = new System.Drawing.Point(97, 19);
            this.Termostat.Name = "Termostat";
            this.Termostat.Size = new System.Drawing.Size(72, 17);
            this.Termostat.TabIndex = 2;
            this.Termostat.TabStop = true;
            this.Termostat.Text = "Termostat";
            this.Termostat.UseVisualStyleBackColor = true;
            this.Termostat.CheckedChanged += new System.EventHandler(this.Termostat_CheckedChanged);
            // 
            // Alarm
            // 
            this.Alarm.AutoSize = true;
            this.Alarm.Location = new System.Drawing.Point(12, 42);
            this.Alarm.Name = "Alarm";
            this.Alarm.Size = new System.Drawing.Size(51, 17);
            this.Alarm.TabIndex = 1;
            this.Alarm.TabStop = true;
            this.Alarm.Text = "Alarm";
            this.Alarm.UseVisualStyleBackColor = true;
            // 
            // Luc
            // 
            this.Luc.AutoSize = true;
            this.Luc.Location = new System.Drawing.Point(12, 19);
            this.Luc.Name = "Luc";
            this.Luc.Size = new System.Drawing.Size(43, 17);
            this.Luc.TabIndex = 0;
            this.Luc.TabStop = true;
            this.Luc.Text = "Luč";
            this.Luc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pametni Hisni Sistem";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(603, 100);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(91, 34);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj Napravo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(309, 145);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(88, 35);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Nastavitve";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnIzbris
            // 
            this.btnIzbris.Location = new System.Drawing.Point(603, 146);
            this.btnIzbris.Name = "btnIzbris";
            this.btnIzbris.Size = new System.Drawing.Size(88, 34);
            this.btnIzbris.TabIndex = 5;
            this.btnIzbris.Text = "Izbriši Napravo";
            this.btnIzbris.UseVisualStyleBackColor = true;
            this.btnIzbris.Click += new System.EventHandler(this.btnIzbris_Click);
            // 
            // btnVklopi
            // 
            this.btnVklopi.Location = new System.Drawing.Point(403, 145);
            this.btnVklopi.Name = "btnVklopi";
            this.btnVklopi.Size = new System.Drawing.Size(88, 35);
            this.btnVklopi.TabIndex = 6;
            this.btnVklopi.Text = "Vklopi";
            this.btnVklopi.UseVisualStyleBackColor = true;
            this.btnVklopi.Click += new System.EventHandler(this.btnVklopi_Click);
            // 
            // Stevilo
            // 
            this.Stevilo.Location = new System.Drawing.Point(914, 131);
            this.Stevilo.Name = "Stevilo";
            this.Stevilo.ReadOnly = true;
            this.Stevilo.Size = new System.Drawing.Size(132, 20);
            this.Stevilo.TabIndex = 7;
            this.Stevilo.TabStop = false;
            this.Stevilo.TextChanged += new System.EventHandler(this.Stevilo_TextChanged);
            // 
            // Poraba
            // 
            this.Poraba.Location = new System.Drawing.Point(931, 168);
            this.Poraba.Name = "Poraba";
            this.Poraba.ReadOnly = true;
            this.Poraba.Size = new System.Drawing.Size(144, 20);
            this.Poraba.TabIndex = 8;
            this.Poraba.TabStop = false;
            // 
            // stNaprav
            // 
            this.stNaprav.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stNaprav.Location = new System.Drawing.Point(771, 131);
            this.stNaprav.Name = "stNaprav";
            this.stNaprav.Size = new System.Drawing.Size(137, 20);
            this.stNaprav.TabIndex = 9;
            this.stNaprav.Text = "Število naprav:";
            // 
            // prEnergije
            // 
            this.prEnergije.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prEnergije.Location = new System.Drawing.Point(698, 165);
            this.prEnergije.Name = "prEnergije";
            this.prEnergije.Size = new System.Drawing.Size(236, 36);
            this.prEnergije.TabIndex = 10;
            this.prEnergije.Text = "Poraba energije naprave:";
            this.prEnergije.Click += new System.EventHandler(this.prEnergije_Click);
            // 
            // izpis
            // 
            this.izpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izpis.Location = new System.Drawing.Point(755, 202);
            this.izpis.Name = "izpis";
            this.izpis.Size = new System.Drawing.Size(153, 25);
            this.izpis.TabIndex = 11;
            this.izpis.Text = "Izpis temperature:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(914, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ime naprave:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(420, 108);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(161, 20);
            this.txtIme.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 685);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(309, 637);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 100);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operatorji";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(136, 61);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "+";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(136, 38);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = ">";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 76);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "<";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(20, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(34, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "!=";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(37, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "==";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(564, 685);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 20);
            this.textBox3.TabIndex = 17;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(769, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "---->";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(849, 685);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(272, 20);
            this.textBox4.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 657);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 63);
            this.label4.TabIndex = 20;
            this.label4.Text = "Primerjave naprav:";
            // 
            // primerjaj
            // 
            this.primerjaj.Location = new System.Drawing.Point(759, 646);
            this.primerjaj.Name = "primerjaj";
            this.primerjaj.Size = new System.Drawing.Size(75, 23);
            this.primerjaj.TabIndex = 21;
            this.primerjaj.Text = "Primerjaj";
            this.primerjaj.UseVisualStyleBackColor = true;
            this.primerjaj.Click += new System.EventHandler(this.primerjaj_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(755, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Celotna poraba:";
            // 
            // celotnaPoraba
            // 
            this.celotnaPoraba.BackColor = System.Drawing.SystemColors.Control;
            this.celotnaPoraba.Location = new System.Drawing.Point(914, 103);
            this.celotnaPoraba.Name = "celotnaPoraba";
            this.celotnaPoraba.ReadOnly = true;
            this.celotnaPoraba.Size = new System.Drawing.Size(130, 20);
            this.celotnaPoraba.TabIndex = 23;
            this.celotnaPoraba.TabStop = false;
            // 
            // nightMode
            // 
            this.nightMode.Location = new System.Drawing.Point(498, 145);
            this.nightMode.Name = "nightMode";
            this.nightMode.Size = new System.Drawing.Size(83, 37);
            this.nightMode.TabIndex = 24;
            this.nightMode.Text = "Night Mode";
            this.nightMode.UseVisualStyleBackColor = true;
            this.nightMode.Click += new System.EventHandler(this.nightMode_Click);
            // 
            // vklopiVse
            // 
            this.vklopiVse.Location = new System.Drawing.Point(403, 186);
            this.vklopiVse.Name = "vklopiVse";
            this.vklopiVse.Size = new System.Drawing.Size(88, 35);
            this.vklopiVse.TabIndex = 25;
            this.vklopiVse.Text = "Vklopi vse";
            this.vklopiVse.UseVisualStyleBackColor = true;
            this.vklopiVse.Click += new System.EventHandler(this.VklopiVseNaprave);
            // 
            // izklopiVse
            // 
            this.izklopiVse.Location = new System.Drawing.Point(309, 186);
            this.izklopiVse.Name = "izklopiVse";
            this.izklopiVse.Size = new System.Drawing.Size(88, 35);
            this.izklopiVse.TabIndex = 26;
            this.izklopiVse.Text = "Izklopi vse";
            this.izklopiVse.UseVisualStyleBackColor = true;
            this.izklopiVse.Click += new System.EventHandler(this.IzklopiVseNaprave);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(775, 287);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(314, 316);
            this.listBox1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(776, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Zgodovina sprememb:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.izklopiVse);
            this.Controls.Add(this.vklopiVse);
            this.Controls.Add(this.nightMode);
            this.Controls.Add(this.celotnaPoraba);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.primerjaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.izpis);
            this.Controls.Add(this.prEnergije);
            this.Controls.Add(this.stNaprav);
            this.Controls.Add(this.Poraba);
            this.Controls.Add(this.Stevilo);
            this.Controls.Add(this.btnVklopi);
            this.Controls.Add(this.btnIzbris);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Klima;
        private System.Windows.Forms.RadioButton Roleta;
        private System.Windows.Forms.RadioButton Termostat;
        private System.Windows.Forms.RadioButton Alarm;
        private System.Windows.Forms.RadioButton Luc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnIzbris;
        private System.Windows.Forms.Button btnVklopi;
        private System.Windows.Forms.TextBox Stevilo;
        private System.Windows.Forms.TextBox Poraba;
        private System.Windows.Forms.Label stNaprav;
        private System.Windows.Forms.Label prEnergije;
        private System.Windows.Forms.Label izpis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button primerjaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox celotnaPoraba;
        private System.Windows.Forms.Button nightMode;
        private System.Windows.Forms.Button vklopiVse;
        private System.Windows.Forms.Button izklopiVse;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
    }
}

