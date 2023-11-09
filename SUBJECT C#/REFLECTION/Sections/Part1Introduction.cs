using System.Reflection;

namespace ProjectAttributeAndReflection.Sections
{
  public class TestAttribute : Attribute { }
  public class TestMethodAttribute : Attribute { }
  [TestAttribute]
  public class MyTestSuite 
  {
    public void HelperMethod()
    {
      Console.WriteLine("This method will never be invoked because it doesn't has TestMethod Attribute");
    }
    [TestMethod]
    public void MyTest1()
    {
      Console.WriteLine(nameof(MyTest1));
    }
    [TestMethod]
    public void MyTest2()
    {
      Console.WriteLine(nameof(MyTest2));
    }
  }
  public class Part1Introduction
  {
    public static void RunCode3()
    {
      var testSuites = 
        from t in Assembly.GetExecutingAssembly().GetTypes()
        where t.GetCustomAttributes(false)
        .Any(a => a is TestAttribute)
        select t;
      foreach (Type t in testSuites)
      {
        Console.WriteLine("Running tests in suite: " + t.Name);
        var testMethods = from m in t.GetMethods()
                          where m.GetCustomAttributes(false)
                          .Any(a => a is TestMethodAttribute)
                          select m;
        object testSuiteInstance = Activator.CreateInstance(t);
        foreach (MethodInfo methodInfo in testMethods)
        {
          methodInfo.Invoke(testSuiteInstance, new object[0]);
        }
      }
    }
    public static void RunCode2()
    {
      var testSuits = from t in Assembly.GetExecutingAssembly().GetTypes()
                      where t.GetCustomAttributes(false)
                      .Any(a => a is TestAttribute)
                      select t;
      foreach (var item in testSuits)
      {
        Console.WriteLine(item.Name + " is a test suite!");
      }
    }
    // Iterating on Current Assembly and Get Attributes
    // Foreach Example
    public static void RunCode1()
    {
      foreach (Type t in Assembly.GetExecutingAssembly().GetTypes())
      {
        // If you set it to true then it will get other attributes as well
        foreach (Attribute a in t.GetCustomAttributes(false))
        {
          if(a is TestAttribute)
          {
            Console.WriteLine(t.Name + " is a test suite!");
          }
        }
      }
    }
  }

}
