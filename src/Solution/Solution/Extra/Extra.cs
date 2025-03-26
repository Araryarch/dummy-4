using System;
using System.Collections.Generic;

namespace Solution.Extra
{
  public class Karakter
  {
    private string _nama;
    private int _level;
    private int _kesehatan;

    public Karakter(string nama)
    {
      _nama = nama;
      _level = 1;
      _kesehatan = 100;
    }

    public string Nama { get { return _nama; } }
    public int Level { get { return _level; } set { _level = value; } }
    public int Kesehatan { get { return _kesehatan; } set { _kesehatan = value; } }

    public string GetInfo()
    {
      return $"Nama: {_nama}, Level: {_level}, Kesehatan: {_kesehatan}";
    }

    public void NaikLevel()
    {
      _level++;
      _kesehatan += 20;
    }
  }

  public class Senjata
  {
    private string _nama;
    private int _damage;

    public Senjata(string nama, int damage)
    {
      _nama = nama;
      _damage = damage;
    }

    public string Nama { get { return _nama; } }
    public int Damage { get { return _damage; } }

    public string GetInfo()
    {
      return $"Senjata: {_nama}, Damage: {_damage}";
    }
  }

  public class Tim
  {
    private List<Karakter> _daftarKarakter = new List<Karakter>();
    private List<Senjata> _daftarSenjata = new List<Senjata>();

    public void TambahKarakter(Karakter karakter)
    {
      if (_daftarKarakter.Count < 4)
      {
        _daftarKarakter.Add(karakter);
      }
    }

    public void TambahSenjata(Senjata senjata)
    {
      if (_daftarSenjata.Count < _daftarKarakter.Count)
      {
        _daftarSenjata.Add(senjata);
      }
    }

    public void TampilkanInfoTim()
    {
      Console.WriteLine("Informasi Tim:");
      for (int i = 0; i < _daftarKarakter.Count; i++)
      {
        Console.WriteLine(_daftarKarakter[i].GetInfo());
        if (i < _daftarSenjata.Count)
        {
          Console.WriteLine(_daftarSenjata[i].GetInfo());
        }
        Console.WriteLine("---");
      }
    }
  }
}
