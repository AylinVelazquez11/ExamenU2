namespace ExamenU2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn1i = new System.Windows.Forms.Button();
            this.btn2G = new System.Windows.Forms.Button();
            this.btn3P = new System.Windows.Forms.Button();
            this.pictureBoxN = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtbR = new System.Windows.Forms.TextBox();
            this.txtbB = new System.Windows.Forms.TextBox();
            this.txtbG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(208, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btn1i
            // 
            this.btn1i.Location = new System.Drawing.Point(23, 27);
            this.btn1i.Name = "btn1i";
            this.btn1i.Size = new System.Drawing.Size(91, 46);
            this.btn1i.TabIndex = 1;
            this.btn1i.Text = "Insertar imagen";
            this.btn1i.UseVisualStyleBackColor = true;
            this.btn1i.Click += new System.EventHandler(this.btn1i_Click);
            // 
            // btn2G
            // 
            this.btn2G.Location = new System.Drawing.Point(23, 89);
            this.btn2G.Name = "btn2G";
            this.btn2G.Size = new System.Drawing.Size(91, 45);
            this.btn2G.TabIndex = 2;
            this.btn2G.Text = "Guardar";
            this.btn2G.UseVisualStyleBackColor = true;
            this.btn2G.Click += new System.EventHandler(this.btn2G_Click);
            // 
            // btn3P
            // 
            this.btn3P.Location = new System.Drawing.Point(23, 150);
            this.btn3P.Name = "btn3P";
            this.btn3P.Size = new System.Drawing.Size(91, 42);
            this.btn3P.TabIndex = 3;
            this.btn3P.Text = "Pintar";
            this.btn3P.UseVisualStyleBackColor = true;
            this.btn3P.Click += new System.EventHandler(this.btn3P_Click);
            // 
            // pictureBoxN
            // 
            this.pictureBoxN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxN.Location = new System.Drawing.Point(23, 198);
            this.pictureBoxN.Name = "pictureBoxN";
            this.pictureBoxN.Size = new System.Drawing.Size(52, 48);
            this.pictureBoxN.TabIndex = 4;
            this.pictureBoxN.TabStop = false;
            this.pictureBoxN.Click += new System.EventHandler(this.pictureBoxN_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox2.Location = new System.Drawing.Point(23, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtbR
            // 
            this.txtbR.Location = new System.Drawing.Point(161, 198);
            this.txtbR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbR.Name = "txtbR";
            this.txtbR.Size = new System.Drawing.Size(28, 23);
            this.txtbR.TabIndex = 6;
            this.txtbR.Text = "0";
            // 
            // txtbB
            // 
            this.txtbB.Location = new System.Drawing.Point(161, 252);
            this.txtbB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbB.Name = "txtbB";
            this.txtbB.Size = new System.Drawing.Size(28, 23);
            this.txtbB.TabIndex = 7;
            this.txtbB.Text = "0";
            // 
            // txtbG
            // 
            this.txtbG.Location = new System.Drawing.Point(161, 225);
            this.txtbG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbG.Name = "txtbG";
            this.txtbG.Size = new System.Drawing.Size(28, 23);
            this.txtbG.TabIndex = 8;
            this.txtbG.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "R";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 326);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(166, 45);
            this.trackBar1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "label4";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*\"";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbG);
            this.Controls.Add(this.txtbB);
            this.Controls.Add(this.txtbR);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxN);
            this.Controls.Add(this.btn3P);
            this.Controls.Add(this.btn2G);
            this.Controls.Add(this.btn1i);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn1i;
        private Button btn2G;
        private Button btn3P;
        private PictureBox pictureBoxN;
        private PictureBox pictureBox2;
        private ColorDialog colorDialog1;
        private TextBox txtbR;
        private TextBox txtbB;
        private TextBox txtbG;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar trackBar1;
        private Label label4;
        private SaveFileDialog saveFileDialog1;
    }
}