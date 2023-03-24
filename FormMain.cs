using CommonToolWin.Await;
using CommonToolWin.HomePage;
using CommonToolWin.Plan;
using CommonToolWin.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonToolWin
{
    public partial class FormMain : Form
    {
        bool sidebarExpand;
        public FormMain()
        {
            
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            //sidebar.BackColor = Color.Red;
            sidebar.BackColor = Color.FromArgb(0,77, 255);
         
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //判断宽度
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width = 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }

            }
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string date = DateTime.Now.Year.ToString() + "年" +
            //DateTime.Now.Month.ToString() + "月" +
            //DateTime.Now.Day.ToString() + "日";
            //string dayOfWeek = DateTime.Now.DayOfWeek.ToString();
            //string timeOfDay = DateTime.Now.ToString();
            //this.labelTime.Text = "当前时间：" + date + "  " + dayOfWeek + "  " + timeOfDay;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            sidebar.BackColor = Color.FromArgb(64, 58, 128);
            panelHeader.BackColor = Color.FromArgb(64, 58, 128);
            FormMain main = new FormMain();
            main.BackColor = Color.FromArgb(64, 58, 128);
            //清空数据
            FormHomePage form = new FormHomePage();
            panelMain.Controls.Clear(); //移除所有控件
            form.TopLevel = false;  //设置为非顶级窗体
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            form.Dock = System.Windows.Forms.DockStyle.Fill;//设置样式是否填充整个panel
            panelMain.Controls.Add(form);//添加窗体
            form.Show();//窗体运行
        }

        private void buttonTools_Click(object sender, EventArgs e)
        {
            sidebar.BackColor = Color.Black;
            panelHeader.BackColor = Color.Black;
            FormMain main = new FormMain();
            main.BackColor = Color.Black;
            //清空数据
            FormToolMain form = new FormToolMain();
            panelMain.Controls.Clear(); //移除所有控件
            form.TopLevel = false;  //设置为非顶级窗体
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            form.Dock = System.Windows.Forms.DockStyle.Fill;//设置样式是否填充整个panel
            panelMain.Controls.Add(form);//添加窗体
            form.Show();//窗体运行
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override CreateParams CreateParams  
         {  
            get  
            {  
                CreateParams cp = base.CreateParams;  
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED    
                if (this.IsXpOr2003 == true)  
                {
                     cp.ExStyle |= 0x00080000;  // Turn on WS_EX_LAYERED  
                     this.Opacity = 1;
                }  
                return cp;  
            } 
        }  //防止闪烁  
  
        private Boolean IsXpOr2003
        {  
            get  
            {  
                OperatingSystem os = Environment.OSVersion;  
                Version vs = os.Version;  
  
                if (os.Platform == PlatformID.Win32NT)  
                    if ((vs.Major == 5) && (vs.Minor != 0))  
                        return true;  
                    else  
                        return false;  
                else  
                    return false;  
            }
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            sidebar.BackColor = Color.FromArgb(65, 116, 97);
            panelHeader.BackColor = Color.FromArgb(65, 116, 97);
            FormMain main = new FormMain();
            main.BackColor = Color.FromArgb(65, 116, 97);
            //清空数据
            FormPlan form = new FormPlan();
            panelMain.Controls.Clear(); //移除所有控件
            form.TopLevel = false;  //设置为非顶级窗体
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            form.Dock = System.Windows.Forms.DockStyle.Fill;//设置样式是否填充整个panel
            panelMain.Controls.Add(form);//添加窗体
            form.Show();//窗体运行
        }

        private void buttonAwait_Click(object sender, EventArgs e)
        {
            sidebar.BackColor = Color.FromArgb(56, 40, 102);
            panelHeader.BackColor = Color.FromArgb(56, 40, 102);
            FormMain main = new FormMain();
            main.BackColor = Color.FromArgb(56, 40, 102);
            //清空数据
            FormAwait form = new FormAwait();
            panelMain.Controls.Clear(); //移除所有控件
            form.TopLevel = false;  //设置为非顶级窗体
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//设置窗体为非边框样式
            form.Dock = System.Windows.Forms.DockStyle.Fill;//设置样式是否填充整个panel
            panelMain.Controls.Add(form);//添加窗体
            form.Show();//窗体运行

        }
    }
}
