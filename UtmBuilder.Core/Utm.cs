using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.Extensios;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
    public class Utm
    {
        public Utm(Url url, Campaing campaing)
        {
            Url = url;
            Campaing = campaing;

        } 


        public Url Url { get;}
        public Campaing Campaing { get;}

        public override string ToString()
        {
            var segments = new List<string>();
            segments.AddIfNotNull("utm_source", Campaing.Source);
            segments.AddIfNotNull("utm_medium", Campaing.Medium);
            segments.AddIfNotNull("utm_campaing", Campaing.Name);
            segments.AddIfNotNull("utm_id", Campaing.Id);
            segments.AddIfNotNull("utm_term", Campaing.Term);
            segments.AddIfNotNull("utm_content", Campaing.Content);

            return $"{Url.Address}?{string.Join("&", segments)}";

        }



    }
}
