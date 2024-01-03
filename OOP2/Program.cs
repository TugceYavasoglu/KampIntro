using System;

namespace OOP2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Individual individual = new Individual();
            individual.Id = 1;
            individual.CustomerId = "12345";
            individual.CustomerName = "Tuğçe";
            individual.CustomerSurname = "Yavaşoğlu";
            individual.IdentificationNumber = "12345678910";

            Coorporate coorporate = new Coorporate();
            coorporate.Id = 2;
            coorporate.CustomerId = "54321";
            coorporate.CompanyName = "Kodlama.io";
            coorporate.TaxNumber = "1234567890";


            //Gerçek Müşteri - Tüzel Müşteri 
            //SOLID

            Customer customer = new Individual();
            Customer customer1 = new Coorporate();
            
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individual);
            customerManager.Add(coorporate);

        }
    }
}
