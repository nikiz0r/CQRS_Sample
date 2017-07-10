using System;
using CQRS_Sample.Application.Enums;
using CQRS_Sample.Contracts.Commands;
using SimpleCqrs.Commanding;
using CQRS_Sample.Application.ReadModel;

namespace CQRS_Sample.Application.CommandHandlers
{
    public class CreateMovieCommandHandler : CommandHandler<CreateMovieCommand>
    {
        protected IDomainRepository _repository;

        public CreateMovieCommandHandler(IDomainRepository repository)
        {
            _repository = repository;
        }

        public override void Handle(CreateMovieCommand command)
        {
            Return(ValidateCommand(command));

            var location = new Movie(Guid.NewGuid(), command.Title, command.ReleaseDate, command.RunningTimeMinutes);

            _repository.Save(location);
        }

        protected CreateMovieStatus ValidateCommand(CreateMovieCommand command)
        {
            return CreateMovieStatus.Successful;
        }
    }
}
