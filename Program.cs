namespace DZ_CS_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPhone phones =
                new Phones(
                new Phone[]
                {
                    new Phone("Iphone 10", "Apple", 500, new DateTime(2020, 5, 15)),
                    new Phone("Samsung S20", "Samsung", 350, new DateTime(2020,10,25)),
                    new Phone("Redmi 10", "Xiaomi", 600, new DateTime(2021, 2, 14)),
                    new Phone("ThinkPhone 8", "Motorola", 1000, new DateTime(2023, 2, 18)),
                    new Phone("Blade V40", "ZTE", 150, new DateTime(2020, 5, 15)),
                    new Phone("G11", "Nokia", 120, new DateTime(2018, 4, 10)),
                    new Phone("Hot 20", "Infinix", 100, new DateTime(2019, 10, 25)),
                    new Phone("Samsung S10", "Samsung", 300, new DateTime(2020,10,25)),
                    new Phone("Iphone 10", "Apple", 500, new DateTime(2020, 5, 15)),
                    new Phone("Samsung S20", "Samsung", 350, new DateTime(2020,10,25)),
                    new Phone("Redmi 10", "Xiaomi", 600, new DateTime(2021, 2, 14)),
                    new Phone("ThinkPhone 8", "Motorola", 1000, new DateTime(2023, 2, 18))
                });

            Ex1(phones);
            //Ex2(phones);
            //Ex3(phones);

        }
        static void Ex1(IPhone phones)
        {
            phones.PhonesAmount();
            phones.PhonesAmountPriceMoreThan100();
            phones.PhonesAmountPriceFrom400To700();
            phones.NumberOfPhonesOfConcreteProducer("Samsung");
            phones.PhoneWithMinimalPrice();
            phones.PhoneWithMaximalPrice();
            phones.OldestPhone();
            phones.NewestPhone();
            phones.AveragePhonePrice();
        }

        static void Ex2(IPhone phones)
        {
            phones.FiveHighCostPhones();
            phones.FiveLowCostPhones();
            phones.ThreeOldestPhones();
            phones.ThreeNewestPhones();  
        }

        static void Ex3(IPhone phones)
        {
            phones.AmountOfConcreteProducerPhones();
            phones.NumberOfEachPhoneModel();
            phones.StatsOfEachPhoneProduceYear();
        }
    }
}