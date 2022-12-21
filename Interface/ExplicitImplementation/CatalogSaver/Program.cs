namespace CatalogSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            // ISaveable saveable = new Catalog();
            //saveable.Save();

            Catalog catalog = new Catalog();
            ((ISaveable)catalog).Save();
        }
    }
}
