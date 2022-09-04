namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {

        ITestRepository TestRepository { get; }
        int Complete();
    }
}
