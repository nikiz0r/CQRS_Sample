﻿using SimpleCqrs.Commanding;
using System;

namespace CQRS_Sample.Contracts.Commands
{
    public class CreateMovieCommand : ICommand
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int RunningTimeMinutes { get; set; }

        public CreateMovieCommand(string title, DateTime releaseDate, int runningTimeMinutes)
        {
            Title = title;
            ReleaseDate = releaseDate;
            RunningTimeMinutes = runningTimeMinutes;
        }
    }
}
