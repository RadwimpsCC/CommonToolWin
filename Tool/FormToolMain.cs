using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonToolWin.Tool
{
    public partial class FormToolMain : Form
    {
        public FormToolMain()
        {
            InitializeComponent();
        }

        private void buttonGetCpu_Click(object sender, EventArgs e)
        {
            FormToolGetCpu cpu=new FormToolGetCpu();
            cpu.Show();
        }
    }
}
