using System.Linq;

namespace FootballApp.Api.Database
{
    public class DbIniatializer
    {
        public static void Initialize(FootballAppContext context)
        {
            context.Database.EnsureCreated();

            if (context.PostedLinks.Any())
            {
                return;
            }

            foreach (var postedLink in StaticDataDbInitializer.InitializePostedLinks())
            {
                context.PostedLinks.Add(postedLink);
            }
            context.SaveChanges();
        }
    }
}
