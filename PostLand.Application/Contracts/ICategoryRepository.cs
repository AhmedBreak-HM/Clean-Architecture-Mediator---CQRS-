using PostLand.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Contracts
{
   public interface ICategoryRepository:IAsyncRepository<Category>
    {
    }
}
