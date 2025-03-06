using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;

		public CreateCategoryCommandHandler(MovieContext context)
		{
			_context = context;
		}
		public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
		{
			var category = new Category
			{
				CategoryName = request.CategoryName
			};
			_context.Categories.Add(category);
			await _context.SaveChangesAsync();
			return category.CategoryId;
		}
	}
}
