using SimpleCqrs.Eventing;
using System;

namespace CQRS_Sample.Contracts.Events
{
    public class MovieCreatedEvent : DomainEvent
    {
        public Guid MovieId
        {
            get { return AggregateRootId; }
            set { AggregateRootId = value; }
        }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTimeMinutes { get; set; }

        public MovieCreatedEvent(Guid movieId, string title, DateTime releaseDate, int runningTimeMinutes)
        {
            MovieId = movieId;
            Title = title;
            ReleaseDate = releaseDate;
            RunningTimeMinutes = runningTimeMinutes;
        }
    }
}
