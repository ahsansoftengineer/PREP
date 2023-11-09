namespace ProjectAttributeAndReflection.Sections
{

  // Attribute Restriction (Union Enums)
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple =true)]
  public class OursAttribute : Attribute {
    public OursAttribute()
    {
      Console.WriteLine("Ours Attribute");
    }
  }

  [Ours, Yours]
  public class Part6RestrictingAttribute
  {
    //[Ours] Now Cant do that
    public int propertyMine;
    [Ours]
    public static void RunCode()
    {
      Console.WriteLine("Part6RestrictingAttribute");
    }
  }
}
