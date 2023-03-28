namespace _27_寝爹下楼
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Father father = new Father("老八");
            Son son1 = new Son("张三");
            Son son2 = new Son("李四");
            Son son3 = new Son("王五");
            //寝爹要干啥？
            father.DownStairDelegate += son1.TakeExpress;//大儿子的快递
            father.DownStairDelegate += son2.TakeFood;//二儿子的饭
            father.DownStairDelegate += son3.TakeFood;//三儿子的饭和快递
            father.DownStairDelegate += son3.TakeExpress;
            //寝爹下楼喽
            father.DownStair();
            //看看干了啥↑

            //可以调用但错误↓   没有下楼无法完成委托
            //father.DownStairDelegate();
            //要避免这情况    应使用event
            //无法执行 father.DownStairDelegate();
        }
    }
}