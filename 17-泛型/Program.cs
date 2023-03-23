namespace _17_泛型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> gc1 = new GenericClass<int>(12, 34);
            Console.WriteLine(gc1.GetSum());

            GenericClass<double> gc2 = new GenericClass<double>(23.5, 98.2);
            Console.WriteLine(gc2.GetSum());

            GenericClass<string> gc3 = new GenericClass<string>("li", "ming");
            Console.WriteLine(gc3.GetSum());

        }
    }

    class GenericClass<T>
    { 
        private T value1;
        private T value2;
        public GenericClass(T value1, T value2)
        {
            this.value1 = value1;
            this.value2 = value2;
        }
        public T GetSum()
        {
            dynamic a = value1;
            dynamic b = value2;
            return a + b;
        }
    }

}