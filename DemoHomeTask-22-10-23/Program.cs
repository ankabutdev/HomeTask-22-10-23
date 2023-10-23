namespace DemoHomeTask_22_10_23;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int>() { 0, 1, 2, 3, -3, 4, 5, 6, 7, 8, 9, 10, 11,
                                            12, 13, 14, 15, 16, 17, 18, 19, 20,
                                            0, 1, 2, 3, -3, 4, 5, 6, 7, 8, 9, 10 ,
                                               4, 5, 6, 4, 3, 4, 5, 6,
                                                55, 200, 740, 76, 230, 482, 95};

        string[] dayWeek = { "Dushanba", "Seshanba", "Chorshanba", "Payshanba", "Juma", "Shanba", "Yakshanba" };

        string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

        List<int> demolist = new List<int>();


        // 1 Task
        var result1 = (from x in list
                       where (x % 2) == 0
                       select x).ToList();

        result1.ForEach(x => Console.WriteLine(x + " "));

        Console.WriteLine("--------------------------------------------------------------");

        // 2 Task
        var result2 = (from x in list
                       where x > 0
                       where x < 12
                       select x).ToList();

        result2.ForEach(x => Console.WriteLine(x + " "));

        Console.WriteLine("--------------------------------------------------------------");

        // Task 3
        var result3 = (from int num in list
                       let SqNum = num * num
                       where SqNum > 20
                       select new { num, SqNum }).ToList();

        result3.ForEach(x => Console.WriteLine(x + " "));

        Console.WriteLine("--------------------------------------------------------------");

        // Task 4
        var result4 = (from x in list
                       group x by x into y
                       select y).ToList();

        result4.ForEach(x =>
                Console.WriteLine("Num: {0} Count: {1}", x.Key, x.Count()));

        Console.WriteLine("--------------------------------------------------------------");

        // Task 5
        string str = Console.ReadLine()!;

        var result5 = (from x in str
                       group x by x into y
                       select y).ToList();

        result5.ForEach(x => Console.WriteLine("Char: {0} Count: {1}", x.Key, x.Count()));

        Console.WriteLine("--------------------------------------------------------------");

        // Task 6
        var result6 = (from x in dayWeek
                       select x).ToList();

        result6.ForEach(x => Console.WriteLine(x));

        Console.WriteLine("--------------------------------------------------------------");

        // Task 7
        var result7 = (from x in list
                       group x by x into y
                       select y).ToList();

        result7.ForEach(x => Console.WriteLine("Num: {0}\t Sum: {1}\t Count: {2}",
            x.Key, x.Sum(), x.Count()));

        Console.WriteLine("--------------------------------------------------------------");

        // Task 8
        Console.Write("Start: ");
        string startChar = Console.ReadLine()!;
        Console.Write("End: ");
        string endChar = Console.ReadLine()!;

        var result8 = (from x in cities
                       where x.StartsWith(startChar)
                       where x.EndsWith(endChar)
                       select x).ToList();

        result8.ForEach(x => Console.WriteLine("StartCh: {0} EndCh: {1} Result: {2}", startChar, endChar, x));

        Console.WriteLine("--------------------------------------------------------------");

        //  Task 9
        var result9 = list.Where(x => x > 80).ToList();

        var _result9 = (from x in list
                        where x > 80
                        select x).ToList();

        result9.ForEach(x => Console.WriteLine(x + " "));

        Console.WriteLine("--------------------------------------------------------------");

        // Task 10
        Console.Write("Nechta son kiritmoqchisiz: ");
        int n = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Member {0}: ", i);
            demolist.Add(int.Parse(Console.ReadLine()!));
        }

        Console.Write("Nechtadan kattalarini chiqarish kerak: ");
        int m = int.Parse(Console.ReadLine()!);

        var result10 = (from x in demolist
                        where x > m
                        select x).ToList();

        var _result10 = demolist.FindAll(x => x > m ? true : false);

        result10.ForEach(x => Console.WriteLine(x));

        Console.WriteLine("--------------------------------------------------------------");
    }
}