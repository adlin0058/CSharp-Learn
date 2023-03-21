namespace _08_天干地支
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //天干：子、丑、寅、卯、辰、巳、午、未、申、酉、戌、亥
            string[] TianGan = { "甲", "乙", "丙", "丁", "戊", "己", "庚", "辛", "壬", "癸" };
            string[] DiZhi = { "子鼠", "丑牛", "寅虎", "卯兔", "辰龙", "巳蛇", "午马", "未羊", "申猴", "酉鸡", "戌狗", "亥猪" };
            while (true)
            {
                Console.WriteLine("请输入年份：");
                int year = Convert.ToInt32(Console.ReadLine());
                if(year == 0||year == 1 ||year == 2)
                {
                    Console.WriteLine("没有天干地支！");
                    continue;
                }
                int tiangan = (year - 3) % 10;
                if (tiangan == 0) { tiangan = 10; }
                int dizhi = (year - 3) % 12;
                if (dizhi == 0) { dizhi = 12; }
                Console.WriteLine("{0}年为{1}{2}年", year, TianGan[tiangan - 1], DiZhi[dizhi - 1]);
                Console.WriteLine();
            }
            
        }
    }
}