using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solution.Computers;

namespace Solution.Computers.Tests;

[TestClass]
public class ComputerTests
{
    [TestMethod]
    public void Processor_SetGet_ReturnsCorrectValues()
    {
        var processor = new Processor("AMD", 4.0);
        Assert.AreEqual("AMD", processor.Brand);
        Assert.AreEqual(4.0, processor.Speed);
    }

    [TestMethod]
    public void Memory_SetGet_ReturnsCorrectValues()
    {
        var memory = new Memory(8, "DDR4");
        Assert.AreEqual(8, memory.Capacity);
        Assert.AreEqual("DDR4", memory.MemoryType);
    }

    [TestMethod]
    public void Computer_GetInfo_ReturnsCorrectInformation()
    {
        var processor = new Processor("Intel", 3.5);
        var memory = new Memory(16, "DDR4");
        var computer = new Computer(processor, memory);

        string expectedInfo = "Processor Brand: Intel, Kecepatan: 3.5 GHz, Memory Kapasitas: 16 GB, Tipe: DDR4";
        Assert.AreEqual(expectedInfo, computer.GetInfo());
    }
}
