using FileUtilities.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUtilities
{
    public interface ILog
    {
        event EventHandler<string> LogInfo;
        event EventHandler<string> LogWarn;
        event EventHandler<LogFoundArgs> LogFound;
        event EventHandler RememberScrollLocation;
        event EventHandler ScrollToStart;
        event EventHandler ScrollToBottom;
    }
}
