using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wx_dat2img
{
    public partial class frm_Decrypt : Form
    {
        public frm_Decrypt()
        {
            InitializeComponent();
        }

        private void frm_Decrypt_Shown(object sender, EventArgs e)
        {
            Decrypt.datDir.ForEach(x =>
            {
                TreeNode rootNode = treeView1.Nodes.Add(x.ToString());

                Decrypt img = new Decrypt();
                foreach (string file in Directory.GetFiles(x.ToString(), "*.dat"))
                {
                    img.datfile = file;
                    lb_Status.Text = "处理：" + Path.GetFileName(file);
                    Application.DoEvents();

                    TreeNode subNode = rootNode.Nodes.Add(file);
                    subNode.Nodes.Add("→" + img.Convert());
                }

                treeView1.ItemHeight = 22;
            });


            this.DoubleBuffered = true; //开始双缓冲

            if (treeView1.Nodes.Count <= 2)     //如果小于2个子节点，就全部展开
            {
                treeView1.ExpandAll();
            }
            else
            {
                treeView1.Nodes[treeView1.Nodes.Count - 1].Expand();    //否则只展开最后一个
            }

            lb_Status.Text = "处理完成！！！";

        }
    }
}
