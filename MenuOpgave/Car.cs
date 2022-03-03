namespace MenuOpgave;

class Car
{
    public string Model { get; set; }
    public string Make { get; set; }
    public decimal Price { get; set; }
    public override string ToString()
    {
        return $"--  {Make} {Model} {Price}  --";
    }
}
