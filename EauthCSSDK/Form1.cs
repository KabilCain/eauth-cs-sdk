namespace EauthCSSDK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Eauth eauth = new Eauth(); //  Eauth Required

        // Webhook request
        /*string response = await eauth.WebhookRequest("webhook name", "&param=&s=", "body", "application/json");*/

        // Download file
        /*
        if (await eauth.DownloadRequest("fileID", "./path", "name.format")) // (example) name.format: name.exe
        {
            MessageBox.Show("The file has been successfully downloaded.");
        }
        else
        {
            MessageBox.Show(Eauth.errorMessage);
        }
        */

        // Upgrade a user
        /*
        if (await eauth.UpgradeRequest("username", "key"))
        {
            MessageBox.Show("The user subscription upgraded.");
        }
        else
        {
            MessageBox.Show(Eauth.errorMessage);
        }
        */

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Required Eauth funtion (always the first thing to run)
            if (await eauth.InitRequest() == false)
            {
                MessageBox.Show(Eauth.errorMessage);
                Environment.Exit(1);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (await eauth.LoginRequest(textBox1.Text, textBox2.Text, ""))
            {
                // Code block executed if credentials are valid:
                MessageBox.Show("You have logged in successfully."
                    + "\n " + "Rank: " + Eauth.userRank
                    + "\n " + "Hardware-ID: " + Eauth.userHwid
                    + "\n " + "Register Date: " + Eauth.registerDate
                    + "\n " + "Expire Date: " + Eauth.expireDate);
            }
            else
            {
                MessageBox.Show(Eauth.errorMessage);
            }
            button1.Enabled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (await eauth.LoginRequest("", "", textBox3.Text))
            {
                // Code block executed if credentials are valid:
                MessageBox.Show("You have logged in successfully."
                    + "\n " + "Rank: " + Eauth.userRank
                    + "\n " + "Hardware-ID: " + Eauth.userHwid
                    + "\n " + "Register Date: " + Eauth.registerDate
                    + "\n " + "Expire Date: " + Eauth.expireDate);
            }
            else
            {
                MessageBox.Show(Eauth.errorMessage);
            }
            button2.Enabled = true;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (await eauth.RegisterRequest(textBox5.Text, textBox4.Text, textBox6.Text, textBox7.Text))
            {
                // Code block executed if credentials are valid:
                MessageBox.Show("You have registered successfully.");
            }
            else
            {
                MessageBox.Show(Eauth.errorMessage);
            }
            button3.Enabled = true;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (await eauth.ResetPasswordRequest(textBox8.Text))
            {
                // Code block executed if credentials are valid:
                MessageBox.Show("An e-mail has been sent to you.");
            }
            else
            {
                MessageBox.Show(Eauth.errorMessage);
            }
            button4.Enabled = true;
        }
    }
}
