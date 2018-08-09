using System;

namespace Data
{
    public interface IDbFactory : IDisposable
    {
        RepoPatternDemoEntities Init();
    }
}
