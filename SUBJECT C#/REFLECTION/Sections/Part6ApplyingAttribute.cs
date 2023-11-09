namespace ProjectAttributeAndReflection.Sections
{
  // Applying Attribute at different Level
  public class YoursAttribute : Attribute { }

  [Yours]
  public class Part6ApplyingAttribute
  {
    public int YoursProperty {
      [Yours] get { return 5; } 
    }

    [Yours]
    public event Action YoursEvent;

    [Yours]
    [return : Yours]

    int YoursMethod([Yours] int YoursParameter)
    {
      return YoursParameter;
    }
  }
}
