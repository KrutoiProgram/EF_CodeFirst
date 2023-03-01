using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(900)]
        public string Text { get; set; }

        public DateTime PostTime { get; set; }

        public bool isPublished { get; set; }

        public Blog Blog { get; set; }
    }
}
