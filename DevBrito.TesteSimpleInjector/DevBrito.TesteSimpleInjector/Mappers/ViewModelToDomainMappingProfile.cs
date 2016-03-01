﻿using AutoMapper;
using DevBrito.TesteSimpleInjector.Models;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBrito.TesteSimpleInjector.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<MarcaViewModel, Marca>();
        }
    }
}
