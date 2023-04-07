using ProjetoIFSP.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIFSP
{
    public partial class pageMain : Form
    {
        public pageMain()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginPage _flogin;
            _flogin = new loginPage();
            _flogin.Show();
            Hide();
        }
    }
}
