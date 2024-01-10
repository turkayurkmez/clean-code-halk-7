using Functions;

public class Program
{
    public static void Main(string[] args)
    {
        /*
         * 1. 1-100 arasında rastgele sayı seç.
         * 2. Kullanıcıdan sayıyı tahmin etmesini iste
         * 3. Tahmin edilen sayı ile hedef sayıyı karşılaştır.
         *         -- sonuca göre (Yukarı, aşağı veya bildiniz gibi) yönlendir
         *         
         * 4. Bilene kadar 2. Adıma git.   
         */
        var hedef = rastgeleSayiGetir(1, 100);
        string yonlendirme = string.Empty;
        do
        {
            int tahmin = kullanicidanTahminAl();
            yonlendirme = karsilastir(hedef, tahmin);
            Console.WriteLine(yonlendirme);

        } while (yonlendirme != Durum.Bildiniz);

        ProductService productService = new ProductService();
        var avg = productService.GetAveragePrice();

    }



    static int rastgeleSayiGetir(int minimum, int maximum)
    {
        //birim zamanda bir iş.
        Random randomGenerator = new Random();
        return randomGenerator.Next(minimum, maximum);
    }

    private static int kullanicidanTahminAl()
    {
        Console.WriteLine("Lütfen sayıyı tahmin edin");
        return int.Parse(Console.ReadLine());
    }

    private static string karsilastir(int hedef, int tahmin)
    {
        if (hedef < tahmin)
        {
            return Durum.Asagi;
        }
        else if (hedef > tahmin)
        {
            return Durum.Yukari;
        }

        return Durum.Bildiniz;

    }

}

public class Durum
{
    public const string Yukari = "Yukarı";
    public const string Asagi = "Asagi";
    public const string Bildiniz = "Bildiniz";



}