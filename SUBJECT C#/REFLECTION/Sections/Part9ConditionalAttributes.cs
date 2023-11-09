#define PreProcessor_Conditional_Function
using System.Diagnostics;

namespace ProjectAttributeAndReflection.Sections
{
  class Part9Cow
  {
    // Can't use on top of the property
    public string id {
      [DebuggerStepThrough] // Excluding Code in Debugging
      get { return "Anything "; } 
    }
    public string name { get; set; }
  }
  internal class Part9ConditionalAttributes
  {
    public static void RunCode()
    {
      // The Compiler will Remove it when the define is not Found
      TraceDebuggingStuff();
    }
    // This will Work if #define is availaible on Top
    [Conditional("PreProcessor_Conditional_Function")]
    private static void TraceDebuggingStuff()
    {
      Console.WriteLine("PreProcessor_Conditional_Function, Use full For Tracing");
    }
  }
}
