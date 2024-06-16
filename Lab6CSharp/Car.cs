class Car : Transport
{
    public int CargoCapacity { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Cargo Capacity: {CargoCapacity}");
    }
}