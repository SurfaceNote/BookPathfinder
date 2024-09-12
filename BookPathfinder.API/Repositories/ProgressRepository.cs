
namespace BookPathfinder.API.Repositories
{
    using BookPathfinder.API.Data;
    using BookPathfinder.API.Models;
    using BookPathfinder.API.Repositories.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ProgressRepository : IProgressRepository
    {
        private readonly AppDbContext _context;

        public ProgressRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateProgressAsync(Progress progress)
        {
            await _context.Progresses.AddAsync(progress);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProgressAsync(Progress progress)
        {
            _context.Progresses.Remove(progress);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Progress>> GetAllProgressAsync()
        {
            return await _context.Progresses.Include(p => p.Book).Include(p => p.User).ToListAsync();
        }

        public async Task<Progress> GetProgressByIdAsync(int id)
        {
            return await _context.Progresses.Include(p => p.Book).Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateProgressAsync(Progress progress)
        {
            _context.Progresses.Update(progress);
            await _context.SaveChangesAsync();
        }
    }
}
