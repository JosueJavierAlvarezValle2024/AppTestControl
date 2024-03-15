namespace AppTestControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("How are you?");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "You are a Man";

            }
            else
            {
                label1.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label1.Text = "You're a Women";

            }
            else
            {
                label1.Text = "";
            }

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Favoritefoods.Items.Add(txtfood.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("cmd", $"/c start {"https://youtube.com"}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(DoWork);
            thread.Start();
        }

        private void DoWork()
        {
            
            for (int i = 0; i <= 100; i++)
            {
                
                UpdateProgressBar(i);

                
                Thread.Sleep(50);
            }
        }

        private void UpdateProgressBar(int value)
        {
            
            if (progressBar1.InvokeRequired)
            {
                
                progressBar1.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                
                progressBar1.Value = value;
            }
        }
    }

}

