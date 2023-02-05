using BulkyBook2.DataAccess.Data;
using BulkyBook2.DataAccess.Repository.IRepository;
using BulkyBook2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BulkyBook2.DataAccess.Repository
{
    public class CategoryReposirory : Repository<Category>, ICategoryReposirory
    {
        private readonly ApplicationDbContext _db;

        public CategoryReposirory(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void UpDate(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);

            if (objFromDb!=null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }
        }
    }
}
