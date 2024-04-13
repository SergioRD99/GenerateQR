namespace WinQR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btn_generateQR = new Button();
            btn_guardar = new Button();
            panel1 = new Panel();
            PBQR = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBQR).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 27);
            textBox1.TabIndex = 0;
            // 
            // btn_generateQR
            // 
            btn_generateQR.Location = new Point(497, 37);
            btn_generateQR.Name = "btn_generateQR";
            btn_generateQR.Size = new Size(191, 29);
            btn_generateQR.TabIndex = 1;
            btn_generateQR.Text = "Genrar QR";
            btn_generateQR.UseVisualStyleBackColor = true;
            btn_generateQR.Click += btn_generateQR_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(497, 72);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(191, 29);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(PBQR);
            panel1.Location = new Point(52, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 303);
            panel1.TabIndex = 3;
            // 
            // PBQR
            // 
            PBQR.Location = new Point(30, 18);
            PBQR.Name = "PBQR";
            PBQR.Size = new Size(569, 269);
            PBQR.TabIndex = 0;
            PBQR.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btn_guardar);
            Controls.Add(btn_generateQR);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_generateQR;
        private Button btn_guardar;
        private Panel panel1;
        private PictureBox PBQR;
    }
}
