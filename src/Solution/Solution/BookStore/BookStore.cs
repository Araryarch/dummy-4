using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.BookStore
{
    public class Buku
    {
        private string _isbn;
        private string _judul;
        private double _harga;

        public Buku(string isbn, string judul, double harga)
        {
            _isbn = isbn;
            _judul = judul;
            _harga = harga;
        }

        public string Isbn { get { return _isbn; } }
        public string Judul { get { return _judul; } }
        public double Harga { get { return _harga; } }

        public bool IsIsbnMatch(string isbn)
        {
            return _isbn == isbn;
        }

        public string GetInfo()
        {
            return $"ISBN: {_isbn}, Judul: {_judul}, Harga: {_harga}";
        }
    }

    public class TokoBuku
    {
        private List<Buku> _daftarBuku = new List<Buku>();

        public List<Buku> DaftarBuku 
        { 
            get { return _daftarBuku; }
        }

        public void TambahBuku(Buku buku)
        {
            _daftarBuku.Add(buku);
        }

        public bool HapusBuku(string isbn)
        {
            var bukuToRemove = CariBuku(isbn);
            if (bukuToRemove != null)
            {
                return _daftarBuku.Remove(bukuToRemove);
            }
            return false;
        }

        public Buku CariBuku(string isbn)
        {
            return _daftarBuku.FirstOrDefault(buku => buku.IsIsbnMatch(isbn))!;
        }
    }
}