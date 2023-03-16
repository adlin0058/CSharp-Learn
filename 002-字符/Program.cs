//int a = 97;
//char c1 = 'A';
//int b = c1;
//char c = (char)a;//强制转换类型
//Console.WriteLine(c);
//Console.WriteLine(b);

internal class Program
{
    private static void Main(string[] args)
    {
        string str1 = "c:\\a\\b\\c";
        string str2 = @"c:\\a\\b\\c";

        string str3 = "li" + "ming";
        Console.WriteLine(str1);
        Console.WriteLine(str2);
        Console.WriteLine(str3 + "我在中间" + str2);
        Console.WriteLine("2412780034@qq.com\nLiMing");
        Console.WriteLine(@"c:\\a\\b\\c");
        Console.WriteLine("这是一段字符串后面可以加一个数字" + 111);

        //读取数据
        string str4 = Console.ReadLine();
        int n = Convert.ToInt32(str4);
        Console.WriteLine(n + "nice");

    }
}