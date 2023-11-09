namespace ProjectAttributeAndReflection.Sections
{
  class AbAttribute : Attribute {
    public AbAttribute()
    {
      Console.WriteLine("AbAttribute");
    }
  }

  [Ab]
  public class Base { }
  public class Derived: Base { }
  public class Part6Attribute_Inheritance
  { 
    public static void RunCode()
    {
      //typeof(Derived).GetCustomAttributes(true).P();

      // Parent Class Attribute
      Console.WriteLine(typeof(Derived).IsDefined(typeof(AbAttribute), true));
      //Console.WriteLine(typeof(Derived).IsEnum);
      //Console.WriteLine(typeof(Derived).IsClass);
      //Console.WriteLine(typeof(Derived).IsCollectible);
      //Console.WriteLine(typeof(Derived).IsInterface);
      
    }
  }
}
