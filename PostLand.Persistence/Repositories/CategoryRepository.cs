using PostLand.Application.Contracts;
using PostLand.Domain;

namespace PostLand.Persistence.Repositories
{
    public class CategoryRepository:BaseRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
