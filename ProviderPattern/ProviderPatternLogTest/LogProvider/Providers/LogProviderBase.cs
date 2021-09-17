﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration.Provider;

namespace ProviderPatternLogTest.LogProvider.Providers
{
    public abstract class LogProviderBase : ProviderBase
    {

        public virtual void SetParameters(NameValueCollection config)
        {

        }

        public virtual void Info(string message)
        {
            WriteLog(LogType.Info, message);
        }

        public virtual void Warning(string message)
        {
            WriteLog(LogType.Warning, message);
        }

        public virtual void Error(string message)
        {
            WriteLog(LogType.Error, message);
        }

        public abstract void WriteLog(LogType logType, string message);
        
    }
}
