namespace _38_LINQ
{
    internal class Program
    {
        //private static void Main(string[] args)
        //{
        //    var list = new List<int> { 0, 9, 6, 3, 1, 5, 2, 7, 8, 4 };
        //    //输出大于4的偶数，并排序

        //    //var res = new List<int>();
        //    //foreach (var item in list)
        //    //{
        //    //    if (item >= 4 && item % 2 == 0)
        //    //    {
        //    //        res.Add(item);
        //    //    }
        //    //}
        //    //res.Sort();

        //    //query expression查询表达式
        //    //var res =
        //    //    from n in list
        //    //    where n % 2 == 0 && n >= 4//n是偶数且不小于4
        //    //    orderby n//排序
        //    //    select n;

        //    //chained expression 链式表达式
        //    var res = list
        //        .Where(n => n >= 4 && n % 2 == 0)
        //        .OrderBy(n => n);

        //    foreach (var item in res)
        //        Console.WriteLine(item);
        //}

        private static void Main(string[] args)
        {
            var arr1 = new[] { 1, 2, 3, 4, 5, 6 };
            var arr2 = new[] { 9, 3, 5, 7, 2, 6 };

            //var res = new List<int>();
            //foreach (var item in arr1)
            //{
            //    if (arr2.Contains(item))
            //        res.Add(item);
            //}

            //var res = arr1.Intersect(arr2);

            var res =
                from n in arr1
                where arr2.Contains(n)
                select n;

            foreach (var item in res)
                Console.WriteLine(item);
        }
    }
}