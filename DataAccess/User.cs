using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    partial class tb_users {
        private string[] admins = new string[] { "Admin" };
        public bool IsAdmin {
            get => admins.Contains(tb_groups.groupName);
        }
    }
}
