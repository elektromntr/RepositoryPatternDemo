﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        RepoPatternDemoEntities dbContext;

        public RepoPatternDemoEntities Init()
        {
            return dbContext ?? (dbContext = new RepoPatternDemoEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
