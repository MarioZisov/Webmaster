﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Webmaster.Application.Domain.Constraints
{
    public class WebsiteConstraints
    {
        public static readonly int MAX_NAME_LENGHT = 50;

        public static readonly int MIN_URL_LENGHT = 4;

        public static readonly int MAX_URL_LRNGHT = 1000;

        public static readonly string URL_REGEX = @"^[-a-zA-Z0-9@:%._\+~#=]{1,190}\.[a-zA-Z0-9()]{1,9}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]{0,800})$";

        public static readonly int MAX_IMAGE_PATH_LENGHT = 2000;

        public static readonly int MIN_EMAIL_LENGHT = 8;

        public static readonly int MAX_EMAIL_LENGHT = 100;

        public static readonly int MIN_PASSWORD_LENGHT = 8;

        public static readonly int MAX_PASSWORD_LENGHT = 100;
    }
}
