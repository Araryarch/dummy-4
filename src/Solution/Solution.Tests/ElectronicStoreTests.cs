using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.ElectronicStore;
using System.Collections.Generic;

namespace Solution.ElectronicStore.Tests;

[TestClass]
public class ElectronicStoreTests
{
    [TestMethod]
    public void Produk_SetGet_ReturnsCorrectValues()
    {
        var produk = new Produk("TV", 1200.00);
        Assert.AreEqual("TV", produk.Nama);
        Assert.AreEqual(1200.00, produk.Harga);
    }

    [TestMethod]
    public void ItemBelanja_HitungTotal_ReturnsCorrectTotal()
    {
        var produk = new Produk("Laptop", 1000.00);
        var item = new ItemBelanja(produk, 2);
        Assert.AreEqual(2000.00, item.HitungTotal());
    }

    [TestMethod]
    public void KeranjangBelanja_TambahDanHitungTotalBelanja_ReturnsCorrectTotal()
    {
        var keranjang = new KeranjangBelanja();
        keranjang.TambahItemBelanja(new Produk("Smartphone", 500.00), 2);
        keranjang.TambahItemBelanja(new Produk("Headset", 100.00), 3);

        Assert.AreEqual(1300.00, keranjang.HitungTotalBelanja());
    }

    [TestMethod]
    public void KeranjangBelanja_JumlahItems_ReturnsCorrectCount()
    {
        var keranjang = new KeranjangBelanja();
        keranjang.TambahItemBelanja(new Produk("Smartphone", 500.00), 1);
        keranjang.TambahItemBelanja(new Produk("Tablet", 800.00), 1);

        Assert.AreEqual(2, keranjang.Items.Count);
    }
}
