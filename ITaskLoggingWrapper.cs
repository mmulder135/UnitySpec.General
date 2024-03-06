﻿namespace UnityFlow.SpecFlow
{
    public interface ITaskLoggingWrapper
    {
        void LogMessage(string message);

        void LogMessageWithLowImportance(string message);

        void LogError(string message);

        bool HasLoggedErrors();
    }
}
