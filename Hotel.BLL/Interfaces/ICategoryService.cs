using Hotel.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.BLL.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetAll();

        CategoryDTO Get(int id);

        void Create(CategoryDTO item);

        void Delete(int id);

        void Update(int id, CategoryDTO item);
    }
}
