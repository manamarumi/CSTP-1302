using System.Windows.Forms;

namespace lab4_2
{
  
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            Boolean lightON = true;
            private void pictureBox2_Click(object sender, EventArgs e)
            {

            }
                   

            private void Form1_Load(object sender, EventArgs e)
            {
                flip();
            }

            private void flip()
            {
                if (lightON)
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    label2.Text = "ON";

            }
                else
                {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    label2.Text = "OFF";
                }
            }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            lightON = !lightON;
            flip();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
