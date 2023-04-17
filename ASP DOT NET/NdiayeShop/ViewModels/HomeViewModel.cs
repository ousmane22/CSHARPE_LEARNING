using NdiayeShop.Models;

namespace NdiayeShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfWeeks { get; }

        public HomeViewModel(IEnumerable<Pie> pies) 
        {
            PiesOfWeeks = pies;
        }
    }
}
