using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universita.BLL.Models;
using Universita.BLL.Services.Interfaces;
using Universita.DAL.Entityes;
using Universita.DAL.Repository.Interfaces;

namespace Universita.BLL.Services
{
    public class IscrittiService :GenericService<Iscritti,IscrittiModel>, IIscrittiService
    {
        IIscrittiRepository _repository;
        IMapper _mapper;
        public IscrittiService(IIscrittiRepository repository, IMapper mapper) : base(repository, mapper) {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof( mapper));
        }

        public bool Delete(int studenteMatricola, int corsoId)
        {
            if (studenteMatricola <= 0 )
            {
                throw new ArgumentException("Invalid studenteMatricola", nameof(studenteMatricola));
            }
            if (corsoId <= 0)
            {
                throw new ArgumentException("Invalid corsoId", nameof(corsoId));
            }
            try
            {
                return _repository.Delete(studenteMatricola,corsoId);
            }
            catch (KeyNotFoundException ex)
            {
                // Log exception (ex) here
                throw new KeyNotFoundException("Entity not found.", ex);
            }
            catch (Exception ex)
            {
                // Log exception (ex) here
                throw new Exception("An error occurred while deleting the entity.", ex);
            }
        }

        public List<IscrittiModel> GetByCorso(int corsoId)
        {
            if (corsoId <= 0)
            {
                throw new ArgumentException("Invalid id", nameof(corsoId));
            }

            try
            {
                return _mapper.Map<List<IscrittiModel>>(_repository.GetById(corsoId));
            }
            catch (KeyNotFoundException ex)
            {
                // Log exception (ex) here
                throw new KeyNotFoundException("Entity not found.", ex);
            }
            catch (Exception ex)
            {
                // Log exception (ex) here
                throw new Exception("An error occurred while retrieving the entity.", ex);
            }
        }

        public IscrittiModel GetById(int studenteMatricola, int corsoId)
        {
            if (studenteMatricola <= 0)
            {
                throw new ArgumentException("Invalid studenteMatricola", nameof(studenteMatricola));
            }
            if (corsoId <= 0)
            {
                throw new ArgumentException("Invalid corsoId", nameof(corsoId));
            }

            try
            {
                return _mapper.Map<IscrittiModel>(_repository.GetById(studenteMatricola, corsoId));
            }
            catch (KeyNotFoundException ex)
            {
                // Log exception (ex) here
                throw new KeyNotFoundException("Entity not found.", ex);
            }
            catch (Exception ex)
            {
                // Log exception (ex) here
                throw new Exception("An error occurred while retrieving the entity.", ex);
            }
        }
    }
}
