﻿using System;
using AutoMapper;
using RccManager.Domain.Dtos.DecanatoSetor;
using RccManager.Domain.Dtos.ParoquiaCapela;
using RccManager.Domain.Entities;

namespace RccManager.Application.Mapper;

public class DtoToEntityProfile : Profile
{
    public DtoToEntityProfile()
    {
        CreateMap<DecanatoSetor, DecanatoSetorDto>()
            .ReverseMap();

        CreateMap<ParoquiaCapela, ParoquiaCapelaDto>()
            .ReverseMap();
    }
}
