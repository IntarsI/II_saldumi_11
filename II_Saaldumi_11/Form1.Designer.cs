namespace II_Saaldumi_11
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
            this.naudaslaukums = new System.Windows.Forms.TextBox();
            this.masaslaukums = new System.Windows.Forms.TextBox();
            this.poga = new System.Windows.Forms.Button();
            this.Nosaukums = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Vesma = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // naudaslaukums
            // 
            this.naudaslaukums.Location = new System.Drawing.Point(253, 127);
            this.naudaslaukums.Name = "naudaslaukums";
            this.naudaslaukums.Size = new System.Drawing.Size(291, 20);
            this.naudaslaukums.TabIndex = 0;
            this.naudaslaukums.TextChanged += new System.EventHandler(this.naudaslaukums_TextChanged);
            // 
            // masaslaukums
            // 
            this.masaslaukums.Location = new System.Drawing.Point(484, 256);
            this.masaslaukums.Name = "masaslaukums";
            this.masaslaukums.Size = new System.Drawing.Size(291, 20);
            this.masaslaukums.TabIndex = 1;
            this.masaslaukums.TextChanged += new System.EventHandler(this.masaslaukums_TextChanged);
            // 
            // poga
            // 
            this.poga.AutoEllipsis = true;
            this.poga.BackColor = System.Drawing.Color.Cyan;
            this.poga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.poga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.poga.Location = new System.Drawing.Point(201, 390);
            this.poga.Name = "poga";
            this.poga.Size = new System.Drawing.Size(376, 64);
            this.poga.TabIndex = 2;
            this.poga.Text = "Veikt aprekinus";
            this.poga.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.poga.UseVisualStyleBackColor = false;
            this.poga.Click += new System.EventHandler(this.poga_Click);
            // 
            // Nosaukums
            // 
            this.Nosaukums.AutoSize = true;
            this.Nosaukums.BackColor = System.Drawing.SystemColors.Info;
            this.Nosaukums.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Nosaukums.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Nosaukums.Location = new System.Drawing.Point(3, 9);
            this.Nosaukums.Name = "Nosaukums";
            this.Nosaukums.Size = new System.Drawing.Size(785, 55);
            this.Nosaukums.TabIndex = 3;
            this.Nosaukums.Text = "Saldumu daudzuma aprekinasana";
            this.Nosaukums.Click += new System.EventHandler(this.Nosaukums_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(195, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(240, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ludzu ievadiet cenu par kuru velaties nopirkt saldumus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(271, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciparu ievadiet ludzu ar komatu nevis punktu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Vesma
            // 
            this.Vesma.AutoSize = true;
            this.Vesma.Location = new System.Drawing.Point(64, 222);
            this.Vesma.Name = "Vesma";
            this.Vesma.Size = new System.Drawing.Size(118, 17);
            this.Vesma.TabIndex = 8;
            this.Vesma.Text = "Vēsma 7,56 Eur/kg";
            this.Vesma.UseVisualStyleBackColor = true;
            this.Vesma.CheckedChanged += new System.EventHandler(this.Vesma_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(64, 245);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Serenāde 15,49 Eur/kg";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(64, 268);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(122, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Bārbele 5,76 Eur/kg";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(64, 291);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(147, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Rudzupuķe 14,99 Eur/kg";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(64, 314);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(242, 17);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Šok. konf. ķirši liķierī PERGALE 21,69 Eur/kg";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(314, 265);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(314, 288);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(314, 311);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(787, 466);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Vesma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nosaukums);
            this.Controls.Add(this.poga);
            this.Controls.Add(this.masaslaukums);
            this.Controls.Add(this.naudaslaukums);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox naudaslaukums;
        private System.Windows.Forms.TextBox masaslaukums;
        private System.Windows.Forms.Button poga;
        private System.Windows.Forms.Label Nosaukums;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Vesma;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

