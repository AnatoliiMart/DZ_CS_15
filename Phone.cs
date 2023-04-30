using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DZ_CS_15
{
    internal class Phone
    {
        public string PhoneModel { get; private set; }
        public string Producer { get; private set; }
        public double Price { get; private set; }
        public DateTime DateOfIssue { get; private set; }

        public Phone(string PhoneModel, string Producer, double Price, DateTime DateOfIssue)
        {
            this.PhoneModel = PhoneModel;
            this.Producer = Producer;
            this.Price = Price;
            this.DateOfIssue = DateOfIssue;            
        }
        public Phone()
        {
            PhoneModel = "NoModel";
            Producer = "NoProducer";
            Price = 0;
            DateOfIssue = new DateTime();
        }
        public override string ToString()
        {
            return $"****************************\n" +
                   $"Phone model:\t{PhoneModel}\n" +
                   $"Phone producer:\t{Producer}\n" +
                   $"Phone price:\t{Price}$\n" +
                   $"Date of issue:\t{DateOfIssue.ToShortDateString()}";
        }
    }

    internal class Phones: IPhone
    {
        public Phone[] phones;
        public Phones(Phone[] phones) => this.phones = phones;

        public void AmountOfConcreteProducerPhones()
        {
            var res = from phone in phones
                      group phone by phone.Producer;
            Console.WriteLine("Statistics on the number of phones of each manufacturer:");
            foreach (var item in res)
            {
                Console.Write(item.Key + " - ");
                foreach (var item1 in item)
                {
                    Console.WriteLine(item.Count());
                    break;
                }
                Console.WriteLine("---------------------------------------");
            }

        }

        public void FiveHighCostPhones()
        {
            var res = from phone in phones
                      orderby phone.Price descending
                      select phone;
            int count = 5;
            Console.WriteLine("Five phones with highest price:");
            foreach (var item in res)
                if (count > 0)
                {
                    Console.WriteLine(item.ToString());
                    count--;
                }
            Console.WriteLine("---------------------------------------");
        }

        public void FiveLowCostPhones()
        {
            var res = from phone in phones
                      orderby phone.Price
                      select phone;
            int count = 5;
            Console.WriteLine("Five phones with lowest price:");
            foreach (var item in res)
                if (count > 0)
                {
                    Console.WriteLine(item.ToString());
                    count--;
                }
            Console.WriteLine("---------------------------------------");
        }

        public void AveragePhonePrice()
        {
            double price = 0;
            foreach (var item in phones)
                price += item.Price;
            price /= phones.Length;
            Console.WriteLine($"Average price of a phone: {Math.Round(price, 3)}$");
            Console.WriteLine("---------------------------------------");
        }

        public void NewestPhone()
        {
            var res = from phone in phones
                      orderby phone.DateOfIssue descending
                      select phone;
            Console.WriteLine("The newest phone:");
            foreach (var item in res)
            {
                Console.WriteLine(item.ToString());
                break;
            }
            Console.WriteLine("---------------------------------------");
        }

        public void NumberOfEachPhoneModel()
        {
            var res = from phone in phones
                      group phone by phone.PhoneModel;
            Console.WriteLine("Statistics on the number of phones of each model:");
            foreach (var item in res)
            {
                Console.Write(item.Key + " - ");
                foreach (var item1 in item)
                {
                    Console.WriteLine(item.Count());
                    break;
                }
                Console.WriteLine("---------------------------------------");
            }
        }

        public void NumberOfPhonesOfConcreteProducer(string producer)
        {
           var res = from phone in phones
                     where phone.Producer == producer
                     select phone;
            Console.WriteLine($"Amount phones of producer {producer} is: {res.Count()}");
            Console.WriteLine("---------------------------------------");
        }

        public void OldestPhone()
        {
            var res = from phone in phones
                      orderby phone.DateOfIssue
                      select phone;
            Console.WriteLine("The oldest phone");
            foreach (var item in res)
            {
                Console.WriteLine(item.ToString());
                break;
            }
            Console.WriteLine("---------------------------------------");
        }

        public void PhonesAmount() => Console.WriteLine($"Amount of phones: {phones.Length}\n" +
                                                        $"---------------------------------------");

        public void PhonesAmountPriceFrom400To700()
        {
            var res = from phone in phones
                      where phone.Price > 400 && phone.Price < 700
                      select phone;
            Console.WriteLine($"Amount of phones with price from 400 to 700: {res.Count()}");
            Console.WriteLine("---------------------------------------");
        }

        public void PhonesAmountPriceMoreThan100()
        {
            var res = from phone in phones
                      where phone.Price > 100
                      select phone;
            Console.WriteLine($"Amount of phones with price more than 100: {res.Count()}");
            Console.WriteLine("---------------------------------------");
        }

        public void PhoneWithMaximalPrice()
        {
            var res = from phone in phones
                      orderby phone.Price descending
                      select phone;
            Console.WriteLine("Phone with maximal price:");
            foreach (var item in res)
            {
                Console.WriteLine(item.ToString());
                break;
            }
            Console.WriteLine("---------------------------------------");
        }

        public void PhoneWithMinimalPrice()
        {
            var res = from phone in phones
                      orderby phone.Price descending
                      select phone;
            Console.WriteLine("Phone with minimal price:");
            foreach (var item in res)
            {
                Console.WriteLine(item.ToString());
                break;
            }
            Console.WriteLine("---------------------------------------");
        }

        public void StatsOfEachPhoneProduceYear()
        {
            var res = from phone in phones
                      group phone by phone.DateOfIssue.Year;
            Console.WriteLine("Phone statistics by year:");
            foreach (var item in res)
            {
                Console.Write(item.Key + " - ");
                foreach (var item1 in item)
                {
                    Console.WriteLine(item.Count());
                    break;
                }
                Console.WriteLine("---------------------------------------");
            }
        }

        public void ThreeNewestPhones()
        {
            var res = from phone in phones
                      orderby phone.DateOfIssue descending
                      select phone;
            int count = 3;
            Console.WriteLine("Three newest phones:");
            foreach (var item in res)
                if (count > 0)
                {
                    Console.WriteLine(item.ToString());
                    count--;
                }
            Console.WriteLine("---------------------------------------");
        }

        public void ThreeOldestPhones()
        {
            var res = from phone in phones
                      orderby phone.DateOfIssue 
                      select phone;
            int count = 3;
            Console.WriteLine("Three oldest phones:");
            foreach (var item in res)
                if (count > 0)
                {
                    Console.WriteLine(item.ToString());
                    count--;
                }
            Console.WriteLine("---------------------------------------");
        }
    }
    interface IPhone
    {
        void PhonesAmount();
        void PhonesAmountPriceMoreThan100();
        void PhonesAmountPriceFrom400To700();
        void AmountOfConcreteProducerPhones();
        void PhoneWithMinimalPrice();
        void PhoneWithMaximalPrice();
        void OldestPhone();
        void NewestPhone();
        void AveragePhonePrice();
        void FiveLowCostPhones();
        void FiveHighCostPhones();
        void ThreeOldestPhones();
        void ThreeNewestPhones();
        void NumberOfPhonesOfConcreteProducer(string producer);
        void NumberOfEachPhoneModel();
        void StatsOfEachPhoneProduceYear();

    }
}
