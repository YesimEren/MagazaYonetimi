using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAL
{
    public interface ILogger
    {
        void Error(string message);
        void Information(string message);
        void Warning(string message);
    }
}
