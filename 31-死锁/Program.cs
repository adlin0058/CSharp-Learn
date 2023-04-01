namespace _31_死锁
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestLock state = new TestLock();

            Thread thread1 = new Thread(state.Mothed1);
            thread1.Start();
            Thread thread2 = new Thread(state.Mothed2);
            thread2.Start();
        }
    }
}