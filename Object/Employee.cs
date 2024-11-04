using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.Object
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
