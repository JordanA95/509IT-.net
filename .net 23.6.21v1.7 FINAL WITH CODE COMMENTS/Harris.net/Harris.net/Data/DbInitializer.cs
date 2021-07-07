﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Harris.net.Data
{
    //Database initialiser which ininitialises the HarrisDbContext.
    public class DbInitializer
    {
        public static void Initialize(HarrisDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}