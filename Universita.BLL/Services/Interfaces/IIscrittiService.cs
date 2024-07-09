using Universita.BLL.Models;

namespace Universita.BLL.Services.Interfaces
{
    public interface IIscrittiService : IGenericService<IscrittiModel>
    {
        bool Delete(int studenteMatricola, int corsoId);

        IscrittiModel GetById(int studenteMatricola, int corsoId);

        List<IscrittiModel> GetByCorso(int corsoId);
    }
}
