using AutoMapper;
using StockMaster.Communication.Requests;
using StockMaster.Communication.Responses;
using StockMaster.Domain.Entities;

namespace StockMaster.Application.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        RequestToEntity();
        EntityToResponse();
    }
    private void RequestToEntity()
    {   
        CreateMap<RequestRegisterUserJson, User>()
            .ForMember(dest => dest.Password, config => config.Ignore());
    }

    private void EntityToResponse()
    {
        CreateMap<User, ResponseUserProfileJson>();
    }
}
