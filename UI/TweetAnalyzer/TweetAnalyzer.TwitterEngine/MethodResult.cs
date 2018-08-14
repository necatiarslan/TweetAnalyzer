using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetAnalyzer.TwitterEngine
{
    public class MethodResult<T>
    {
        public T Result { get; set; }
        public Exception Exception { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
