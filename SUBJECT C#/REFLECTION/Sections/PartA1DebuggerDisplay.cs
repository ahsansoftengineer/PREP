using System.Diagnostics;

namespace ProjectAttributeAndReflection.Sections
{
  [DebuggerDisplay("{Name} is {Age} years Old")]
  public class A1Employee
  {
    public string Name = "Ahsan";
    public int Age = 31;
  }
  public static class PartA1DebuggerDisplay
  {
    public static void RunCode()
    {
      var emp = new A1Employee();
      Console.WriteLine(emp.Name +  " " + emp.Age);

    }
  }
}
