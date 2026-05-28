public class Perro: Animal
{
    public string Duenio { get; set; }
    public string años { get; set; }

    
    public override void MakeSound()
    {
        Console.WriteLine("Wuau");
    }
}