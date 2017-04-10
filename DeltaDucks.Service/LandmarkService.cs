namespace DeltaDucks.Service
{
    using Data.Infrastructure;
    using Data.Repositories;
    using Models;

    public interface ILandmarkService
    {
        Landmark GetLandmarkById(int id);
    }

    public class LandmarkService : ILandmarkService
    {
        private readonly IRepository<Landmark> _landmarkRepository;

        // NOT USED YET 
        //private readonly IUnitOfWork _unitOfWork;

        public LandmarkService(IRepository<Landmark> irepository , IUnitOfWork unitOfWork)
        {
            this._landmarkRepository = irepository;
            //this._unitOfWork = unitOfWork;
        }


        public Landmark GetLandmarkById(int id)
        {
            return _landmarkRepository.GetById(id);
        }

    }
}
