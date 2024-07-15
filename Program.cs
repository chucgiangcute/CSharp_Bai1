internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Xin chào thế giới ! Và đây là Chúc Giang on the mic !!!");
        Console.WriteLine("Đây là chương trình tính toán");
        int so1, so2, tong, hieu, tich;
        Console.WriteLine("Nhập số 1 :");
        so1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập số 2 :");
        so2 = Convert.ToInt32(Console.ReadLine());
        tong = so1 + so2;
        Console.WriteLine("Tổng của số là :" +tong);
        //Console.WriteLine("Tổng của số là : {0},{1},{2}",so1,so2,tong);

        
        hieu = so1 - so2;
        Console.WriteLine("Hiệu của số là :"+hieu);

       
        tich = so1 * so2;
        Console.WriteLine("Tích của số là :" + tich);

        double thuong;
       try
        {
            thuong = so1 / so2;
            Console.WriteLine("Thương của số là :" + thuong);
        }
        catch
        {
            Console.WriteLine("Không thể chia cho 0");
        }





    }
}