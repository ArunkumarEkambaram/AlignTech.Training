using AlignTech.CSharp.Day4;

Customer customer= new Customer();
customer.FirstName = "";
customer.Price = 0;
customer.Age = 500;

//customer.Salary = 500;
//customer.Shipping = 500;

//Object Initializer
Customer customer2 = new Customer
{
    FirstName = "Pradeep",
    Age = 20,
    Price = 500,
    Shipping = 60,
};