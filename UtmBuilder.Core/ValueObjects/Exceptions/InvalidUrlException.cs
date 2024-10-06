using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public class InvalidUrlException : Exception
    {
        private const string DefaultErrorMessage = "Invalid URL";

        public InvalidUrlException(string message = DefaultErrorMessage)
        : base(message)
        {

        }

        public static void ThrowIfInvalid(string address, string message = DefaultErrorMessage)
        {
            if (string.IsNullOrEmpty(address))

                throw new InvalidUrlException(message);

            if (!UrlRegex().IsMatch(address))

                throw new InvalidUrlException();


        }

        [GeneratedRegex(
        pattern: @"^(?:https?:\/\/)?(w{3}\.)?[\w_-]+((\.\w{2,}){1,2})(\/([\w\._-]+\/?)*(\?[\w_-]+=[^\?\/&]*(\&[\w_-]+=[^\?\/&]*)*)?)?$")]
        private static partial Regex UrlRegex();

    }
}
