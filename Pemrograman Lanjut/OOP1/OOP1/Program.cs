//class awal untuk deklarasi
public abstract class animal
{
    public string kelas;
    public string habitat;
    public string pergerakan;

    //polymorphism yang dibuat dengan keyword virtual agar bisa override di class lain
    public virtual void bersuara()
    {
        Console.WriteLine("Suaranya ");
    }
}

//inheritance, class kucing mengambil dari class animal
class kucing : animal
{
    public string binatang = "Kucing";
    //fungsi bersuara() dari class animal bisa dipanggil ke class kucing karena kucing meng-inherit class animal
    public override void bersuara()
    {
        base.bersuara();
        Console.WriteLine("meong");
    }
}

class program
{
    static void Main(string[] args)
    {
        kucing tom = new kucing();
        tom.kelas = "Mamalia";
        tom.habitat = "Domestik";
        tom.pergerakan = "Berjalan";

        Console.WriteLine("binatang: " + tom.binatang + " kelas binatang: " + tom.kelas + " habitat binatang: " + tom.habitat + " cara binatang bergerak: " + tom.pergerakan);
        tom.bersuara();
    }
}