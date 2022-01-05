using System;
using System.Windows.Forms;

namespace Libeary
{
    public partial class AppBody : Form
    {
        public AppBody()
        {
            InitializeComponent();
            //initialization for sliding panel
            isSlidingpanelExpanded = true;
            expandingSlidingPanelGUI();
        }

        public void expandingSlidingPanelGUI()
        {
            //gui adjustments for expanding
            bookstabbutton.Text = "BOOKS";
            borrowerstabbutton.Text = "BORROWERS";
            transactiontabbutton.Text = "TRANSACTION";
            settingtabbutton.Text = "SETTING";
            aboutabbutton.Text = "ABOUT";

            bookstabbutton.Image = null;
            borrowerstabbutton.Image = null;
            transactiontabbutton.Image = null;
            settingtabbutton.Image = null;
            aboutabbutton.Image = null;
        }

        public void retractSlidingPanelGUI()
        {
            //gui adjustments for retracting
            bookstabbutton.Text = "";
            borrowerstabbutton.Text = "";
            transactiontabbutton.Text = "";
            settingtabbutton.Text = "";
            aboutabbutton.Text = "";

            bookstabbutton.Image = Properties.Resources.open_book__1_;
            borrowerstabbutton.Image = Properties.Resources.borrow;
            transactiontabbutton.Image = Properties.Resources.transaction;
            settingtabbutton.Image = Properties.Resources.setting;
            aboutabbutton.Image = Properties.Resources.info;
        }

        //sliding panel code
        bool isSlidingpanelExpanded;
        const int MaxSliderWidth=300;
        const int MinSliderWidth=100;

        private void slidingpanel_togglebutton_Click(object sender, EventArgs e)
        {
            if (isSlidingpanelExpanded)
            {
                //retract panel
                retractSlidingPanelGUI();
            }
            slidingpanel_timer.Start();
        }

        private void slidingpanel_timer_Tick(object sender, EventArgs e)
        {
            if (isSlidingpanelExpanded)
            {
                //retract panel
                slidingpanel.Width -=30;
                if(slidingpanel.Width<=MinSliderWidth)
                {
                    //stop retract
                    isSlidingpanelExpanded = false;
                    slidingpanel_timer.Stop();
                    expandingSlidingPanelGUI();
                    this.Refresh();
                }
            }
            else
            {
                //expand panel
                slidingpanel.Width +=30;
                if (slidingpanel.Width >= MaxSliderWidth)
                {
                    //stop expanding
                    isSlidingpanelExpanded = true;
                    slidingpanel_timer.Stop();

                    this.Refresh();
                }
            }
        }

        private void slidingpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(TransactionUserControl1.Instance))
            {
                contentpanel.Controls.Add(TransactionUserControl1.Instance);
                TransactionUserControl1.Instance.Dock = DockStyle.Fill;
                TransactionUserControl1.Instance.BringToFront();
            }
            else
            {
                TransactionUserControl1.Instance.BringToFront();
            }

        }

        private void borrowerstabbutton_Click(object sender, EventArgs e)
        {
            if (! contentpanel.Controls.Contains(BorrowerUserControl1.Instance))
            {
                contentpanel.Controls.Add(BorrowerUserControl1.Instance);
                BorrowerUserControl1.Instance.Dock = DockStyle.Fill;
                BorrowerUserControl1.Instance.BringToFront();
            }
            else
            {
                BorrowerUserControl1.Instance.BringToFront();
            }
        }

        private void bookstabbutton_Click(object sender, EventArgs e)
        {
            if(! contentpanel.Controls.Contains(BooksUserControl1.Instance))
            {
                contentpanel.Controls.Add(BooksUserControl1.Instance);
                BooksUserControl1.Instance.Dock = DockStyle.Fill;
                BooksUserControl1.Instance.BringToFront();
            }
            else
            {
                BooksUserControl1.Instance.BringToFront();
            }
        }

        private void settingtabbutton_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(SettingUserControl1.Instance))
            {
                contentpanel.Controls.Add(SettingUserControl1.Instance);
                SettingUserControl1.Instance.Dock = DockStyle.Fill;
                SettingUserControl1.Instance.BringToFront();
            }
            else
            {
                SettingUserControl1.Instance.BringToFront();
            }

        }

        private void aboutabbutton_Click(object sender, EventArgs e)
        {
            if (!contentpanel.Controls.Contains(AboutUserControl1.Instance))
            {
                contentpanel.Controls.Add(AboutUserControl1.Instance);
                AboutUserControl1.Instance.Dock = DockStyle.Fill;
                AboutUserControl1.Instance.BringToFront();
            }
            else
            {
                AboutUserControl1.Instance.BringToFront();
            }

        }

        private void AppBody_Load(object sender, EventArgs e)
        {

        }
    }
}
