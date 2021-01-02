using BrainStationExam.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainStationExam.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly ExamContext _context;

        public ReportRepository(ExamContext context)
        {
            _context = context;
        }
        public async Task<Post> GetPostById(int id)
        {
            return await _context.Posts.Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Post>> GetPosts()
        {
            return await _context.Posts.Include(e => e.Comments).ToListAsync();
        }

        public async Task<List<Comment>> GetAllComents()
        {
            return await _context.Comments.ToListAsync();
        }
    }
}
