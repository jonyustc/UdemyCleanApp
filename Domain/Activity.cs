using System;

namespace Domain
{
    public class Activity
    {
        public Activity()
        {
            CreatedDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Category { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
    }
}