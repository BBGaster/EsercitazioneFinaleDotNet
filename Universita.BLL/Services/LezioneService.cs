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
    public class LezioneService : GenericService<Lezione,LezioneModel>, ILezioneServices
    {
        public LezioneService(ILezioneRepository repository, IMapper mapper) : base(repository, mapper) { }
    }
}
