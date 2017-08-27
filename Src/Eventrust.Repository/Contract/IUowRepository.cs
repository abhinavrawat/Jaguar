namespace Eventrust.Repository.Contract
{
    public interface IUowRepository
    {
        IUserRepository UserRepository { get; }
    }
}
