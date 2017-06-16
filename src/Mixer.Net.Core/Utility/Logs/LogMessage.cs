﻿using System;

namespace Mixer
{
    public struct LogMessage
    {
        public LogSeverity Level { get; }
        public string Source { get; }
        public string Message { get; }
        public Exception Exception { get; }

        public LogMessage(LogSeverity level, string source, string message, Exception ex = null)
        {
            Level = level;
            Source = source;
            Message = message;
            Exception = ex;
        }

        public override string ToString()
            => $"[{Level}] {Source}: {(Exception?.ToString() ?? Message)}";
    }
}
