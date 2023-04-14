namespace NdiayeShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }

    }
}
