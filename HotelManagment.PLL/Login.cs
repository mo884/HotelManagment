using HotelManagment.BLL.Feature.Login.Command.Interface;
using HotelManagment.BLL.Feature.Login.Command.ModelVM;
using HotelManagment.BLL.Feature.Login.Command.Reposoratory;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using MetroFramework.Forms;

namespace HotelManagment.PLL
{
    public partial class Login : Form
    {
        ILoginRep loginRep;
        public Login()
        {
            InitializeComponent();
            loginRep = new LoginRep();
            PasswordtextBox.PasswordChar = '*';

        }


        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoginVM loginVM = new LoginVM() { UserName =this.UserNametextBox.Text, Password=this.PasswordtextBox.Text };
                var AuthenticateUser = loginRep.AuthenticateUser(loginVM);
                if (AuthenticateUser!=null)
                {
                    if (AuthenticateUser =="Frontend")
                    {
                        this.Hide();
                        FrontEndUI frontEnd = new();

                        frontEnd.ShowDialog();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                UserNametextBox.Text ="";
                PasswordtextBox.Text = "";


            }

        }
        private void usernameTextBox_Click(object sender, EventArgs e)
        {

            if (UserNametextBox.Text == string.Empty)
            {
                Userlabel.Visible = true;
            }
            if (UserNametextBox.Text != "Username" && UserNametextBox.Text != string.Empty)
            {
                Userlabel.Visible = false;
            }
        }
        private void passwordTextBox_Click(object sender, EventArgs e)
        {

            if (PasswordtextBox.Text == string.Empty)
            {
                Passwordlabel.Visible = true;
            }
            if (PasswordtextBox.Text != "Password" && PasswordtextBox.Text != string.Empty)
            {
                Passwordlabel.Visible = false;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!UserNametextBox.Bounds.Contains(e.Location) && UserNametextBox.Text == string.Empty)
            {
                Userlabel.Visible = false;
            }
            if (!PasswordtextBox.Bounds.Contains(e.Location) && PasswordtextBox.Text == string.Empty)
            {
                Passwordlabel.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
