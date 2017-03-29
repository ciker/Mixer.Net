﻿using System;
using System.Threading.Tasks;

namespace Beam.Rest
{
    public partial class BaseRestClient
    {
        internal readonly AsyncEvent<Func<LogMessage, Task>> logEvent = new AsyncEvent<Func<LogMessage, Task>>();
        public event Func<LogMessage, Task> Log
        {
            add { logEvent.Add(value); }
            remove { logEvent.Remove(value); }
        }

        internal readonly AsyncEvent<Func<Task>> loggedInEvent = new AsyncEvent<Func<Task>>();
        public event Func<Task> LoggedIn
        {
            add { loggedInEvent.Add(value); }
            remove { loggedInEvent.Remove(value); }
        }
    }
}
