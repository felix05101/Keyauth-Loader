using Loader;
using System;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using ICSharpCode.SharpZipLib.Zip;






namespace KeyAuth
{
    public partial class Login : Form
    {


        //Replace with your C# credentials from keyauth.win
        public static api KeyAuthApp = new api(
            name: "",
            ownerid: "",
            secret: "",
            version: ""
        );

        public Login()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        

        
        private void Login_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();

            
            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }

            KeyAuthApp.check();

        }

        static string random_string()
        {
            string str = null;

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                str += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
            }
            return str;

        }



        private void LoginBtn_Click(object sender, EventArgs e)
        {

        }

        private void RgstrBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(username.Text, password.Text, key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }


        }

        private void LicBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }

        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }



        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {

            this.Size = new Size(247, 197);

            key.Visible = true;
            textBox4.Visible = false;
            button2.Visible = false;
            textBox6.Visible = true;
            key.Visible = true;
            register.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;

        }



        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(username.Text, password.Text, key.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void key_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}