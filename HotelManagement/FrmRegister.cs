using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRedirectLogIn_Click(object sender, EventArgs e)
        {
            pnlLogIn.Visible = true;
        }

        private void btnRedirectSignUp_Click(object sender, EventArgs e)
        {
            pnlLogIn.Visible = false;
        }
    }
}
