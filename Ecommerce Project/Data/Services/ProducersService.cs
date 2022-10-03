using Ecommerce_Project.Data.Base;
using Ecommerce_Project.Models;

namespace Ecommerce_Project.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
