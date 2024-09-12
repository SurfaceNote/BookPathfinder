
namespace BookPathfinder.API.Services.Interface
{
    using BookPathfinder.API.Models;

    public interface IProgressService
    {
        Task<IEnumerable<Progress>> GetAllProgressAsync();
        Task<Progress> GetProgressByIdAsync(int progressId);
        Task CreateProgressAsync(Progress progress);
        Task<bool> UpdateProgressAsync(Progress progress);
        Task<bool> DeleteProgressAsync(int progressId);
    }
}
