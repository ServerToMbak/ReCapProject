﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers
{
    public class GuidAdder
    {
        public static string CreateHelper()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
