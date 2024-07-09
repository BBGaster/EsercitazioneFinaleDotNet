using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universita.BLL.Services.Interfaces
{
    public interface IGenericService<Model>
    {
        bool Create(Model model);
        Model Update(Model model);
        bool Delete(int id);
        IList<Model> GetAll();
        Model GetById(int id);
    }
}
