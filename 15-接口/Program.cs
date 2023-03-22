namespace _15_接口
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classInterface ci = new classInterface();
            ci.Fly();
            //多态
            IFly fly;
            fly = new Plane();
            fly.Fly();

            fly = new Bird();
            fly.Fly(); 
        }
    }
}