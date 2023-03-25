// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Text.RegularExpressions;

string str1 = "12345n";
string str2 = "123456";
/*
 * Regex.IsMatch(str,@"");
 * \d数字   \D不能有数字
 * * 0个或多个*前一个的元素
 * ^s是否以s开头
 * s$是否以s结尾
 * ^\d以数字开头
 * \d数字结尾
 * ^\d*$ 是否数字开头结尾
 * ^\d$只有一个数字
 * \w只能包含 大小写字母、0-9和_
 * \W      不包含↑（补集）
 * [] []内的元素符合条件    [a-gx-z]a-g之间的字符和x-z之间的字符   [A-H]区分大小写  [^A-H]补集
 *
 */
//Console.WriteLine(Regex.IsMatch(str1, @"\d*"));
//Console.WriteLine(Regex.IsMatch(str2, @"\d*"));

//由大小写字母数字和_组成，但是不能以数字开头
string re = @"^[a-zA-z_]\w*$";
Console.WriteLine(Regex.IsMatch("adas", re));
Console.WriteLine(Regex.IsMatch("111adad12", re));

//替换
string str3 = "asda18_37-d.nauw.d8hd9a8w";
Console.WriteLine(Regex.Replace(str3, @"\w", "*"));

//5-12为的数字组成
string re1 = @"^\d{5,12}$";
//@"^\d{5,}$"至少5位
//@"^\d{5}$"5位
Console.WriteLine(Regex.IsMatch("123", re1));
Console.WriteLine(Regex.IsMatch("12ddd3", re1));
Console.WriteLine(Regex.IsMatch("19178171312323", re1));
Console.WriteLine(Regex.IsMatch("3212323", re1));

//择一
Console.WriteLine(Regex.IsMatch("2", @"\d|a"));//数字或a
Console.WriteLine(Regex.IsMatch("d", @"\d|a"));
Console.WriteLine(Regex.IsMatch("a", @"\d|a"));
Console.WriteLine();
//分组
Console.WriteLine(Regex.IsMatch("abba", @"ab{1}"));//只要匹配一个就行
Console.WriteLine(Regex.IsMatch("abab", @"(ab){2}"));
Console.WriteLine(Regex.IsMatch("abb", @"(ab){2}"));
Console.WriteLine(Regex.IsMatch("aa", @"a{2}"));