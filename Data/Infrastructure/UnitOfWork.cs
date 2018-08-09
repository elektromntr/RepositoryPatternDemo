namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private RepoPatternDemoEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public RepoPatternDemoEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbContext.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
