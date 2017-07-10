using CQRS_Sample.Application.ReadModel;
using CQRS_Sample.Contracts.Events;
using SimpleCqrs.Eventing;

namespace CQRS_Sample.Application.EventHandlers
{
    public class MovieEventHandler : IHandleDomainEvents<MovieCreatedEvent>
    {
        public void Handle(MovieCreatedEvent createdEvent)
        {
            using (MoviesReadModel entities = new MoviesReadModel())
            {
                entities.Movies.Add(new Movie()
                {
                    Id = createdEvent.AggregateRootId,
                    Title = createdEvent.Title,
                    ReleaseDate = createdEvent.ReleaseDate,
                    RunningTimeMinutes = createdEvent.RunningTimeMinutes
                });

                entities.SaveChanges();
            }
        }
    }
}
