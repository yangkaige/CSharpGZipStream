# CSharpGZipStream简单使用
不管是压缩还是解压，都要有读取流和写入流，GZipStream产生的流只是一个用于过度的操作，
压缩时GZipStream和写入流相关联，解压时GZipStream和读取流相关联。
