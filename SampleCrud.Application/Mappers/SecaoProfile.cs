using AutoMapper;
using SampleCrud.Application.Dtos;
using SampleCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleCrud.Application.Mappers
{
  public class SecaoProfile : Profile
  {
    public SecaoProfile()
    {
      CreateMap<SecaoEntity, SecaoDto>()
        .ReverseMap();
    }
  }
}
