using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public List<int> PermissionIds { get; set; }
    }
}