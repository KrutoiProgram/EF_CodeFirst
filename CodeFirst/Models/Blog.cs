using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Blog
    {
        [Key]
        public int BlodId { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Author { get; set; }
        public DateTime DateCreate { get; set; }

        public List<Post> Posts { get; set; }
    }
}
