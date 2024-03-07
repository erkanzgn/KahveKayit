using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concretes;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCutomerManager(new MernisServiceAdapters());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2004, 5, 1), FirstName = "Erkan", LastName = "Özgün", NationalityId = "1" });
            Console.ReadLine();
        }
    }
}
