using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wx_dat2img
{
    class Decrypt
    {
        public static List<string> datDir = new List<string>();
        public static bool deldat = false;
        public Decrypt()
        {

        }
        public string ext { get; set; }
        public byte key { get; set; } //用于解密的数字
        public string datfile { get; set; }//需要转换的文件

        public string Convert()
        {
            FileInfo fileInfo = new FileInfo(datfile);

            byte[] dat = File.ReadAllBytes(fileInfo.FullName);

            getExt(dat[0], dat[1]);

            for (int i = 0; i < dat.Length; i++)
            {
                dat[i] ^= key;
            }

            string imgPath = Path.Combine(fileInfo.DirectoryName, "img", fileInfo.LastWriteTime.ToString("yyyyMMdd"));
            if (!Directory.Exists(imgPath)) Directory.CreateDirectory(imgPath);

            string imgFullPath = Path.Combine(imgPath, fileInfo.Name + ext);
            if (!File.Exists(imgFullPath))
                File.WriteAllBytes(imgFullPath, dat);

            if (deldat)
            {
                Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(datfile, Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);
            }

            return imgFullPath;
        }

        private void getExt(byte key1, byte key2)
        {

            byte jkey1 = (byte)(key1 ^ 0xff);
            byte jkey2 = (byte)(key2 ^ 0xD8);

            if (jkey1 == jkey2)
            {
                key = jkey1;
                ext = ".jpg";
            }

            byte gkey1 = (byte)(key1 ^ 0x47);
            byte gkey2 = (byte)(key2 ^ 0x49);

            if (gkey1 == gkey2)
            {
                key = gkey1;
                ext = ".gif";
            }

            byte pkey1 = (byte)(key1 ^ 0x89);
            byte pkey2 = (byte)(key2 ^ 0x50);
            if (pkey1 == pkey2)
            {
                key = pkey1;
                ext = ".png";
            }

            byte bkey1 = (byte)(key1 ^ 0x42);
            byte bkey2 = (byte)(key2 ^ 0x4d);

            if (bkey1 == bkey2)
            {
                key = bkey1;
                ext = ".bmp";
            }

        }

    }
}
