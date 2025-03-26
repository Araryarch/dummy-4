using Solution.BookStore;
using Solution.Computers;
using Solution.ElectronicStore;
using Solution.Extra;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Computer
        Processor processor = new Processor("Intel", 3.5);
        Memory memory = new Memory(16, "DDR5");
        Computer computer = new Computer(processor, memory);
        Console.WriteLine(computer.GetInfo());

        // BookStore
        TokoBuku tokoBuku = new TokoBuku();

        Buku buku1 = new Buku("123", "Pemrograman C#", 150000);
        Buku buku2 = new Buku("456", "Algoritma dan Struktur Data", 200000);
        Buku buku3 = new Buku("789", "Basis Data", 175000);

        tokoBuku.TambahBuku(buku1);
        tokoBuku.TambahBuku(buku2);
        tokoBuku.TambahBuku(buku3);
        tokoBuku.HapusBuku("456");

        foreach (var buku in tokoBuku.DaftarBuku)
        {
            Console.WriteLine(buku.GetInfo());
        }

        // ElectronicStore
        KeranjangBelanja keranjang = new KeranjangBelanja();

        Produk laptop = new Produk("Laptop", 10000000);
        Produk smartphone = new Produk("Smartphone", 5000000);
        Produk headphone = new Produk("Headphone", 1000000);

        keranjang.TambahItemBelanja(laptop, 1);
        keranjang.TambahItemBelanja(smartphone, 2);
        keranjang.TambahItemBelanja(headphone, 3);

        Console.WriteLine($"Total Belanja: {keranjang.HitungTotalBelanja()}");

        // Extra
        Tim tim = new Tim();

        Karakter karakter1 = new Karakter("Hero1");
        Karakter karakter2 = new Karakter("Hero2");

        Senjata senjata1 = new Senjata("Pedang", 50);
        Senjata senjata2 = new Senjata("Busur", 40);

        karakter1.NaikLevel();

        tim.TambahKarakter(karakter1);
        tim.TambahKarakter(karakter2);
        tim.TambahSenjata(senjata1);
        tim.TambahSenjata(senjata2);

        tim.TampilkanInfoTim();
    }
}
