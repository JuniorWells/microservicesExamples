using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace PlatformService.Data
{
	public static class PrepDb
	{
		public static void PrepPopulation(IApplicationBuilder app)
		{
			using ( var serviceScope = app.ApplicationServices.CreateScope())
			{

			}
		}

		private static void SeedData(AppDbContext context)
		{
			
		}
	}
}