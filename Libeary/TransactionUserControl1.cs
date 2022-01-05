using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Libeary
{
    public partial class TransactionUserControl1 : UserControl
    {
        private static TransactionUserControl1 _instance;

        public static TransactionUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TransactionUserControl1();

                }
                return _instance;
            }
        }
        public TransactionUserControl1()
        {
            InitializeComponent();
        }

        public string Book1, Book2, Borrower;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        public SqlCommand cmd;
        public SqlDataReader dr;

        private void boocksearchbar_Click(object sender, EventArgs e)
        {
            //to get to borrowed by
            con.Open();
            string syntax = "SELECT Borrowers FROM Books where BrId=" + accnosearchbar.Text;
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            bookborrowedby.Text = Borrower = dr[0].ToString();
            con.Close();
        }

        private void issuebooksearch_Click(object sender, EventArgs e)
        {
            //see if the book is borrowed by someone
            boocksearchbar.PerformClick();
            if (Borrower != "")
            {
                //someone has borrowed the book
                MessageBox.Show("Book is already borrowed by some other Borrower with borrower id : \n" + Borrower);
                return;
            }
            //see if borrower has already taken two books
            borrowersearchbutton.PerformClick();
            if ((Book1 !="") && (Book2 !=""))
            {
                //borrower has already borrowed maximum number of books
                MessageBox.Show("Borrower has already maximum number of books");
                return;
            }
            //all is ok to continue issue proccess
            //fisrt set the value of book1 or book2 as the accno of the book being issued
            try
            {
                if(Book1 =="")
                {
                    //accno must be updated in the book1 slot
                    cmd = new SqlCommand("Transaction_Update_Book1_SP", con);

                }
                else
                {
                    //accno must be updated in the book2 slot
                    cmd = new SqlCommand("Transaction_Update_Book2_SP", con);
                }
                cmd.CommandType = CommandType.StoreProcedure;

                cmd.Parameters.AddWithValue("@accNo", accnosearchbar.Text);
                cmd.Parameters.AddWithValue("@brid", boocksearchbar.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<Invalid SQL Operation>>>: \n" + ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }

            //now we also update the borrower's id in the book table

            cmd = new SqlCommand("Transaction_Update_Browwer_SP", con);
            cmd.CommandType = CommandType.StoredProduct;

            cmd.Parameters.AddWithValue("@accNo", accnosearchbar.Text);
            cmd.Parameters.AddWithValue("@brid", boocksearchbar.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("   <<<Invalid SQL Operation>>>: \n" + ex);
            }
            con.Close();

            //this compleates the entire transaction
            //now to update the values, perform click event on both the buttons so user can see the changes made

            borrowersearchbutton.PerformClick();
            boocksearchbar.PerformClick();
            MessageBox.Show("Sucessfully Issued");
        }

        private void borrowersearchtab_TextChanged(object sender, EventArgs e)
        {

        }

        private void returnbookbar_Click(object sender, EventArgs e)
        {
            //see if the book is borrowed by someone
            boocksearchbar.PerformClick();
            if ((accnosearchbar.Text != Book1) && (accnosearchbar.Text != Book2))
            {
                //someone has borrowed the book
                MessageBox.Show("The inputed borrower has not borrowed the inputed book : \n" + Borrower);
                return;
            }

            //all is ok to continue return proccess
            //fisrt set the value of book1 or book2 as null of the book being returned
            try
            {
                if (Book1 == accnosearchbar.Text )
                {
                    //accno must be updated in the book1 slot
                    cmd = new SqlCommand("Transaction_Update_Book1_SP", con);

                }
                else
                {
                    //accno must be updated in the book2 slot
                    cmd = new SqlCommand("Transaction_Update_Book2_SP", con);
                }
                cmd.CommandType = CommandType.StoreProcedure;

                cmd.Parameters.AddWithValue("@accNo", (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@brid", boocksearchbar.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("    <<<Invalid SQL Operation>>>: \n" + ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            //now we also update the borrower's id in the book table

            cmd = new SqlCommand("Transaction_Update_Browwer_SP", con);
            cmd.CommandType = CommandType.StoredProduct;

            cmd.Parameters.AddWithValue("@accNo", accnosearchbar.Text);
            cmd.Parameters.AddWithValue("@brid", (object)DBNull.Value);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("   <<<Invalid SQL Operation>>>: \n" + ex);
            }
            con.Close();

            //this compleates the entire transaction
            //now to update the values, perform click event on both the buttons so user can see the changes made

            borrowersearchbutton.PerformClick();
            boocksearchbar.PerformClick();
            MessageBox.Show("Sucessfully Returned");
        }

        private void TransactionUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void borrowersearchbutton_Click(object sender, EventArgs e)
        {
            //to get book 1
            con.Open();
            string syntax = "SELECT Book1 FROM Borrowers where accNo=" +borrowersearchbutton.Text;
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            borrowedbook1.Text=Book1=dr[0].ToString();
            con.Close();
            //to get book 2
            con.Open();
            syntax = "SELECT Book2 FROM Borrowers where BrId=" + borrowersearchbutton.Text;
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            borrowerbook2.Text = Book2 = dr[0].ToString();
            con.Close();

        }
    }
}
