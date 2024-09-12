namespace BookPathfinder.API.Repositories.Interfaces
{
    using BookPathfinder.API.Models;

    public interface IProgressRepository
    {
        Task<IEnumerable<Progress>> GetAllProgressAsync();
        Task<Progress> GetProgressByIdAsync(int id);
        Task CreateProgressAsync(Progress progress);
        Task UpdateProgressAsync(Progress progress);
        Task DeleteProgressAsync(Progress progress);
    }
}
