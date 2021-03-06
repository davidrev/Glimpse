﻿using System;
using System.Reflection;
using Glimpse.Core.Message;

namespace Glimpse.Mvc.Message
{
    public interface IExecutionMessage : ITimerResultMessage
    {
        bool IsChildAction { get; }

        Type ExecutedType { get; }

        MethodInfo ExecutedMethod { get; } 
    }
}