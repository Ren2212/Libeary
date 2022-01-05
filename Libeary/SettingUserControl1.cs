using System;
using System.Windows.Forms;

namespace Libeary
{
    public partial class SettingUserControl1 : UserControl
    {
        private static SettingUserControl1 _instance;

        public static SettingUserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SettingUserControl1();

                }
                return _instance;
            }
        }
        public SettingUserControl1()
        {
            InitializeComponent();
        }

        private void SettingUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
