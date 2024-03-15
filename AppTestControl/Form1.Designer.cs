namespace AppTestControl
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
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            Favoritefoods = new CheckedListBox();
            txtfood = new TextBox();
            btnadd = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            monthCalendar1 = new MonthCalendar();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(25, 12);
            button1.Name = "button1";
            button1.Size = new Size(167, 60);
            button1.TabIndex = 0;
            button1.Text = "HELLO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(25, 89);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "You are a Men";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(25, 119);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(139, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "You´re a Women";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 146);
            label1.Name = "label1";
            label1.Size = new Size(33, 27);
            label1.TabIndex = 3;
            label1.Text = "...";
            // 
            // Favoritefoods
            // 
            Favoritefoods.CheckOnClick = true;
            Favoritefoods.FormattingEnabled = true;
            Favoritefoods.Items.AddRange(new object[] { "Pizza", "Hamburger", "Tacos", "Chicken", "Hot Dog", "Birria", "Spaguetti" });
            Favoritefoods.Location = new Point(810, 80);
            Favoritefoods.Name = "Favoritefoods";
            Favoritefoods.Size = new Size(184, 202);
            Favoritefoods.TabIndex = 4;
            // 
            // txtfood
            // 
            txtfood.Location = new Point(825, 288);
            txtfood.Name = "txtfood";
            txtfood.Size = new Size(153, 27);
            txtfood.TabIndex = 5;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(830, 321);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(148, 36);
            btnadd.TabIndex = 6;
            btnadd.Text = "ADD";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(731, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(611, 30);
            label2.Name = "label2";
            label2.Size = new Size(105, 31);
            label2.TabIndex = 8;
            label2.Text = "Today is:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(29, 465);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Youtube";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(16, 196);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(25, 488);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(16, 415);
            button2.Name = "button2";
            button2.Size = new Size(124, 37);
            button2.TabIndex = 12;
            button2.Text = "Start";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(172, 420);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(822, 25);
            progressBar1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ftoP;
            pictureBox1.Location = new Point(348, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 339);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(1030, 581);
            Controls.Add(pictureBox1);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(monthCalendar1);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnadd);
            Controls.Add(txtfood);
            Controls.Add(Favoritefoods);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private CheckedListBox Favoritefoods;
        private TextBox txtfood;
        private Button btnadd;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private LinkLabel linkLabel1;
        private MonthCalendar monthCalendar1;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private ProgressBar progressBar1;
        private PictureBox pictureBox1;
    }
}
