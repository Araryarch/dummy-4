[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/PUMHcz3i)
# oop-composition-csharp

## Sub Capaian Pembelajaran

1. Mahasiswa mampu memodelkan struktur komposisi dengan mendeklarasikan atribut bertipe data non-primitif
2. Mahasiswa mampu menggunakan kembali fungsionalitas suatu objek di objek lainnya menggunakan prinsip komposisi

## Lingkungan Pengembangan

1. Platform: .NET 6.0
2. Bahasa: C# 10
3. IDE: Visual Studio 2022

## Cara membuka project menggunakan Visual Studio

1. Clone repositori project `oop-composition-csharp` ke direktori lokal git Anda.
2. Buka Visual Studio, pilih menu File > Open > Project/Solution > Pilih file *.sln.
3. Tekan tombol Open untuk  untuk membuka solusi.
4. Baca soal dengan seksama. Buat implementasi kode sesuai dengan petunjuk.
6. Jalankan unit test di project *.Tests

> PERINGATAN: Push kode program ke remote repository jika hanya seluruh test case sudah lolos/passed (bertanda hijau).

## Soal-soal

### Komputer dan Komponennya

Buat solusi dari soal ini di project `Solution` folder `Computers` dengan namespace `Solution.Computers`.

Buatlah sebuah kelas publik bernama `Computer` yang digunakan untuk merepresentasikan sebuah komputer. Sebuah `Computer` memiliki komponen-komponen sebagai atribut yaitu: `Processor` (tipe Processor) dan `Memory` (tipe Memory).

Buatlah kelas publik `Processor` dengan informasi sebagai variabel instance yaitu: `_brand` (tipe string) dan `_speed` (tipe double, dalam GHz). Kelas `Processor` harus memiliki konstruktor yang menginisialisasi kedua variabel instance tersebut serta properti publik `Brand` dan `Speed`  setter dan getter untuk masing-masing variabel instance.

Buatlah kelas `Memory` dengan informasi sebagai variabel instance yaitu: `_capacity` (tipe int, dalam GB) dan `_memoryType` (tipe string, seperti "DDR4", "DDR5"). Kelas `Memory` harus memiliki konstruktor yang menginisialisasi kedua variabel instance tersebut serta properti publik `Capacity` dan `MemoryType` dengan setter dan getter untuk masing-masing variabel instance.

Kelas `Computer` harus memiliki konstruktor yang menginisialisasi kedua komponen tersebut. Sediakan properti publik setter dan getter untuk masing-masing komponen. Kelas `Computer` juga memiliki metode `GetInfo` yang mengembalikan informasi komputer dengan memanfaatkan informasi dari kelas Processor dan Memory dengan format "Processor Brand: [Brand], Kecepatan: [Speed], Memory Kapasitas: [Capacity], Tipe: [MemoryType]".

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi 1 objek dari kelas `Computer` menggunakan keyword new, set variabel instancenya, dan tampilkan informasi dari komputer tersebut ke layar.

### Toko Buku

Buat solusi dari soal ini di project `Solution` folder `BookStore` dengan namespace `Solution.BookStore`.

Buatlah sebuah kelas publik bernama `Buku` yang digunakan untuk merepresentasikan sebuah buku yang dijual di toko buku. Sebuah `Buku` memiliki tiga informasi sebagai variabel instance yaitu: `_isbn` (tipe string), `_judul` (tipe string) dan `_harga` (tipe double). Kelas `Buku` harus memiliki sebuah konstruktor yang menginisialisasi ketiga variabel instance tersebut. Sediakan properti getter publik untuk masing-masing variabel instance yaitu `Isbn`, `Judul`, dan `Harga`. Buat metode bernama `IsIsbnMatch` dengan parameter input `isbn` (tipe string) dan mengembalikan bool value true jika isbn sesuai, dan sebaliknya jika tidak sesuai. Buat metode bernama `GetInfo` yang mengembalikan string dengan format "ISBN: {Isbn}, Judul: {Judul}, Harga: {Harga}".

Buatlah sebuah kelas bernama `TokoBuku` yang memiliki informasi sebagai variabel instance berupa daftar buku (tipe `List<Buku>`). Buat properti publik `DaftarBuku` yang hanya memiliki metode setter. Kelas `TokoBuku` harus memiliki metode untuk menambahkan buku ke dalam daftar dengan nama `TambahBuku`, menghapus buku dari daftar dengan nama `HapusBuku`, mencari buku berdasarkan ISBN dengan nama `CariBuku` dan menampilkan semua buku yang ada di daftar dengan nama `GetDaftarBuku`. Metode `CariBuku` akan menggunakan fungsionalitas yang disediakan oleh kelas `Buku` yaitu `IsIsbnMatch` untuk membandingan ISBN buku yang dicari. Metode `GetDaftarBuku` menggunakan fungsionalitas yang disediakan oleh kelas `Buku` yaitu `GetInfo`. 

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi objek dari kelas `TokoBuku`, tambahkan beberapa buku ke dalam daftar, hapus beberapa buku, dan tampilkan informasi dari semua buku yang ada di daftar ke layar.

### Toko Elektronik

Buat solusi dari soal ini di project `Solution` folder `ElectronicStore` dengan namespace `Solution.ElectronicStore`.

Sebuah toko elektronik menjual berbagai jenis produk. Setiap produk memiliki karakteristik harga dan nama.

Buatlah sebuah kelas bernama `Produk` yang memiliki informasi sebagai variabel instance yaitu: `_nama` (tipe String) dan `_harga` (tipe double). Kelas `Produk` harus memiliki sebuah konstruktor yang menginisialisasi kedua variabel instance tersebut. Sediakan properti setter dan getter public untuk masing-masing variabel instance yaitu `Nama` dan `Harga`.

Buatlah sebuah kelas bernama `ItemBelanja` yang merepresentasikan sebuah item dalam keranjang belanja. Kelas ini memiliki dua variabel instance yaitu: `_produk` (tipe `Produk`) dan `kuantitas` (tipe int). Kelas `ItemBelanja` harus memiliki metode `HitungTotal` yang mengembalikan total harga (tipe double) dari produk berdasarkan kuantitas dan harga satuan per barang.

Buatlah sebuah kelas bernama `KeranjangBelanja` yang memiliki informasi sebagai variabel instance berupa daftar item belanja (tipe List<ItemBelanja>). Buat properti publik `Items` yang mengembalikan daftar item belanja. Kelas `KeranjangBelanja` harus memiliki metode untuk menambahkan produk ke dalam daftar dengan nama `TambahItemBelanja` dan metode `HitungTotalBelanja` yang mengembalikan nilai bertipe double yang merupakan total harga dari semua produk yang ada di dalam daftar dengan memanggil metode `HitungTotal` dari kelas `ItemBelanja`.

Buatlah sebuah kelas bernama `Program` yang didalamnya terdapat metode static `Main`. Instansiasi objek dari kelas `KeranjangBelanja`, tambahkan beberapa produk ke dalam daftar, dan tampilkan total harga dari semua produk yang ada di daftar ke layar dengan memanggil metode `HitungTotalBelanja`.

### Extra

> Saatnya Kreatif!

Buat soal Anda sendiri dan solusinya di project `Solution` folder `Extra` dengan namespace `Solution.Extra` di file `Extra.cs`.

Buat spesifikasi soal Anda sendiri yang memuat hal-hal sebagai berikut:

- Nama kelas yang dibuat, kegunaannya.
- Atribut komposisi dan properti apa saja yang harus ada di kelas.
- Metode apa saja yang dibutuhkan.
- Validasi atau aturan apa yang harus dilakukan.
- Penggunaan kembali fungsionalitas berdasarkan prinsip komposisi.

Kemudian, implementasikan solusi kelas dari soal Anda di file `Extra.cs` dan eksekusi implementasinya di `Program.cs`.

=== Selesai ===


