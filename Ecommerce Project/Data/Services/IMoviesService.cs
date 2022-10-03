using Ecommerce_Project.Data.Base;
using Ecommerce_Project.Data.ViewModels;
using Ecommerce_Project.Models;

namespace Ecommerce_Project.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}