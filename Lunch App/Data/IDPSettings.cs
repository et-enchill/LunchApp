﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch_App.Data
{
    public class IDPSettings
    {

        public static IDPSettings Current;

        public IDPSettings()
        {
            Current = this;
        }

        public string LunchAppUrl { get; set; }
        public string Authority { get; set; }
        public string ApiId { get; set; }
        public string TokenUrl { get; set; }
        public string AuthorityURL { get; set; }
        public string ClientId { get; set; }
        public string Secret { get; set; }
        public string AppServerLocalUrl { get; set; }
        public string RequireHttpsMetadata { get; set; }
        public string signOutURL { get; set; }
        public string AppName { get; set; }

    }
}
