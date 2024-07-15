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

        tong = so1 + so2;

        Console.WriteLine("Tổng của 2 số " + so1 + "và" + so2 + "là:" + tong);
        double thuong;
        try
        {
            thuong = so1 / so2;
            Console.WriteLine("thương của 2 số " + so1 + "và" + so2 + " là:" + thuong);
        }
        catch
        {
            Console.WriteLine("chẳng thể nào chia được cho không");
        }
    }
}
