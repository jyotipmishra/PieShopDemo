namespace PieShop
{
	using System.IO;
	using Microsoft.AspNetCore.Hosting;
	using Microsoft.Extensions.Hosting;

	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
					webBuilder.UseStartup<Startup>();
					webBuilder.UseIISIntegration();
				});
	}
}
