using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution.ElectronicStore
{
  public class Produk
  {
    private string _nama;
    private double _harga;

    public Produk(string nama, double harga)
    {
      _nama = nama;
      _harga = harga;
    }

    public string Nama
    {
      get { return _nama; }
      set { _nama = value; }
    }

    public double Harga
    {
      get { return _harga; }
      set { _harga = value; }
    }
  }

  public class ItemBelanja
  {
    private Produk _produk;
    private int _kuantitas;

    public ItemBelanja(Produk produk, int kuantitas)
    {
      _produk = produk;
      _kuantitas = kuantitas;
    }

    public double HitungTotal()
    {
      return _produk.Harga * _kuantitas;
    }
  }

  public class KeranjangBelanja
  {
    private List<ItemBelanja> _items = new List<ItemBelanja>();

    public List<ItemBelanja> Items
    {
      get { return _items; }
    }

    public void TambahItemBelanja(Produk produk, int kuantitas)
    {
      _items.Add(new ItemBelanja(produk, kuantitas));
    }

    public double HitungTotalBelanja()
    {
      return _items.Sum(item => item.HitungTotal());
    }
  }
}
