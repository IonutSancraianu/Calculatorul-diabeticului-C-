namespace Calculatorul_Diabeticului2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chpaine = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.calc_dozadeinsulina = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.calc_proteine = new System.Windows.Forms.Button();
            this.calc_lipide = new System.Windows.Forms.Button();
            this.calculeazacarbo = new System.Windows.Forms.Button();
            this.calc_calorii = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpaine = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(195, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 92;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Cyan;
            this.checkBox2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(725, 252);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(141, 26);
            this.checkBox2.TabIndex = 91;
            this.checkBox2.Text = "Glicemie<85";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Cyan;
            this.checkBox1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(725, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 26);
            this.checkBox1.TabIndex = 90;
            this.checkBox1.Text = "Glicemie >190";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(962, 22);
            this.label4.TabIndex = 89;
            this.label4.Text = "Atentie!!! Calculul fiecarei substante nutritive sa aiba valoarea corespondenta i" +
    "n fereastra din dreapta-sus";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1118, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 61);
            this.button1.TabIndex = 88;
            this.button1.Text = "Meniu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.comboBox1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Procentul de carbohidrati",
            "Procentul de lipide",
            "Procentul de proteine"});
            this.comboBox1.Location = new System.Drawing.Point(755, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 30);
            this.comboBox1.TabIndex = 87;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chpaine
            // 
            this.chpaine.Location = new System.Drawing.Point(1053, 35);
            this.chpaine.Name = "chpaine";
            this.chpaine.Size = new System.Drawing.Size(110, 22);
            this.chpaine.TabIndex = 86;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(556, 223);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(130, 22);
            this.textBox7.TabIndex = 85;
            // 
            // calc_dozadeinsulina
            // 
            this.calc_dozadeinsulina.BackColor = System.Drawing.Color.Gray;
            this.calc_dozadeinsulina.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_dozadeinsulina.ForeColor = System.Drawing.Color.Black;
            this.calc_dozadeinsulina.Location = new System.Drawing.Point(389, 178);
            this.calc_dozadeinsulina.Name = "calc_dozadeinsulina";
            this.calc_dozadeinsulina.Size = new System.Drawing.Size(140, 108);
            this.calc_dozadeinsulina.TabIndex = 84;
            this.calc_dozadeinsulina.Text = "Calculeaza doza de insulina \r\n(unitati)\r\n";
            this.calc_dozadeinsulina.UseVisualStyleBackColor = false;
            this.calc_dozadeinsulina.Click += new System.EventHandler(this.calc_dozadeinsulina_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(174, 395);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(129, 22);
            this.textBox6.TabIndex = 83;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(174, 328);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 22);
            this.textBox5.TabIndex = 82;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 261);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(129, 22);
            this.textBox4.TabIndex = 81;
            // 
            // calc_proteine
            // 
            this.calc_proteine.BackColor = System.Drawing.Color.Gray;
            this.calc_proteine.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_proteine.ForeColor = System.Drawing.Color.Black;
            this.calc_proteine.Location = new System.Drawing.Point(24, 307);
            this.calc_proteine.Name = "calc_proteine";
            this.calc_proteine.Size = new System.Drawing.Size(140, 61);
            this.calc_proteine.TabIndex = 80;
            this.calc_proteine.Text = "Calculeaza proteine\r\n";
            this.calc_proteine.UseVisualStyleBackColor = false;
            this.calc_proteine.Click += new System.EventHandler(this.calc_proteine_Click);
            // 
            // calc_lipide
            // 
            this.calc_lipide.BackColor = System.Drawing.Color.Gray;
            this.calc_lipide.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_lipide.ForeColor = System.Drawing.Color.Black;
            this.calc_lipide.Location = new System.Drawing.Point(24, 240);
            this.calc_lipide.Name = "calc_lipide";
            this.calc_lipide.Size = new System.Drawing.Size(140, 61);
            this.calc_lipide.TabIndex = 79;
            this.calc_lipide.Text = "Calculeaza lipide\r\n";
            this.calc_lipide.UseVisualStyleBackColor = false;
            this.calc_lipide.Click += new System.EventHandler(this.calc_lipide_Click);
            // 
            // calculeazacarbo
            // 
            this.calculeazacarbo.BackColor = System.Drawing.Color.Gray;
            this.calculeazacarbo.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculeazacarbo.ForeColor = System.Drawing.Color.Black;
            this.calculeazacarbo.Location = new System.Drawing.Point(24, 173);
            this.calculeazacarbo.Name = "calculeazacarbo";
            this.calculeazacarbo.Size = new System.Drawing.Size(157, 61);
            this.calculeazacarbo.TabIndex = 78;
            this.calculeazacarbo.Text = "Calculeaza carbohidtrati\r\n";
            this.calculeazacarbo.UseVisualStyleBackColor = false;
            this.calculeazacarbo.Click += new System.EventHandler(this.calculeazacarbo_Click);
            // 
            // calc_calorii
            // 
            this.calc_calorii.BackColor = System.Drawing.Color.Gray;
            this.calc_calorii.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc_calorii.ForeColor = System.Drawing.Color.Black;
            this.calc_calorii.Location = new System.Drawing.Point(24, 374);
            this.calc_calorii.Name = "calc_calorii";
            this.calc_calorii.Size = new System.Drawing.Size(140, 61);
            this.calc_calorii.TabIndex = 77;
            this.calc_calorii.Text = "Calculeaza calorii";
            this.calc_calorii.UseVisualStyleBackColor = false;
            this.calc_calorii.Click += new System.EventHandler(this.calc_calorii_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(458, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 22);
            this.textBox2.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 22);
            this.label2.TabIndex = 75;
            this.label2.Text = "Introduceti factorul de sensibilate la insulina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1043, 22);
            this.label3.TabIndex = 74;
            this.label3.Text = "*factorul de sensibilitate la insulina= numarul de grame de carbohidtrati procesa" +
    "te de o singura unitate de insulina";
            // 
            // gpaine
            // 
            this.gpaine.Location = new System.Drawing.Point(340, 86);
            this.gpaine.Name = "gpaine";
            this.gpaine.Size = new System.Drawing.Size(110, 22);
            this.gpaine.TabIndex = 73;
            this.gpaine.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 44);
            this.label1.TabIndex = 72;
            this.label1.Text = "Introduceti cantitatea de ciocolata\r\n dorita (grame)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1118, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 53);
            this.button2.TabIndex = 93;
            this.button2.Text = "Stergere";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1278, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chpaine);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.calc_dozadeinsulina);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.calc_proteine);
            this.Controls.Add(this.calc_lipide);
            this.Controls.Add(this.calculeazacarbo);
            this.Controls.Add(this.calc_calorii);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gpaine);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Ciocolata";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox chpaine;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button calc_dozadeinsulina;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button calc_proteine;
        private System.Windows.Forms.Button calc_lipide;
        private System.Windows.Forms.Button calculeazacarbo;
        private System.Windows.Forms.Button calc_calorii;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gpaine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;

    }
}