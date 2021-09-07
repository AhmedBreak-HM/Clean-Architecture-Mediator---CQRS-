using AutoMapper;
using PostLand.Application.Features.Posts.Commands.CreatePost;
using PostLand.Application.Features.Posts.Commands.UpdatePost;
using PostLand.Application.Features.Posts.Queries.GetPostDetail;
using PostLand.Application.Features.Posts.Queries.GetPostsList;
using PostLand.Domain;

namespace PostLand.Application.Profiles
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, GetPostListDto>().ReverseMap();
            CreateMap<Post, GetPostDetailDto>();
            CreateMap<CreatePostCommand, Post>();
            CreateMap<UpdatePostCommand, Post>();
        }
    }
}
