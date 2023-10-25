namespace DemoHomeTask_22_10_23;

public class TaskThirdTen
{
    public static void Run()
    {
        List<string> listChars = new List<string>() { "a", "q", "o", "a", "f", "s" };

        char[] charset1 = { 'X', 'Y', 'Z', 'W' };

        int[] numset1 = { 1, 2, 3, 4 };

        string[] colorset1 = { "Green", "Orange", "Yellow", "Pink" };

        List<ItemMast> itemlist = new List<ItemMast>
        {
            new ItemMast { ItemId = 1, ItemDes = "Biscuit  " },
            new ItemMast { ItemId = 2, ItemDes = "Chocolate" },
            new ItemMast { ItemId = 3, ItemDes = "Butter   " },
            new ItemMast { ItemId = 4, ItemDes = "Brade    " },
            new ItemMast { ItemId = 5, ItemDes = "Honey    " }
        };

        List<Purchase> purchlist = new List<Purchase>
        {
            new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
            new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
            new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
            new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
            new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
            new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
            new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
        };

        string[] cities =
        {
            "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH",
            "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"
        };

        // Task 21
        //listChars.ForEach(x => Console.Write(x + " "));

        //Console.Write("\n\nQancha harfni o'chirib tashlamoqchisiz: ");
        //int nstr21 = int.Parse(Console.ReadLine()!);

        //listChars.RemoveRange(1, nstr21);

        //listChars.ForEach(x => Console.Write(x + " "));

        // Task 22
        //List<string> liststr = new List<string>();
        //string tempList = string.Empty;

        //Console.Write("Nechta kiritmoqchisiz: ");
        //int n22 = int.Parse(Console.ReadLine()!);

        //for (int i = 0; i < n22; i++)
        //{
        //    Console.Write("Element[{0}]: ", i);
        //    liststr.Add(Console.ReadLine()!);
        //}

        //Console.Write("\nQancha uzunlikdagi ma'lumotni qidirmoqchisiz? (eng kami) : ");
        //int intInput = Convert.ToInt32(Console.ReadLine());

        //var result22 = (from x in liststr
        //                where x.Length >= intInput
        //                orderby x
        //                select x).ToList();

        //result22.ForEach(x => Console.WriteLine(x + " "));

        // Task 23
        //var result23 = charset1.SelectMany(x => numset1.Select(y => y + ' ')).ToList();

        //result23.ForEach(x => Console.WriteLine(x + " "));

        // Task 24
        //var result24 = (from letter in charset1
        //                from number in numset1
        //                from color in colorset1
        //                select new { letter, number, color }).ToList();

        //var _result24 = charset1
        //    .SelectMany(letterList => numset1.Select(numList =>
        //    new
        //    {
        //        letterList,
        //        numList
        //    }))
        //    .SelectMany((set1and2) => colorset1.Select(colorList =>
        //    new
        //    {
        //        set1and2.letterList,
        //        set1and2.numList,
        //        colorList
        //    })).ToList();

        //result24.ForEach(x => Console.WriteLine(x + " "));
        ////_result24.ForEach(x => Console.WriteLine(x + " "));

        // Task 25
        //itemlist.ForEach(x => Console.WriteLine("Item Id: {0}, Description: {1}",
        //    x.ItemId, x.ItemDes));

        //Console.WriteLine("-----------------------------------");

        //purchlist.ForEach(x => Console.WriteLine("Invoice No: {0}, Item Id : {1},  Quantity : {2}",
        //    x.InvNo, x.ItemId, x.PurQty));

        //Console.WriteLine("-----------------------------------");

        //var result25 = (from x in itemlist
        //                join y in purchlist
        //                on x.ItemId equals y.ItemId
        //                select new
        //                {
        //                    itId = x.ItemId,
        //                    itDes = x.ItemDes,
        //                    prQty = y.PurQty
        //                }).ToList();

        //result25.ForEach(x => Console.WriteLine("{0}\t{1}\t{2}", x.itId, x.itDes, x.prQty));

        // Task 26
        //itemlist.ForEach(x => Console.WriteLine("Item Id: {0}, Description: {1}",
        //x.ItemId, x.ItemDes));

        //Console.WriteLine("-----------------------------------");

        //purchlist.ForEach(x => Console.WriteLine("Invoice No: {0}, Item Id : {1},  Quantity : {2}",
        //    x.InvNo, x.ItemId, x.PurQty));

        //Console.WriteLine("-----------------------------------");

        //var result26 = (from item in itemlist
        //                join purch in purchlist
        //                on item.ItemId equals purch.ItemId
        //                into a
        //                from x in a.DefaultIfEmpty(new Purchase())
        //                select new
        //                {
        //                    ItId = item.ItemId,
        //                    ItDes = item.ItemDes,
        //                    prQty = x.PurQty
        //                }).ToList();

        //result26.ForEach(x => Console.WriteLine("{0}\t{1}\t{2}", x.ItId, x.ItDes, x.prQty));

        // Task 27
        //itemlist.ForEach(x => Console.WriteLine("Item Id: {0}, Description: {1}",
        //x.ItemId, x.ItemDes));

        //Console.WriteLine("-----------------------------------");

        //purchlist.ForEach(x => Console.WriteLine("Invoice No: {0}, Item Id : {1},  Quantity : {2}",
        //    x.InvNo, x.ItemId, x.PurQty));

        //Console.WriteLine();

        //var result27 = (from x in purchlist
        //                join y in itemlist
        //                on x.ItemId equals y.ItemId
        //                into a
        //                from b in a.DefaultIfEmpty()
        //                select new
        //                {
        //                    ItId = b.ItemId,
        //                    ItDes = b.ItemDes,
        //                    Qty = x.PurQty
        //                }).ToList();

        //result27.ForEach(x => Console.WriteLine("{0}\t{1}\t{2}",
        //    x.ItId, x.ItDes, x.Qty));

        // Task 28
        //foreach (var item in cities)
        //    Console.WriteLine(item + " ");

        //Console.WriteLine("--------------------------------------------");

        //var result28 = cities.OrderBy(x => x.Length).ThenBy(y => y).ToList();
        //result28.ForEach(x => Console.WriteLine(x + " "));

        // Task 29

    }
}

public class ItemMast
{
    public int ItemId { get; set; }
    public string ItemDes { get; set; }
}

public class Purchase
{
    public int InvNo { get; set; }
    public int ItemId { get; set; }
    public int PurQty { get; set; }
}
