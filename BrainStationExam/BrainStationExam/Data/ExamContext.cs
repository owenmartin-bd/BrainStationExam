using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainStationExam.Data
{
    public class ExamContext : DbContext
    {
        public ExamContext(DbContextOptions<ExamContext> options)
            :base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
