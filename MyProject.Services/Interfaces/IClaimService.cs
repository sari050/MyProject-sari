using MyPeoject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyPeoject.Common.ClaimDTO;

namespace MyProject.Services.Interfaces
{

    public interface IClaimeService
    {
        Task<List<ClaimDTO>> GetAllAsync();

        Task<ClaimDTO> GetByIdAsync(int id);

        Task<ClaimDTO> AddAsync(int id, int roleId, int permissionId, EPolicyDTO ePolicy);

        Task<ClaimDTO> UpdateAsync(ClaimDTO claim);

        Task DeleteAsync(int id);
    }

}
