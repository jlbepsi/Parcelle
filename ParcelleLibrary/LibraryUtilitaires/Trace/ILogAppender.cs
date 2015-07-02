using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryUtilitaires.Trace
{
    public interface ILogAppender
    {
        void Write(string level, object message);
    }
}
