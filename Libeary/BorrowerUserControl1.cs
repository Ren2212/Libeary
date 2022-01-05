using System;
using System.Windows.Forms;

namespace Libeary
{
    public partial class BorrowerUserControl1 : UserControl
    {
        private static BorrowerUserControl1 _instance;

        public static BorrowerUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BorrowerUserControl1();

                }
                return _instance;
            }
        }
        public BorrowerUserControl1()
        {
            InitializeComponent();
        }

        private void BorrowerUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
