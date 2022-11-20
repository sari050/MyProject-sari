using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPeoject.Common
{
    public class ClaimDTO
    {
        public enum EPolicyDTO { Allow, Deny }
        
            public int Id { get; set; }

            public int RoleId { get; set; }

            public int PermissionId { get; set; }

            public EPolicyDTO Policy { get; set; }
        
    }
}
