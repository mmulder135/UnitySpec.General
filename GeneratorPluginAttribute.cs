﻿using System;

namespace UnityFlow.General
{
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
    public class GeneratorPluginAttribute : Attribute
    {
        public Type PluginType { get; }

        public GeneratorPluginAttribute(Type pluginType)
        {
            PluginType = pluginType ?? throw new ArgumentNullException(nameof(pluginType));
        }
    }
}
