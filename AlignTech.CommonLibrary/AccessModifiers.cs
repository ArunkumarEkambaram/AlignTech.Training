namespace AlignTech.CommonLibrary
{
    public class AccessModifiers //Default Internal Access Modifier or Declare public class
    {
        public string name;
        private int age; //Private Access Modifier  
         protected int salary; //Protected Access Modifier
        protected internal string companyName; //Internal Access Modifier
    }

    internal class ChildClass : AccessModifiers
    {
        public void GetData()
        {
            // age = 200; // Not accessible, private to AccessModifiers
            name = "John"; // Accessible
            salary = 50000; // Accessible due to inheritance
            companyName = "TechCorp"; // Accessible due to internal modifier
        }
    }

    class TestClass
    {
        public void GetData()
        {
            AccessModifiers obj = new AccessModifiers();
            obj.name = "Alice"; // Accessible
            obj.companyName = "TechCorp"; // Accessible due to internal modifier            
        }

    }
}
