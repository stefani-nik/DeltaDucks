namespace DeltaDucks.Service
{
    using System.Collections.Generic;
    using Data.Infrastructure;
    using Models;
    using Data.Repositories;

    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        void RegisterUser(User gadget);
        void UpdateUserPassword(string password);
        void LoginUser(string username, string password);
        void SaveUser();
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork )
        {
            this._userRepository = userRepository;
            this._unitOfWork = unitOfWork;
        }

        public IEnumerable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }

        public void UpdateUserPassword(string pasword){ }

        public void LoginUser(string username, string password){  }

        public void RegisterUser (User user)
        {
            _userRepository.Add(user);
        }

        public void SaveUser()
        {
            _unitOfWork.Commit();
        }
    }
}
