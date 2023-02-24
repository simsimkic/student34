﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KlinikaZdravo.Exception
{
    class EntityNotFoundException : System.Exception
    {
        public EntityNotFoundException()
        {

        }

        public EntityNotFoundException(string message) : base(message)
        {

        }

        public EntityNotFoundException(string message, System.Exception inner) : base(message, inner)
        {

        }
    }
}
