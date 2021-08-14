using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wx_dat2img
{
    class selectFolder
    {
        public string folder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择微信image文件所在目录，按月选择：";
            folderBrowserDialog.SelectedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WeChat Files");
            if (folderBrowserDialog.ShowDialog() ==DialogResult.OK )
            {
                return folderBrowserDialog.SelectedPath;
            }
            return string.Empty;            
        }
    }
}
