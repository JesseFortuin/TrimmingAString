using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrimmingAString.BL
{
    public interface IStringLengthChecker
    {
        public string TrimString(string phrase, int len);
    }
}
