using DeltaDucks.Data.Infrastructure;
using DeltaDucks.Data.Repositories;
using DeltaDucks.Models;
using DeltaDucks.Service.Interfaces;

namespace DeltaDucks.Service.Services
{
    public class LandmarkService : ILandmarkService
    {
        private readonly ILandmarkRepository _landmarkRepository;

        // NOT USED YET 
        //private readonly IUnitOfWork _unitOfWork;

        public LandmarkService(ILandmarkRepository landmarkRepository, IUnitOfWork unitOfWork)
        {
            this._landmarkRepository = landmarkRepository;
            //this._unitOfWork = unitOfWork;
        }


        public Landmark GetLandmarkById(int id)
        {
            return _landmarkRepository.GetById(id);
        }

    }
}
