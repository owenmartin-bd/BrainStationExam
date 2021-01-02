using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainStationExam.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime PostDate { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
