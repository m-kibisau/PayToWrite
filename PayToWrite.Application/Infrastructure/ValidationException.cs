﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PayToWrite.Application.Infrastructure
{
    public class ValidationException:Exception
    {
        public string Property { get; protected set; }
        public ValidationException(string message, string property) : base(message)
        {
            Property = property;
        }
    }
}
