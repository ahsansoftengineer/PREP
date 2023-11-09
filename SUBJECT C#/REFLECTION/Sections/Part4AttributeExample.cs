using System.Runtime.Serialization.Formatters.Binary;

namespace ProjectAttributeAndReflection.Sections
{
  [Serializable]
  public class Cow
  {
    public string Name;
    public int Weight;

  }
  public class Part4AttributeExample
  {
    public static void RunCode()
    {
      var betsy = new Cow() { Name = "Betsy", Weight = 1 };

      var formatter = new BinaryFormatter();
      var memoryStream = new MemoryStream();
      formatter.Serialize(memoryStream, betsy);
      memoryStream.Seek(0, SeekOrigin.Begin);
      var betsyClone = formatter.Deserialize(memoryStream) as Cow;
      Console.WriteLine(betsyClone.Name + "-" + betsyClone.Weight);
    }
  }
}
