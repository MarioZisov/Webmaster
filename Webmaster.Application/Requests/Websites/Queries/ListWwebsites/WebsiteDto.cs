﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Webmaster.Application.Requests.Websites.Queries.ListWwebsites
{
    public class WebsiteDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public int CategoryId { get; set; }

        public string Category { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ImageBase64 { get; set; }
    }
}
