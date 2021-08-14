using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wx_dat2img
{
    class Convert
    {
        public string to(FileInfo fileInfo)
        {
            byte[] dat = File.ReadAllBytes(fileInfo.FullName);

            GetType getType = new GetType();
            string ext = getType.getExt(dat[0], dat[1]);

            for (int i = 0; i < dat.Length; i++)
            {
                dat[i] ^= getType.key;
            }

            string imgPath = Path.Combine(fileInfo.DirectoryName, "img", fileInfo.LastWriteTime.ToString("yyyyMMdd"));
            if (!Directory.Exists(imgPath)) Directory.CreateDirectory(imgPath);

            File.WriteAllBytes(Path.Combine(imgPath, fileInfo.Name + ext), dat);

            return Path.Combine(imgPath, fileInfo.Name + ext);
        }


    }
}
