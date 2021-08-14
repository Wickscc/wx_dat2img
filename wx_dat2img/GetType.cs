using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wx_dat2img
{
    public class GetType
    {
        public byte key { get; set; }

        public string getExt(byte key1, byte key2)
        {

            byte jkey1 = (byte)(key1 ^ 0xff);
            byte jkey2 = (byte)(key2 ^ 0xD8);

            if (jkey1 == jkey2)
            {
                key = jkey1;
                return ".jpg";
            }

            byte gkey1 = (byte)(key1 ^ 0x47);
            byte gkey2 = (byte)(key2 ^ 0x49);

            if (gkey1 == gkey2)
            {
                key = gkey1;
                return ".gif";
            }

            byte pkey1 = (byte)(key1 ^ 0x89);
            byte pkey2 = (byte)(key2 ^ 0x50);
            if (pkey1 == pkey2)
            {
                key = pkey1;
                return ".png";
            }


            byte bkey1 = (byte)(key1 ^ 0x42);
            byte bkey2 = (byte)(key2 ^ 0x4d);

            if (bkey1 == bkey2)
            {
                key = bkey1;
                return ".bmp";
            }

            return string.Empty;
        }
    }
}
