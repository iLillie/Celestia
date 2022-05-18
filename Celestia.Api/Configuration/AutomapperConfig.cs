using AutoMapper;
using Celestia.Models;
using Celestia.Models.Dtos.Company;
using Celestia.Models.Dtos.Job;

namespace Celestia.Api.Configuration;

public class AutomapperConfig : Profile
{
    public AutomapperConfig()
    {
        CreateMap<Job, JobAddDto>().ReverseMap();
        CreateMap<Job, JobEditDto>().ReverseMap();
        CreateMap<Job, JobResultDto>().ReverseMap();
        CreateMap<Company, CompanyAddDto>().ReverseMap();
        CreateMap<Company, CompanyEditDto>().ReverseMap();
        CreateMap<Company, CompanyResultDto>().ReverseMap();
    }
}