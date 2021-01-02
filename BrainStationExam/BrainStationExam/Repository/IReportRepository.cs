using BrainStationExam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainStationExam.Repository
{
    public interface IReportRepository
    {
        Task<List<Post>> GetPosts();
        Task<Post> GetPostById(int id);
    }
}
