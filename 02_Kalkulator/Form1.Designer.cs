namespace _02_Kalkulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLicz = new System.Windows.Forms.Button();
            this.textBoxLiczba1 = new System.Windows.Forms.TextBox();
            this.textBoxLiczba2 = new System.Windows.Forms.TextBox();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.labelBlad = new System.Windows.Forms.Label();
            this.listBoxDzialanie = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wynik";
            // 
            // buttonLicz
            // 
            this.buttonLicz.Location = new System.Drawing.Point(17, 119);
            this.buttonLicz.Name = "buttonLicz";
            this.buttonLicz.Size = new System.Drawing.Size(235, 23);
            this.buttonLicz.TabIndex = 3;
            this.buttonLicz.Text = "Licz";
            this.buttonLicz.UseVisualStyleBackColor = true;
            this.buttonLicz.Click += new System.EventHandler(this.buttonLicz_Click);
            // 
            // textBoxLiczba1
            // 
            this.textBoxLiczba1.Location = new System.Drawing.Point(66, 5);
            this.textBoxLiczba1.Name = "textBoxLiczba1";
            this.textBoxLiczba1.Size = new System.Drawing.Size(186, 20);
            this.textBoxLiczba1.TabIndex = 4;
            this.textBoxLiczba1.Text = "1";
            this.textBoxLiczba1.TextChanged += new System.EventHandler(this.buttonLicz_Click);
            // 
            // textBoxLiczba2
            // 
            this.textBoxLiczba2.Location = new System.Drawing.Point(66, 31);
            this.textBoxLiczba2.Name = "textBoxLiczba2";
            this.textBoxLiczba2.Size = new System.Drawing.Size(186, 20);
            this.textBoxLiczba2.TabIndex = 5;
            this.textBoxLiczba2.Text = "1";
            this.textBoxLiczba2.TextChanged += new System.EventHandler(this.buttonLicz_Click);
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.Enabled = false;
            this.textBoxWynik.Location = new System.Drawing.Point(67, 153);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.Size = new System.Drawing.Size(185, 20);
            this.textBoxWynik.TabIndex = 6;
            // 
            // labelBlad
            // 
            this.labelBlad.AutoSize = true;
            this.labelBlad.ForeColor = System.Drawing.Color.Red;
            this.labelBlad.Location = new System.Drawing.Point(14, 188);
            this.labelBlad.Name = "labelBlad";
            this.labelBlad.Size = new System.Drawing.Size(0, 13);
            this.labelBlad.TabIndex = 7;
            // 
            // listBoxDzialanie
            // 
            this.listBoxDzialanie.FormattingEnabled = true;
            this.listBoxDzialanie.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.listBoxDzialanie.Location = new System.Drawing.Point(66, 57);
            this.listBoxDzialanie.Name = "listBoxDzialanie";
            this.listBoxDzialanie.Size = new System.Drawing.Size(186, 56);
            this.listBoxDzialanie.TabIndex = 8;
            this.listBoxDzialanie.SelectedIndexChanged += new System.EventHandler(this.buttonLicz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(266, 220);
            this.Controls.Add(this.listBoxDzialanie);
            this.Controls.Add(this.labelBlad);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.textBoxLiczba2);
            this.Controls.Add(this.textBoxLiczba1);
            this.Controls.Add(this.buttonLicz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLicz;
        private System.Windows.Forms.TextBox textBoxLiczba1;
        private System.Windows.Forms.TextBox textBoxLiczba2;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.Label labelBlad;
        private System.Windows.Forms.ListBox listBoxDzialanie;
    }
}

