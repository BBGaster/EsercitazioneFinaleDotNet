using AutoMapper;
using Universita.BLL.Models;
using Universita.DAL.Entityes;


namespace Universita.PL.Configuration
{
    public class AutoMapperConfiguration : Profile
    {

        public AutoMapperConfiguration()
        {

            CreateMap<Aula,AulaModel>().ReverseMap();
            CreateMap<Corso,CorsoModel>().ReverseMap();
            CreateMap<Docente, DocenteModel>().ReverseMap();
            CreateMap<Iscritti, IscrittiModel>().ReverseMap();
            CreateMap<Lezione, LezioneModel>().ReverseMap();
            CreateMap<Studente, StudenteModel>().ReverseMap();
            
        }
    }
}
