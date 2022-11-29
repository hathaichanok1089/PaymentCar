class Payment
{
    public void payment()
    {
        const double car1 = 50.3, car2 = 44.5, car3 = 40, car4 = 95;
        const double ElectricityBill = 4.2;
        double Percentage, number, TotalPrice = 0;

        Console.WriteLine("'Enter the payment process'");
        Console.ReadLine();
        Console.Write("Please Input percent:");
        double.TryParse(Console.ReadLine(), out Percentage);

        Percentage /= 100;

        Console.Write("Please Choose Model :");
        double.TryParse(Console.ReadLine(), out number);
        if (number==1)
        {
            Console.WriteLine("Model is MG EP");
            TotalPrice = Percentage * car1 * ElectricityBill;
        }
        else if (number == 2)
        {
            Console.WriteLine("Model is MG ZS EV");
            TotalPrice = Percentage * car2 * ElectricityBill;
        }
        else if (number == 3)
        {
            Console.WriteLine("Model is Nissan Leaf");
            TotalPrice = Percentage * car3 * ElectricityBill;
        }
        else if (number == 4)
        {
            Console.WriteLine("Model is Audi e-Tron");
            TotalPrice = Percentage * car4 * ElectricityBill;
        }

        Console.Write("TotalPrice : ");
        Console.WriteLine(TotalPrice);
        Console.WriteLine("Pay at Promptpay : 083-089-5092");
        Console.WriteLine("---Thank you for using the service---");
        Console.ReadKey();
    }

    
}