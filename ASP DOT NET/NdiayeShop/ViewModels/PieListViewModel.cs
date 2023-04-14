using NdiayeShop.Models;

namespace NdiayeShop.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string? CurrentCategory { get; set; }


        public PieListViewModel(IEnumerable<Pie> pie , string? currentCategory) 
        {
            Pies = pie ;
            CurrentCategory = currentCategory;
        }
    }


}
