using SignalRTutorial.Hubs;

namespace SignalRTutorial.Models
{
    public class StoryCard
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public StoryState State { get; set; }

        public int Id { get; set; }

        public static StoryCard Create(string title, string description, StoryState storyState)
        {
            return new StoryCard
                       {
                           Id=1,
                           Title = title,
                           Description = description,
                           State = storyState
                       };
        }
    }
}