namespace WireBraindCoffee.StorageApp.Entities
{
    public class Organization
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public override string ToString() => $"Id :{ID} ,Name: {Name}";


    }

}
