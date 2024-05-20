namespace Memoria
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(160, 13);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(281, 26);
            label1.TabIndex = 2;
            label1.Text = "jó próbálkozások száma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(161, 111);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(319, 26);
            label2.TabIndex = 3;
            label2.Text = "rossz probálkozások száma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(482, 13);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 26);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(490, 111);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(81, 26);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(88, 39);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 26);
            label5.TabIndex = 6;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(97, 314);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 26);
            label6.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Snap ITC", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(202, 297);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(219, 43);
            button1.TabIndex = 8;
            button1.Text = "Könnyű (2x4)";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Snap ITC", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(202, 377);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(219, 43);
            button2.TabIndex = 9;
            button2.Text = "Közepes (4x4)";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Snap ITC", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(202, 470);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(219, 43);
            button3.TabIndex = 10;
            button3.Text = "Nehéz (5x4)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(161, 209);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(296, 26);
            label7.TabIndex = 11;
            label7.Text = "Válassz nehézségi szintet!";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(160, 364);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 320);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(160, 61);
            label8.Name = "label8";
            label8.Size = new Size(294, 26);
            label8.TabIndex = 13;
            label8.Text = "Jó próbálkozások aránya";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(482, 61);
            label9.Name = "label9";
            label9.Size = new Size(81, 26);
            label9.TabIndex = 14;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(161, 159);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(332, 26);
            label10.TabIndex = 15;
            label10.Text = "rossz probálkozások aránya";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(501, 159);
            label11.Name = "label11";
            label11.Size = new Size(86, 26);
            label11.TabIndex = 16;
            label11.Text = "label11";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 601);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
