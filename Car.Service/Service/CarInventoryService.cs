using AutoMapper;
using Car.Core.Entities;
using Car.Core.Interfaces;
using Car.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Service.Service
{
    public class CarInventoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CarInventoryService(
            IUnitOfWork unitOfWork,
            IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CarInventoryDTO>> GetProjectAsync()
        {
            var projects = await _unitOfWork.Projects.GetAll();
            return _mapper.Map<IEnumerable<CarInventoryDTO>>(projects);
        }
        public async Task<bool> InsertAsync(CarInventoryDTO projectDTO)
        {
            var project = _mapper.Map<CarInventory>(projectDTO);
            return await _unitOfWork.Projects.Add(project);
        }
        public async Task<int> CompletedAsync()
        {
            return await _unitOfWork.CompletedAsync();
        }
    }
}
