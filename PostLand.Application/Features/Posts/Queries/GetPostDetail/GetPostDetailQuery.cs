using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Posts.Queries.GetPostDetail
{
   public class GetPostDetailQuery:IRequest<GetPostDetailDto>
    {
        public Guid PostId { get; set; }
    }
}
