﻿using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using ProviderPatternLogTest.LogProvider.Providers;

namespace ProviderPatternLogTest.LogProvider
{
    public class LogProviderCollection : ProviderCollection
    {
        new public LogProviderBase this[string name]
        {
            get { return (LogProviderBase)base[name]; }
        }
    }
}
