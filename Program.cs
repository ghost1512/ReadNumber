using System;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so tu ban phim: ");
        int a = int.Parse(Console.ReadLine());

        if (a <= 10)
        {
            switch (a)
            {
                case 0: Console.WriteLine("Khong"); break;
                case 1: Console.WriteLine("Mot"); break;
                case 2: Console.WriteLine("Hai"); break;
                case 3: Console.WriteLine("Ba"); break;
                case 4: Console.WriteLine("Bon"); break;
                case 5: Console.WriteLine("Nam"); break;
                case 6: Console.WriteLine("Sau"); break;
                case 7: Console.WriteLine("Bay"); break;
                case 8: Console.WriteLine("Tam"); break;
                case 9: Console.WriteLine("Chin"); break;
                case 10: Console.WriteLine("Muoi"); break;
                default:; break;
            }
        }
        else if (a > 10 || a < 20)
        {
            switch (a)
            {
                case 11: Console.WriteLine("Muoi Mot"); break;
                case 12: Console.WriteLine("Muoi hai"); break;
                case 13: Console.WriteLine("Muoi Ba"); break;
                case 14: Console.WriteLine("Muoi Bon"); break;
                case 15: Console.WriteLine("Muoi Nam"); break;
                case 16: Console.WriteLine("Muoi Sau"); break;
                case 17: Console.WriteLine("Muoi Bay"); break;
                case 18: Console.WriteLine("Muoi Tam"); break;
                case 19: Console.WriteLine("Muoi Chin"); break;
                case 20: Console.WriteLine("Hai Muoi"); break;
                default: break;
            }
        }
    }
}