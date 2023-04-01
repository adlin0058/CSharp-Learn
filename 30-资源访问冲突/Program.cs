namespace _30_资源访问冲突
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StateObject state = new StateObject();

            for (int i = 0; i < 100; i++)
            {
                Thread t = new Thread(state.ChangeState);
                t.Start();
            }
        }
    }
}