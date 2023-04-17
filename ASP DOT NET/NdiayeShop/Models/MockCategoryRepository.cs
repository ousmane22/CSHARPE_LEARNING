namespace NdiayeShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Fruit Pies",Description="All Fruits Pies"},

                new Category{CategoryId=2,CategoryName="Cheese Cakes",Description="Cheese Cakes"},

                new Category{CategoryId=3,CategoryName="Seasonal Pie",Description="All Seasonal Pies"},
            };
    }
}
