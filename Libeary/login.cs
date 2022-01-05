using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Libeary
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataReader dr;
        private string getUserName()
        {
            //fetch data from the database
            con.Open();
            string syntex = "SELECT Value FROM systemTable where Property=UserName";
            cmd = new SqlCommand(syntex, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private string getPassword()
        {
            //fetch data from the database
            con.Open();
            string syntex = "SELECT Value FROM systemTable where Property=Password";
            cmd = new SqlCommand(syntex, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string temp = dr[0].ToString();
            con.Close();
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = getUserName(), upass = getPassword(), name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if (name.Equals(uname) && pass.Equals(upass))
            {
                //login
                label3.Hide();
                AppBody obj = new AppBody();
                this.Hide();
                obj.Show();
            }
            else
            {
                //don't login
                label3.Show();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
