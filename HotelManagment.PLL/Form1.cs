using MetroFramework.Forms;

namespace HotelManagment.PLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Username or Password is wrong, try again", "Login Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

        }
    }
}
