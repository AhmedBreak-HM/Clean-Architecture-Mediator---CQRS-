using Microsoft.EntityFrameworkCore;
using PostLand.Application.Contracts;
using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Persistence.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        private readonly ApplicationContext _context;

        public PostRepository(ApplicationContext context):base(context)
        {
            _context = context;
        }
        public async Task<IReadOnlyList<Post>> GetAllPostAsync(bool incloudCategory)
        {
            var Posts = incloudCategory?
                await _context.Posts.Include(p => p.Category).ToListAsync()
              : await _context.Posts.ToListAsync();
            return Posts;
        }

        public async Task<Post> GetPostByIdAsync(Guid id, bool incloudCategory)
        {
            var post = incloudCategory?
                  await _context.Posts.Include(p =>p.Category).FirstOrDefaultAsync(p => p.Id ==id)
                : await _context.Posts.FirstOrDefaultAsync(p => p.Id == id);
            return post;
        }
    }
}
