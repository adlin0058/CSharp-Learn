namespace _29_任务
{
    internal class Program
    {
        //private static void Test()
        //{
        //    for (int i = 0; i < 10000; i++)
        //    {
        //        Console.WriteLine("A");
        //    }
        //}

        private static void FirstDownLoad()
        {
            Console.WriteLine("正在下载……");
            Thread.Sleep(5000);
        }

        private static void SecondMessage(Task task)
        {
            Console.WriteLine("下载完成");
        }

        private static void Main(string[] args)
        {
            ////创建任务方法①
            //TaskFactory tf = new TaskFactory();
            //Task t = tf.StartNew(Test);

            ////方法②
            //Task t = new Task(Test);
            //t.Start();

            //连续任务
            Task task1 = new Task(FirstDownLoad);
            Task task2 = task1.ContinueWith(SecondMessage);

            Thread.Sleep(10000);
        }
    }
}