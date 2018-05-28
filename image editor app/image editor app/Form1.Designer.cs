namespace image_editor_app
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
            this.button1 = new System.Windows.Forms.Button();
            this.redbar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brightnessbar = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.contrastbar = new System.Windows.Forms.TrackBar();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button17 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessbar)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastbar)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(18, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "None";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // redbar
            // 
            this.redbar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.redbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redbar.Location = new System.Drawing.Point(62, 34);
            this.redbar.Maximum = 100;
            this.redbar.Name = "redbar";
            this.redbar.Size = new System.Drawing.Size(431, 45);
            this.redbar.TabIndex = 11;
            this.redbar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bluebar);
            this.panel1.Controls.Add(this.greenbar);
            this.panel1.Controls.Add(this.redbar);
            this.panel1.Location = new System.Drawing.Point(123, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 132);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Custom RGB";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Blue";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Green";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Red";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bluebar
            // 
            this.bluebar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bluebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bluebar.Location = new System.Drawing.Point(62, 102);
            this.bluebar.Maximum = 100;
            this.bluebar.Name = "bluebar";
            this.bluebar.Size = new System.Drawing.Size(431, 45);
            this.bluebar.TabIndex = 13;
            this.bluebar.ValueChanged += new System.EventHandler(this.trackBar3_ValueChanged);
            // 
            // greenbar
            // 
            this.greenbar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.greenbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.greenbar.Location = new System.Drawing.Point(62, 68);
            this.greenbar.Maximum = 100;
            this.greenbar.Name = "greenbar";
            this.greenbar.Size = new System.Drawing.Size(431, 45);
            this.greenbar.TabIndex = 12;
            this.greenbar.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Location = new System.Drawing.Point(630, 395);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 120);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Browse Image";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Pink;
            this.button12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button12.Location = new System.Drawing.Point(7, 50);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(57, 55);
            this.button12.TabIndex = 15;
            this.button12.Text = "Open";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Pink;
            this.button11.Location = new System.Drawing.Point(80, 50);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(57, 55);
            this.button11.TabIndex = 14;
            this.button11.Text = "Save";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Khaki;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 31);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filters";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.YellowGreen;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(775, 31);
            this.label6.TabIndex = 18;
            this.label6.Text = "IMAGE EDITOR";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(2, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(115, 467);
            this.panel3.TabIndex = 19;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Pink;
            this.button10.Location = new System.Drawing.Point(18, 423);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(81, 36);
            this.button10.TabIndex = 26;
            this.button10.Text = "Spike";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Pink;
            this.button9.Location = new System.Drawing.Point(18, 381);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 36);
            this.button9.TabIndex = 25;
            this.button9.Text = "Frozen";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Pink;
            this.button8.Location = new System.Drawing.Point(18, 339);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 36);
            this.button8.TabIndex = 24;
            this.button8.Text = "Kakao";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Pink;
            this.button7.Location = new System.Drawing.Point(18, 297);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 36);
            this.button7.TabIndex = 23;
            this.button7.Text = "Gray";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Pink;
            this.button6.Location = new System.Drawing.Point(18, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 36);
            this.button6.TabIndex = 22;
            this.button6.Text = "Artistic";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Pink;
            this.button5.Location = new System.Drawing.Point(18, 213);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 36);
            this.button5.TabIndex = 21;
            this.button5.Text = "Dramatic";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Pink;
            this.button4.Location = new System.Drawing.Point(18, 169);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(81, 36);
            this.button4.TabIndex = 20;
            this.button4.Text = "Flash";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.Location = new System.Drawing.Point(18, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "Suji";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Location = new System.Drawing.Point(18, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 36);
            this.button2.TabIndex = 18;
            this.button2.Text = "Sepia";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::image_editor_app.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(123, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // brightnessbar
            // 
            this.brightnessbar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.brightnessbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brightnessbar.Location = new System.Drawing.Point(4, 31);
            this.brightnessbar.Maximum = 50;
            this.brightnessbar.Name = "brightnessbar";
            this.brightnessbar.Size = new System.Drawing.Size(140, 45);
            this.brightnessbar.TabIndex = 20;
            this.brightnessbar.ValueChanged += new System.EventHandler(this.brightnessbar_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.brightnessbar);
            this.panel4.Location = new System.Drawing.Point(630, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(147, 79);
            this.panel4.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Brightness";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Khaki;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.contrastbar);
            this.panel5.Location = new System.Drawing.Point(630, 118);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(147, 79);
            this.panel5.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Contrast";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrastbar
            // 
            this.contrastbar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.contrastbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contrastbar.Location = new System.Drawing.Point(4, 31);
            this.contrastbar.Maximum = 50;
            this.contrastbar.Name = "contrastbar";
            this.contrastbar.Size = new System.Drawing.Size(140, 45);
            this.contrastbar.TabIndex = 20;
            this.contrastbar.ValueChanged += new System.EventHandler(this.contrastbar_ValueChanged);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Pink;
            this.button13.Location = new System.Drawing.Point(80, 40);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(57, 36);
            this.button13.TabIndex = 31;
            this.button13.Text = "Rotate Right";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Pink;
            this.button14.Location = new System.Drawing.Point(7, 40);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(57, 36);
            this.button14.TabIndex = 32;
            this.button14.Text = "Rotate Left";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Khaki;
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.button14);
            this.panel7.Controls.Add(this.button13);
            this.panel7.Location = new System.Drawing.Point(630, 200);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(147, 79);
            this.panel7.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Rotate Image";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Khaki;
            this.panel6.Controls.Add(this.button16);
            this.panel6.Controls.Add(this.button15);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(630, 282);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(147, 79);
            this.panel6.TabIndex = 31;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Pink;
            this.button16.Location = new System.Drawing.Point(80, 40);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(57, 36);
            this.button16.TabIndex = 33;
            this.button16.Text = "Up Down";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Pink;
            this.button15.Location = new System.Drawing.Point(7, 40);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(63, 36);
            this.button15.TabIndex = 33;
            this.button15.Text = "Left Right";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 29;
            this.label11.Text = "Flip Image";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Pink;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(637, 367);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(130, 25);
            this.button17.TabIndex = 34;
            this.button17.Text = "Undo All Changes";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 515);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Quick Image Editing Application";
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessbar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrastbar)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar brightnessbar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar contrastbar;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}

