using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace wx_dat2img
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;    //设置不是顶级窗口
            childForm.FormBorderStyle = FormBorderStyle.None;  //去掉边框
            childForm.Dock = DockStyle.Fill;   //填充整个容器
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openChildForm(new frm_wxdatdir());
        }

        private void btn_deldat_Click(object sender, EventArgs e)
        {
            btn_deldat.Checked = !btn_deldat.Checked;
            if (btn_deldat.Checked)
            {
                Decrypt.deldat = true;
            }
            else
            {
                Decrypt.deldat = false;
            }
        }
        private void 开始转换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            开始转换ToolStripMenuItem.Enabled = false;
            openChildForm(new frm_Decrypt());
        }

        private void 重新选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Decrypt.datDir.Clear();
            openChildForm(new frm_wxdatdir());
            开始转换ToolStripMenuItem.Enabled = true;
        }
    }
}
