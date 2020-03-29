using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
namespace GZipStreamDecompress
{
    class Program
    {
        /// <summary>
        /// 文件解压
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            using (FileStream fsRead = File.OpenRead("yasuo.txt"))
            {
                using (FileStream fsWrite = File.OpenWrite("1.txt"))
                {
                    using (GZipStream gZipStream = new GZipStream(fsRead, CompressionMode.Decompress))
                    {
                        int r;
                        byte[] buffer = new byte[1024 * 1024 * 5];
                        while ((r = gZipStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fsWrite.Write(buffer, 0, r);
                        }
                    }
                }
            }
            Console.WriteLine("解压成功！！");
            Console.ReadKey();
        }
    }
}
