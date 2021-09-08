using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLand.Application.Features.Categories.Command.CreateCategory
{
   public class CreateCategoryCommand:IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
