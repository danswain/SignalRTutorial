using System.Collections.Generic;
using SignalR.Hubs;
using SignalRTutorial.Models;

namespace SignalRTutorial.Hubs
{
    public class ScrumBoardHub : Hub
    {
        private readonly IScrumRepository _repository;

        public ScrumBoardHub():this(new ScrumBoardRepository()){}

        public ScrumBoardHub(IScrumRepository repository)
        {
            _repository = repository;
        }
       
        public void CreateStory(StoryCard story)
        {
            Caller.AddedStory(story);
        }

        public void GetStories()
        {
            var storyCards = new List<StoryCard>()
                                 {
                                     new StoryCard
                                         {
                                             Id = 1, Title = "Story 1", Description = "Story 1 desc", State = StoryState.Todo
                                         }, new StoryCard
                                                {
                                                    Id = 2, Title = "Story 2", Description = "Story 2 desc", State = StoryState.Todo
                                                },
                                 };
            var array = storyCards.ToArray();
            Caller.populateStories( array);
        }
    }
}