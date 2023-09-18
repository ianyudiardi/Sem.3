static void Main(string[] args)
{
    Console.Title = "Aplikasi Calculator Versi Console";
    Console.Write("Inputkan Nilai A = ");
    int a = int.Parse(Console.ReadLine()); //casting

    Console.Write("Inputkan Nilai B = ");
    var b = Convert.ToInt32(Console.ReadLine()); //casting

    Console.WriteLine();
    Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
    Console.WriteLine("Hasil Penambahan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
    Console.WriteLine("Hasil Penambahan: {0} x {1} = {2}", a, b, Perkalian(a, b));
    Console.WriteLine("Hasil Penambahan: {0} / {1} = {2}", a, b, Pembagian(a, b));

    Console.ReadKey();
}