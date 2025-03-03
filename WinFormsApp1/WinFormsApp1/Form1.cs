using Microsoft.Win32;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.UserText;

            button1.Click += button1_Click;



            this.Width = 1000;
            this.Height = 1000;
            this.BackgroundImage = Image.FromFile("H:\\”œ21\\unnamed.jpg");

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ﬂﬂﬂﬂﬂ ’Œ¡√Œ¡À»Õ ’¿ ’¿ ’¿ ’¿");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserText = textBox1.Text;
            Properties.Settings.Default.Save();
        }

        
    }

}
