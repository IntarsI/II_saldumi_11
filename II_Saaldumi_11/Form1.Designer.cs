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
            this.SuspendLayout();
            // 
            // naudaslaukums
            // 
            this.naudaslaukums.Location = new System.Drawing.Point(46, 226);
            this.naudaslaukums.Name = "naudaslaukums";
            this.naudaslaukums.Size = new System.Drawing.Size(291, 20);
            this.naudaslaukums.TabIndex = 0;
            this.naudaslaukums.TextChanged += new System.EventHandler(this.naudaslaukums_TextChanged);
            // 
            // masaslaukums
            // 
            this.masaslaukums.Location = new System.Drawing.Point(652, 250);
            this.masaslaukums.Name = "masaslaukums";
            this.masaslaukums.Size = new System.Drawing.Size(100, 20);
            this.masaslaukums.TabIndex = 1;
            this.masaslaukums.TextChanged += new System.EventHandler(this.masaslaukums_TextChanged);
            // 
            // poga
            // 
            this.poga.Location = new System.Drawing.Point(217, 289);
            this.poga.Name = "poga";
            this.poga.Size = new System.Drawing.Size(258, 23);
            this.poga.TabIndex = 2;
            this.poga.Text = "Veikt aprekinus";
            this.poga.UseVisualStyleBackColor = true;
            this.poga.Click += new System.EventHandler(this.poga_Click);
            // 
            // Nosaukums
            // 
            this.Nosaukums.AutoSize = true;
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(195, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Saldumu cena ir 9.88 Eur/kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ludzu ievadiet cenu par kuru velaties nopirkt saldumus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciparu ievadiet luzdu ar komatu nevis punktu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

