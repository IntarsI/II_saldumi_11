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
            this.SuspendLayout();
            // 
            // naudaslaukums
            // 
            this.naudaslaukums.Location = new System.Drawing.Point(232, 238);
            this.naudaslaukums.Name = "naudaslaukums";
            this.naudaslaukums.Size = new System.Drawing.Size(100, 20);
            this.naudaslaukums.TabIndex = 0;
            this.naudaslaukums.TextChanged += new System.EventHandler(this.naudaslaukums_TextChanged);
            // 
            // masaslaukums
            // 
            this.masaslaukums.Location = new System.Drawing.Point(451, 226);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

