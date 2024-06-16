class Motorcycle : Transport
{
    public bool HasSidecar { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar: {HasSidecar}");
    }

    public override int CargoCapacity
    {
        get { return HasSidecar ? 0 : base.CargoCapacity; }
    }
}
