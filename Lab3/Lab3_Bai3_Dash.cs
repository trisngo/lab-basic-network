using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace lab3
{
    public partial class Lab3_Bai3_Dash : Form
    {
        
        public Lab3_Bai3_Dash()
        {
            InitializeComponent();
        }

        private void buttonOServer_Click(object sender, EventArgs e)
        {
            new Lab3_Bai3_Ser().Show();
        }

        private void buttonOClient_Click(object sender, EventArgs e)
        {
            new Lab3_Bai3_Cli().Show();
        }
    }
}
