namespace Infrastructure.Persistence.Ef.Context
{
    public class DbInitialData
    {
        private readonly ApplicationDbContext _dbContext;

        public DbInitialData(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            InitialGateway();
            _dbContext.SaveChanges();
        }


        private void InitialGateway()
        {
            //TODO: Initial Data
        }
    }
}
