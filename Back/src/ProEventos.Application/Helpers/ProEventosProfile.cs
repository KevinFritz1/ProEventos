using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProEventos.Application.Dtos;
using ProEventos.Domain;

namespace ProEventos.Application.Helpers
{
    public class ProEventosProfile : Profile
    {
        
        public ProEventosProfile()
        {
            CreateMap<Evento, EventoDto>();
            CreateMap<EventoDto, Evento>();

            CreateMap<Lote, LoteDto>();
            CreateMap<LoteDto, Lote>();

            CreateMap<RedeSocial, RedeSocialDto>();
            CreateMap<RedeSocialDto, RedeSocial>();
        }
    }
}