using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.BLL.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int Bed { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is CategoryDTO)
            {
                var objCM = obj as CategoryDTO;
                return this.CategoryName == objCM.CategoryName
                    && this.Bed == objCM.Bed;
            }
            else return base.Equals(obj);
        }
    }

}
