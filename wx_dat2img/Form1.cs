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

        private void btnStart_Click(object sender, EventArgs e)
        {

            btnStart.Enabled = false;

            checkedListBox1.Visible = false;

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                treeView1.Nodes.Add(checkedListBox1.CheckedItems[i].ToString());

                TreeNode rootNode = treeView1.Nodes[i];

                Convert dat2Img = new Convert();

                foreach (string file in Directory.GetFiles(checkedListBox1.CheckedItems[i].ToString(), "*.dat"))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    txtStatus.Text = "处理:" + fileInfo.Name;
                    Application.DoEvents();

                    TreeNode subNode = rootNode.Nodes.Add(fileInfo.FullName);
                    //subNode.BackColor = Color.Azure;
                    subNode.Nodes.Add("→" + dat2Img.to(fileInfo));
                }

                treeView1.ItemHeight = 22;
                treeView1.ExpandAll();
            }

            txtStatus.Text = "处理完毕！";

            btnStart.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string wxid in Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WeChat Files"), "wxid*"))
            {
                Directory.GetDirectories(Path.Combine(wxid, @"FileStorage\Image")).ToList().ForEach(x =>
                {
                    //treeView1.Nodes.Add(x);
                    checkedListBox1.Items.Add(x);
                });
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.kosvxz.com");
        }
    }
}
