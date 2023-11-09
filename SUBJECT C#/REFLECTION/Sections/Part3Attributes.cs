namespace ProjectAttributeAndReflection.Sections
{
  // Passing Properties, and Arguments to Attribute
  class MeAttribute : Attribute
  {
    public MeAttribute(int Age, string Name)
    {
      Console.WriteLine("MeAttribute() Age {0} Name {1}", Age, Name);
    }
    public char SomeCharProp { get; set; }  
    public int SomeIntProp { get; set; }
  }
  [Me(25, "Ahsan", SomeCharProp = 'j', SomeIntProp = 72)]
  public class Part3Attributes
  {
    public static void RunCode()
    {
      // To call the MeAttribute Constructor
      typeof(Part3Attributes).GetCustomAttributes(false);

    }
  }
}
