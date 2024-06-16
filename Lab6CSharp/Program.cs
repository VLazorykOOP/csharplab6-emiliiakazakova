class Program
{
    static void Main()
    {
        // Приклад використання класів і методів
        Mammal lion = new Mammal { Name = "Lion" };
        lion.DisplayUserInfo();
        lion.GiveBirth();
        lion.UseDotNetFeature();

        Bird eagle = new Bird { Name = "Eagle" };
        eagle.DisplayUserInfo();
        eagle.Fly();
        eagle.UseDotNetFeature();

        DotNetUser user = new DotNetUser();
        user.DisplayUserInfo();
        user.UseDotNetFeature();

        Console.WriteLine("\n\nTask2\n\n");

        // Приклад використання класів і методів
        Car car = new Car { Brand = "Toyota", Number = "AB1234", Speed = 120, CargoCapacity = 500 };
        car.DisplayInfo();
        car.UseDotNetFeature();

        Motorcycle motorcycle = new Motorcycle { Brand = "Harley", Number = "XY5678", Speed = 80, HasSidecar = true };
        motorcycle.DisplayInfo();
        motorcycle.UseDotNetFeature();

        Truck truck = new Truck { Brand = "Volvo", Number = "CD9012", Speed = 90, HasTrailer = true };
        truck.DisplayInfo();
        truck.UseDotNetFeature();
    }
}