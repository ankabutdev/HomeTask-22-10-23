namespace DemoHomeTask_22_10_23;

public class TaskSecondTen
{
    public static void Run()
    {
        List<int> list = new List<int>() { 0, 1, 2, 3, -3, 4, 5, 6, 7, 8, 9, 10, 11,
                                            12, 13, 14, 15, 16, 17, 18, 19, 20,
                                            0, 1, 2, 3, -3, 4, 5, 6, 7, 8, 9, 10 ,
                                               4, 5, 6, 4, 3, 4, 5, 6,
                                                55, 200, 740, 76, 230, 482, 95};

        List<string> listChars = new List<string>() { "a", "q", "o", "a", "f", "s" };

        string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf",
                            "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

        string[] dirFile = Directory.GetFiles("C:\\Users\\iddiu\\OneDrive\\Изображения\\Снимки экрана");

        // Task 11
        foreach (var lstnum in list)
        {
            Console.WriteLine(lstnum + " ");
        }

        Console.Write("Nechtasini chiqarmoqchisiz: ");
        int n = int.Parse(Console.ReadLine()!);

        list.Sort();
        list.Reverse();

        foreach (var item in list.Take(n))
        {
            Console.WriteLine(item + " ");
            //}

            // Task 12
            Console.Write("Gap kiriting: ");
            string input = Console.ReadLine()!;

            var UpperWords = input.Split(' ')
                .Where(x => String.Equals(x, x.ToUpper(),
                StringComparison.Ordinal));

            foreach (var item2 in UpperWords)
            {
                Console.WriteLine(item2 + " ");
            }
        }
        // Task 13
        List<string> liststr = new List<string>();
        string tempList = string.Empty;

        Console.Write("Nechta kiritmoqchisiz: ");
        int n13 = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < n13; i++)
        {
            Console.Write("Element[{0}]: ", i);
            liststr.Add(Console.ReadLine()!);

            //tempList += i == n - 1 ? liststr[i] : liststr[i] + ", ";
        }

        var result = String.Join(", ", liststr
            .Select(x => x.ToString())
            .ToArray());

        Console.WriteLine(tempList);

        // Task 14
        Students stu = new Students();

        Console.Write("Nechinchi o'rinni topmoqchisiz: ");
        int point = int.Parse(Console.ReadLine()!);

        var students = stu.GetAllStudents();

        var result14 = (from x in students
                        group x by x.GrPoint into g
                        orderby g.Key descending
                        select new
                        {
                            StudentRecord = g.ToList()
                        }).ToList();

        result14[point - 1].StudentRecord
            .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}",
            i.StuId, i.StuName, i.GrPoint));

        // Task 15
        var result15 = arr1.Select(x => Path.GetExtension(x).TrimStart('.').ToLower())
            .GroupBy(y => y, (fExt, extCtr) => new
            {
                Extension = fExt,
                Count = extCtr.Count(),
            });

        foreach (var item in result15)
        {
            Console.WriteLine("{0} file: Extension: [{1}]", item.Count, item.Extension);
        }

        // Task 16
        var result16 = dirFile.Select(file => new FileInfo(file).Length).Average();
        result16 = Math.Round(result16 / 10, 1);
        Console.WriteLine("The Average file size is {0} MB", result16);

        // Task 17
        listChars.ForEach(x => Console.Write(x + " "));

        Console.Write("\n\nQaysi harfni o'chirib tashlamoqchisiz: ");
        string nstr = Console.ReadLine()!;

        var result17 = listChars.FirstOrDefault(y => y == nstr);
        listChars.Remove(result17!);

        listChars.ForEach(x => Console.Write(x + " "));

        // Task 18
        listChars.ForEach(x => Console.Write(x + " "));

        Console.Write("\n\nQaysi harfni o'chirib tashlamoqchisiz: ");
        string nstr18 = Console.ReadLine()!;

        var result18 = listChars.FirstOrDefault(y => y == nstr18);
        listChars.Remove(result18!);

        listChars.ForEach(x => Console.Write(x + " "));

        // Task 19
        listChars.ForEach(x => Console.Write(x + " "));

        Console.Write("\n\nQaysi harfni o'chirib tashlamoqchisiz: ");
        string nstr19 = Console.ReadLine()!;

        var result19 = listChars.FirstOrDefault(y => y == nstr19);
        listChars.Remove(result17!);

        listChars.ForEach(x => Console.Write(x + " "));

        // Task 20
        listChars.ForEach(x => Console.Write(x + " "));

        Console.Write("\n\nQaysi harfni o'chirib tashlamoqchisiz: ");
        string nstr20 = Console.ReadLine()!;

        var result20 = listChars.FirstOrDefault(y => y == nstr20);
        listChars.Remove(result20!);

        listChars.ForEach(x => Console.Write(x + " "));
    }
}