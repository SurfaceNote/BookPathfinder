namespace BookPathfinder.API.Services
{
    using BookPathfinder.API.Models;
    using BookPathfinder.API.Repositories.Interfaces;
    using BookPathfinder.API.Services.Interface;

    public class ProgressService : IProgressService
    {
        private readonly IProgressRepository _progressRepository;

        public ProgressService(IProgressRepository progressRepository)
        {
            _progressRepository = progressRepository;
        }

        public async Task<IEnumerable<Progress>> GetAllProgressAsync()
        {
            return await _progressRepository.GetAllProgressAsync();
        }

        public async Task<Progress> GetProgressByIdAsync(int progressId)
        {
            return await _progressRepository.GetProgressByIdAsync(progressId);
        }

        public async Task CreateProgressAsync(Progress progress)
        {
            await _progressRepository.CreateProgressAsync(progress);
        }

        public async Task<bool> UpdateProgressAsync(Progress progress)
        {
            var existingProgress = await _progressRepository.GetProgressByIdAsync(progress.Id);
            if (existingProgress == null)
            {
                return false;
            }

            existingProgress.StartDate = progress.StartDate;
            existingProgress.EndDate = progress.EndDate;
            existingProgress.LastUpdated = DateTime.Now;
            existingProgress.Book = progress.Book;
            existingProgress.User = progress.User;
            existingProgress.BookId = progress.BookId;
            existingProgress.UserId = progress.UserId;


            await _progressRepository.UpdateProgressAsync(existingProgress);
            return true;
        }

        public async Task<bool> DeleteProgressAsync(int progressId)
        {
            var progress = await _progressRepository.GetProgressByIdAsync(progressId);
            if (progress == null)
            {
                return false;
            }

            await _progressRepository.DeleteProgressAsync(progress);
            return true;
        }
    }
}
