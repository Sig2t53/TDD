using System;
using System.Runtime.Serialization;

namespace TDD.UI
{
    public sealed class InputException : Exception
    {
        public InputException(string message) : base(message)
        {
        }
    }
}