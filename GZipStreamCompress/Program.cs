using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace GZipStreamCompress
{
    class Program
    {
        /// <summary>
        /// 文件压缩
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (FileStream fsRead = File.OpenRead("1.txt"))
            {
                using (FileStream fsWrite = File.OpenWrite("yasuo.zip"))
                {
                    using (GZipStream gZipStream = new GZipStream(fsWrite, CompressionMode.Compress))
                    {
                        int r;
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        while ((r = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            gZipStream.Write(buffer, 0, r);
                        }
                    }
                }

            }
            Console.WriteLine("压缩成功！！");
            Console.ReadKey();
        }
    }
}
