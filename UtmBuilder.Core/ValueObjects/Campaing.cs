using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    /// <summary>
   /// Generate a New campaing for a URL
/// </summary>
    public class Campaing : ValueObjects
    {
        public Campaing(string source, string medium, string name, string? id = null, string? term = null, string? content = null)
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;

            InvalidCampaingException.ThrowIfNull(source = "Source is Invalid");
            InvalidCampaingException.ThrowIfNull(medium = "Medium is Invalid");
            InvalidCampaingException.ThrowIfNull(name = "Name is Invalid");

        }

        /// <summary>
        /// The ads campaing id.
        /// </summary>
        public string? Id { get;}
        /// <summary>
        /// The referrer (e.g. google, newsletter)
        /// </summary>
        public string Source { get; }
        /// <summary>
        /// Marketing medium 
        /// </summary>
        public string Medium { get; }
        /// <summary>
        /// Product promo code, or slogan
        /// </summary>
        public string Name { get;}
        /// <summary>
        /// Identify the paid keywords
        /// </summary>
        public string? Term { get;}
        /// <summary>
        /// Use to differentiate ads
        /// </summary>
        public string? Content { get;}



    }
}
