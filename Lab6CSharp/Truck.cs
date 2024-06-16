class Truck : Transport
{
    public bool HasTrailer { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Trailer: {HasTrailer}");
    }

    public override int CargoCapacity
    {
        get { return HasTrailer ? base.CargoCapacity * 2 : base.CargoCapacity; }
    }
}