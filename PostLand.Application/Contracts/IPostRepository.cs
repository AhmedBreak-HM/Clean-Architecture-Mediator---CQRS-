using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Contracts
{
    public interface IPostRepository:IAsyncRepository<Post>
    {
        Task<IReadOnlyList<Post>> GetAllPostAsync(bool incloudCategory);
        Task<Post> GetPostByIdAsync(Guid id, bool incloudCategory);
    }
}
