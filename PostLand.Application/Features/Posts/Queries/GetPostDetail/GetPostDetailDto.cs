using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queries.GetPostDetail
{
    public class GetPostDetailDto
    {
        public Guid Id { get; set; }
        public string Tital { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }
    }
}
