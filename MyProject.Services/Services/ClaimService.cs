
using AutoMapper;
using MyPeoject.Common;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyPeoject.Common.ClaimDTO;

namespace MyProject.Services.Services
{
   public class ClaimService: IClaimeService
    {

        private readonly IClaimRepository _claimRepository;
        private readonly IMapper _mapper;


        public ClaimService(IClaimRepository context, IMapper mapper)
        {
            _claimRepository = context;
            _mapper = mapper;
        }

        public ClaimDTO Add(int id, int roleId, int permissionId, EPolicyDTO ePolicy)
        {

            return _mapper.Map<ClaimDTO>(_claimRepository.GetById(id));
        }

        public void Delete(int id)
        {
            _claimRepository.Delete(id);
        }

        public List<ClaimDTO> GetAll()
        {
            return _mapper.Map<List<ClaimDTO>>(_claimRepository.GetAll());
        }

        public ClaimDTO GetById(int id)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.GetById(id));
        }

        public ClaimDTO Update(ClaimDTO claim)
        {
            return _mapper.Map<ClaimDTO>(_claimRepository.Update(_mapper.Map < Claim > (claim)));
        }

       
    }
}

