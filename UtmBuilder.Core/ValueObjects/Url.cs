using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">Address of URL (WebSite Link)</param>
    public class Url : ValueObjects
    {

        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalid(address);
        }

        /// <summary>
        /// Address of URL (Website  Link)
        /// </summary>
       
        public string Address { get;}



    }
}
