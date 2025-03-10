using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.BookStore;
using System.Linq;

namespace Solution.BookStore.Tests;

[TestClass]
public class BookStoreTests
{
    [TestMethod]
    public void Buku_Constructor_AssignsValuesCorrectly()
    {
        var buku = new Buku("978-3-16-148410-0", "Test Book", 100.00);
        Assert.AreEqual("978-3-16-148410-0", buku.Isbn);
        Assert.AreEqual("Test Book", buku.Judul);
        Assert.AreEqual(100.00, buku.Harga);
    }

    [TestMethod]
    public void TokoBuku_TambahDanHapusBuku_WorksCorrectly()
    {
        var toko = new TokoBuku();
        var buku = new Buku("978-3-16-148410-1", "Another Test Book", 200.00);

        toko.TambahBuku(buku);
        Assert.AreEqual(1, toko.DaftarBuku.Count);

        var result = toko.HapusBuku("978-3-16-148410-1");
        Assert.IsTrue(result);
        Assert.AreEqual(0, toko.DaftarBuku.Count);
    }

    [TestMethod]
    public void TokoBuku_CariBuku_ReturnsCorrectBook()
    {
        var toko = new TokoBuku();
        var buku1 = new Buku("978-3-16-148410-2", "Book 1", 100.00);
        var buku2 = new Buku("978-3-16-148410-3", "Book 2", 150.00);

        toko.TambahBuku(buku1);
        toko.TambahBuku(buku2);

        var foundBook = toko.CariBuku("978-3-16-148410-3");
        Assert.IsNotNull(foundBook);
        Assert.AreEqual("Book 2", foundBook.Judul);
    }
}
