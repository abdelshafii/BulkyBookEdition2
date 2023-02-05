using BulkyBook2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook2.DataAccess.Repository.IRepository
{
    public interface ICategoryReposirory : IRepository<Category>
    {
        void UpDate(Category category);
    }
}
