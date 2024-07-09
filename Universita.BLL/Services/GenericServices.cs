using AutoMapper;
using Universita.BLL.Services.Interfaces;
using Universita.DAL.Repository.Interfaces;

namespace Universita.BLL.Services
{
    public class GenericService<T, TModel> : IGenericService<TModel> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<T> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public bool Create(TModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            try
            {
                return _repository.Create(_mapper.Map<T>(model));
            }
            catch (Exception ex)
            {
                // Log exception (ex) here
                throw new Exception("An error occurred while creating the entity.", ex);
            }
        }

        public TModel Update(TModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            try
            {
               var input = _mapper.Map<T>(model);
                return _mapper.Map<TModel>( _repository.Update(input));
            }
            catch (Exception ex)
            {
                // Log exception (ex) here
                throw new Exception("An error occurred while updating the entity.", ex);
            }
        }

        public bool Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id", nameof(id));
            }

            try
            {
                return _repository.Delete(id);
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

        public IList<TModel> GetAll()
        {
            try
            {
                var entity = _repository.GetAll();

                return _mapper.Map<IList<TModel>>(entity);
            }
            catch (Exception ex)
            {
                // Log exception (ex) here
                throw new Exception("An error occurred while retrieving the entities.", ex);
            }
        }

        public TModel GetById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id", nameof(id));
            }

            try
            {
                return _mapper.Map<TModel>(_repository.GetById(id));
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
