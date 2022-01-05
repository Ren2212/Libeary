using System;
using System.Windows.Forms;

namespace Libeary
{
    public partial class AboutUserControl1 : UserControl
    {
        private static AboutUserControl1 _instance;

        public static AboutUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AboutUserControl1();

                }
                return _instance;
            }
        }
        public AboutUserControl1()
        {
            InitializeComponent();
        }

        private void AboutUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
