using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queries.GetPostsList
{
    public class GetPostListDto
    {
        public Guid Id { get; set; }
        public string Tital { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
    }
}
