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

namespace wx_dat2img
{
    public partial class frm_wxdatdir : Form
    {
        public frm_wxdatdir()
        {
            InitializeComponent();
        }

        private void frm_wxImgDir_Load(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = true;    //单击时切换复选框状态，否则单击选择，再次单击才切换

            if (checkedListBox1.Items.Count == 0)         //如果没有已经选择的目录，则自动搜索目录
            {
                foreach (string wxid in Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WeChat Files"), "wxid*"))
                {
                    checkedListBox1.Items.AddRange( Directory.GetDirectories(Path.Combine(wxid, @"FileStorage\Image")));
                }
            }

            //清理下没有dat文件的目录
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if(Directory.GetFiles(checkedListBox1.Items[i].ToString(),"*.dat").Length == 0)
                {
                    checkedListBox1.Items.RemoveAt(i);
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)   //判断新的状态是否为选中状态
            {                
                Decrypt.datDir.Add(checkedListBox1.Items[e.Index].ToString());
            }
            else
            {
                Decrypt.datDir.Remove(checkedListBox1.Items[e.Index].ToString());
            }
        }

        private void 添加目录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择微信image文件所在目录，按月选择：";
            folderBrowserDialog.SelectedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WeChat Files");
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                checkedListBox1.Items.Add(folderBrowserDialog.SelectedPath);
            }
        }

        private void 选择全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void 全部取消ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void 清空列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
        }
    }
}
