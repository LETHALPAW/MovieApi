using Microsoft.EntityFrameworkCore;
using MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults;
using MovieApi.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class GetMovieQueryHandler
    {
		private readonly MovieContext _context;

		public GetMovieQueryHandler(MovieContext context)
		{
			_context = context;
		}

		public async Task<List<GetMovieQueryResults>> Handle()
		{
			var values = await _context.Movies.ToListAsync();
			return values.Select(x => new GetMovieQueryResults
			{
				MovieId = x.MovieId,
				CoverImageUrl  = x.CoverImageUrl,
				CreatedDate = x.CreatedDate,
				Description = x.Description,
				Duration = x.Duration,
				ReleaseDate = x.ReleaseDate,
				Status = x.Status,
				Rating = x.Rating,
				MovieTitle = x.MovieTitle
				
			}).ToList();
		}
	}
}
