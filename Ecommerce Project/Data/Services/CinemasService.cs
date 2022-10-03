using Ecommerce_Project.Data.Base;
using Ecommerce_Project.Models;

namespace Ecommerce_Project.Data.Services
{

    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
