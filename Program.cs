internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Hello, may ban nha !");
        Console.WriteLine("Chuong trinh tinh tong 2 so ! ");
        int so1, so2, tong;
        Console.Write("nhập số 1: ");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhập số 2: ");
        so2 = Convert.ToInt32(Console.ReadLine());

     

        Console.WriteLine("Tổng của 2 số " + so1 + "và" + so2 + "là:" + tinhtong(so1,so2));
        Console.WriteLine("hiệu của 2 số " + so1 + "và" + so2 + "là:" + tinhhieu(so1, so2));
        Console.WriteLine("tích của 2 số " + so1 + "và" + so2 + "là:" + tinhtich(so1, so2));


        try
        {
          
            Console.WriteLine("thương của 2 số " + so1 + "và" + so2 + " là:" + tinhthuong(so1,so2));
        }
        catch
        {
            Console.WriteLine("chẳng thể nào chia được cho không");
        }
        
    }
    private static int tinhtong(int a, int b)
    {
        return a + b;
    }
    private static int tinhhieu(int a, int b)
    {
        return a - b;
    }
    private static int tinhthuong(int a, int b)
    { 
         return a / b; 
    }

    private static int tinhtich(int a, int b)
    { return a * b; }
}

