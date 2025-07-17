

using AlignTech.CommonLibrary;

namespace AlignTech.CSharp.Day2
{
    internal class AccessModifier :AccessModifiers //Default Internal Access Modifier or Declare public class
    {
      public void GetData()
        {
            AccessModifiers obj=new AccessModifiers();
            obj.name = "John"; // Accessible
            companyName = "TechCorp"; // Accessible due to internal modifier
            salary = 2000;
        }
    }
}
