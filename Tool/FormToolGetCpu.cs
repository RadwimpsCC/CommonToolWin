using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonToolWin.Tool
{
    public partial class FormToolGetCpu : Form
    {
        public FormToolGetCpu()
        {
            InitializeComponent();
        }

        private void FormToolGetCpu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            string cpuSerialNum = string.Empty;
            try
            {
                ManagementClass manc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection manoc = manc.GetInstances();
                foreach (ManagementObject mano in manoc)
                {
                    cpuSerialNum = mano["ProcessorId"].ToString();
                    break;
                }
                manc.Dispose();
                manoc.Dispose();
                txtCpu.Text=cpuSerialNum;   
            }
            catch (Exception ex)
            {

            }

        }
    }
}
