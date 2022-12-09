using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StringManager
    {
        private const string PHRASE = "The Force is strong with you!";
        private StringBuilder _sb;
        internal string _prefix = string.Empty;
        internal string _phraseUnique = string.Empty;
        internal int _phraseLength = 0;

        public StringManager()
        {
            _prefix = $"[{DateTime.UtcNow}] [{Environment.CurrentManagedThreadId}] ";

            _phraseUnique = $"{_prefix}{PHRASE}";
            _phraseLength = _phraseUnique.Length;
            
            _sb = new(_phraseLength); 
            _sb.Append(_phraseUnique);

        }

      
        public string Option1ToString()
        {
            return _sb.ToString();
        }

      
        public char[] Option2CopyTo()
        {
            var option2Buffer = new char[_phraseLength];

            _sb.CopyTo(sourceIndex: 0,
                      destination: option2Buffer.AsSpan(),
                      count: _phraseLength);

            return option2Buffer;

        }

      
        public ReadOnlySpan<char> Option3ReadOnlyMemoryCharGetChunks()
        {
            //https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.getchunks?view=net-6.0
            ReadOnlySpan<char> _span = null;
            
            foreach (ReadOnlyMemory<char> chunk in _sb.GetChunks())
            {
                _span = chunk.Span;
            }

            return _span;
        }
    }
}
