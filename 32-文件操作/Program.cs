namespace _32_文件操作
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //FileInfo  文件
            //DirectoryInfo 文件夹

            //文件拷贝
            //①
            //FileInfo myfile = new FileInfo(@"D:\CSharpWorkspace\CSharp学习\32-文件操作\TextFile1.txt");
            //myfile.CopyTo(@"D:\CSharpWorkspace\CSharp学习\32-文件操作\TextFile2.txt");
            ////②
            //File.Copy(@"D:\CSharpWorkspace\CSharp学习\32-文件操作\TextFile1.txt",
            //    @"D:\CSharpWorkspace\CSharp学习\32-文件操作\TextFile3.txt");

            //string text = File.ReadAllText(@"D:\CSharpWorkspace\CSharp学习\32-文件操作\TextFile2.txt");
            //Console.WriteLine(text);

            //流
            FileStream readFileStream = new FileStream(@"D:\CSharpWorkspace\CSharp学习\32-文件操作\file.zip", FileMode.Open, FileAccess.Read);
            //读每一字节，然后指针右移
            //readFileStream.ReadByte();

            FileStream writeFileStream = new FileStream(@"D:\CSharpWorkspace\CSharp学习\32-文件操作\fileCopy.zip", FileMode.Create, FileAccess.Write);
            //写字节
            //writeFileStream.WriteByte();

            //将readFileStream的每一字节复制到writeFileStream
            int nextByte = -1;
            while ((nextByte = readFileStream.ReadByte()) != -1)
            {
                writeFileStream.WriteByte((byte)nextByte);
            }
            //关闭流
            //先开的流后关闭
            writeFileStream.Close();
            readFileStream.Close();
        }
    }
}