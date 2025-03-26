using System;

namespace Solution.Computers
{
  public class Processor
  {
    private string _brand;
    private double _speed;

    public Processor(string brand, double speed)
    {
      _brand = brand;
      _speed = speed;
    }

    public string Brand
    {
      get { return _brand; }
      set { _brand = value; }
    }

    public double Speed
    {
      get { return _speed; }
      set { _speed = value; }
    }
  }

  public class Memory
  {
    private int _capacity;
    private string _memoryType;

    public Memory(int capacity, string memoryType)
    {
      _capacity = capacity;
      _memoryType = memoryType;
    }

    public int Capacity
    {
      get { return _capacity; }
      set { _capacity = value; }
    }

    public string MemoryType
    {
      get { return _memoryType; }
      set { _memoryType = value; }
    }
  }

  public class Computer
  {
    private Processor _processor;
    private Memory _memory;

    // Constructor
    public Computer(Processor processor, Memory memory)
    {
      _processor = processor;
      _memory = memory;
    }

    public Processor Processor
    {
      get { return _processor; }
      set { _processor = value; }
    }

    public Memory Memory
    {
      get { return _memory; }
      set { _memory = value; }
    }

    public string GetInfo()
    {
      return $"Processor Brand: {_processor.Brand}, Kecepatan: {_processor.Speed} GHz, " +
             $"Memory Kapasitas: {_memory.Capacity} GB, Tipe: {_memory.MemoryType}";
    }
  }
}