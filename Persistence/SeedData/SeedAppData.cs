using Domain;

namespace Persistence.SeedData
{
    public static class SeedAppData
    {
        public static async Task SeedAsync(DataContext context)
        {
            var activities = new List<Activity>
            {
                new Activity 
                {
                    Title = "Test Title 1",
                    Description = "Test Description 1",
                    CreatedDate = DateTime.Now,
                    City = "Ctg",
                    Venue = "M Aziz Statium"
                },
                 new Activity 
                {
                    Title = "Test Title 2",
                    Description = "Test Description 2",
                    CreatedDate = DateTime.Now,
                    City = "Ctg",
                    Venue = "Jahour Ahmed Statium"
                }
            };

            if(!context.Activities.Any())
            {
                foreach (var activity in activities)
                {
                    context.Activities.Add(activity);

                }

                await context.SaveChangesAsync();
            }
        }
    }
}