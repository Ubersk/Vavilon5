using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vavilon.Domain.Entities;
using Vavilon.Infrastructure.Persistece;

namespace Vavilon.Presentation.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public List<Product> Products { get; set; }
        public MainWindowViewModel()
        {
            using(ApplicationDbContext context = new ApplicationDbContext())
            {
                Products = context.Products
                    .ToList();
            }
        }
    }
}
