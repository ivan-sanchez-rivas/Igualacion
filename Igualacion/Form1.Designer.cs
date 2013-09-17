namespace Igualacion
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
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.txt_c = new System.Windows.Forms.TextBox();
            this.txt_c1 = new System.Windows.Forms.TextBox();
            this.txt_b1 = new System.Windows.Forms.TextBox();
            this.txt_a1 = new System.Windows.Forms.TextBox();
            this.lbl_x1 = new System.Windows.Forms.Label();
            this.lbl_x2 = new System.Windows.Forms.Label();
            this.lbl_y1 = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_resultadoX = new System.Windows.Forms.Label();
            this.lbl_resultadoY = new System.Windows.Forms.Label();
            this.btn_Cramer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(56, 12);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(29, 20);
            this.txt_a.TabIndex = 0;
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(109, 12);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(32, 20);
            this.txt_b.TabIndex = 1;
            // 
            // txt_c
            // 
            this.txt_c.Location = new System.Drawing.Point(168, 12);
            this.txt_c.Name = "txt_c";
            this.txt_c.Size = new System.Drawing.Size(30, 20);
            this.txt_c.TabIndex = 2;
            // 
            // txt_c1
            // 
            this.txt_c1.Location = new System.Drawing.Point(171, 49);
            this.txt_c1.Name = "txt_c1";
            this.txt_c1.Size = new System.Drawing.Size(30, 20);
            this.txt_c1.TabIndex = 5;
            // 
            // txt_b1
            // 
            this.txt_b1.Location = new System.Drawing.Point(109, 49);
            this.txt_b1.Name = "txt_b1";
            this.txt_b1.Size = new System.Drawing.Size(32, 20);
            this.txt_b1.TabIndex = 4;
            // 
            // txt_a1
            // 
            this.txt_a1.Location = new System.Drawing.Point(56, 49);
            this.txt_a1.Name = "txt_a1";
            this.txt_a1.Size = new System.Drawing.Size(29, 20);
            this.txt_a1.TabIndex = 3;
            // 
            // lbl_x1
            // 
            this.lbl_x1.AutoSize = true;
            this.lbl_x1.Location = new System.Drawing.Point(91, 15);
            this.lbl_x1.Name = "lbl_x1";
            this.lbl_x1.Size = new System.Drawing.Size(12, 13);
            this.lbl_x1.TabIndex = 6;
            this.lbl_x1.Text = "x";
            // 
            // lbl_x2
            // 
            this.lbl_x2.AutoSize = true;
            this.lbl_x2.Location = new System.Drawing.Point(91, 52);
            this.lbl_x2.Name = "lbl_x2";
            this.lbl_x2.Size = new System.Drawing.Size(12, 13);
            this.lbl_x2.TabIndex = 7;
            this.lbl_x2.Text = "x";
            // 
            // lbl_y1
            // 
            this.lbl_y1.AutoSize = true;
            this.lbl_y1.Location = new System.Drawing.Point(147, 52);
            this.lbl_y1.Name = "lbl_y1";
            this.lbl_y1.Size = new System.Drawing.Size(18, 13);
            this.lbl_y1.TabIndex = 8;
            this.lbl_y1.Text = "y=";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Location = new System.Drawing.Point(147, 15);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(18, 13);
            this.lbl_y.TabIndex = 9;
            this.lbl_y.Text = "y=";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(94, 86);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 12;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_resultadoX
            // 
            this.lbl_resultadoX.AutoSize = true;
            this.lbl_resultadoX.Location = new System.Drawing.Point(227, 95);
            this.lbl_resultadoX.Name = "lbl_resultadoX";
            this.lbl_resultadoX.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultadoX.TabIndex = 13;
            this.lbl_resultadoX.Text = "label1";
            // 
            // lbl_resultadoY
            // 
            this.lbl_resultadoY.AutoSize = true;
            this.lbl_resultadoY.Location = new System.Drawing.Point(227, 118);
            this.lbl_resultadoY.Name = "lbl_resultadoY";
            this.lbl_resultadoY.Size = new System.Drawing.Size(35, 13);
            this.lbl_resultadoY.TabIndex = 14;
            this.lbl_resultadoY.Text = "label2";
            // 
            // btn_Cramer
            // 
            this.btn_Cramer.Location = new System.Drawing.Point(109, 223);
            this.btn_Cramer.Name = "btn_Cramer";
            this.btn_Cramer.Size = new System.Drawing.Size(75, 23);
            this.btn_Cramer.TabIndex = 15;
            this.btn_Cramer.Text = "Cramer";
            this.btn_Cramer.UseVisualStyleBackColor = true;
            this.btn_Cramer.Click += new System.EventHandler(this.btn_Cramer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 316);
            this.Controls.Add(this.btn_Cramer);
            this.Controls.Add(this.lbl_resultadoY);
            this.Controls.Add(this.lbl_resultadoX);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_y1);
            this.Controls.Add(this.lbl_x2);
            this.Controls.Add(this.lbl_x1);
            this.Controls.Add(this.txt_c1);
            this.Controls.Add(this.txt_b1);
            this.Controls.Add(this.txt_a1);
            this.Controls.Add(this.txt_c);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.txt_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_c;
        private System.Windows.Forms.TextBox txt_c1;
        private System.Windows.Forms.TextBox txt_b1;
        private System.Windows.Forms.TextBox txt_a1;
        private System.Windows.Forms.Label lbl_x1;
        private System.Windows.Forms.Label lbl_x2;
        private System.Windows.Forms.Label lbl_y1;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_resultadoX;
        private System.Windows.Forms.Label lbl_resultadoY;
        private System.Windows.Forms.Button btn_Cramer;
    }
}

