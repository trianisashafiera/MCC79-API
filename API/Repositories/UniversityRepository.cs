﻿using API.Contracts;
using API.Data;
using API.Models;

namespace API.Repositories
{
    public class UniversityRepository : IUniversityRepository
    {
        private readonly BookingDbContext _context;
        public UniversityRepository(BookingDbContext context)
        {
            _context = context;
        }

        public ICollection<University> GetAll()
        {
            return _context.Set<University>().ToList();
        }

        public University? GetByGuid(Guid guid)
        {
            return _context.Set<University>().Find(guid);
        }

        public University Create(University university)
        {
            try
            {
                _context.Set<University>().Add(university);
                _context.SaveChanges();
                return university;
            }
            catch 
            {
                return new University();
            }
        }

        public bool Update(University university)
        {
            try
            {
                _context.Set<University>().Update(university);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(Guid guid)
        {
            try
            {
                var university = GetByGuid(guid);
                if (university is null)
                {
                    return false;
                }
                _context.Set<University>().Remove(university);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
