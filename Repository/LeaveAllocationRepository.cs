using Leave_Management.Contracts;
using Leave_Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {

        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            var leaveAllocated = _db.LeaveAllocations.ToList();
            return leaveAllocated;
        }

        public LeaveAllocation FindById(int Id)
        {
            var leaveAsigned = _db.LeaveAllocations.Find(Id);
            return leaveAsigned;
        }

        public bool IsExist(int Id)
        {
            var exists = _db.LeaveTypes.Any(q => q.Id == Id);
            return exists;
        }


        public bool Save()
        {
            var changes =_db.SaveChanges();
            return changes > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}
