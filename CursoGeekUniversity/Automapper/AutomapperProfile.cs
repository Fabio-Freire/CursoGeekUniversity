using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CursoGeekUniversity.Models;
using CursoGeekUniversity.Models.ModeloDados;

namespace CursoGeekUniversity.Automapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<ClienteModel, ClienteViewModel>().ReverseMap();
        }
    }
}
