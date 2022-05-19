using AutoMapper;
using Celestia.Models;
using Celestia.Models.Dtos.Company;
using Celestia.Models.Dtos.Contact;
using Celestia.Models.Dtos.Folder;
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
        CreateMap<Contact, ContactAddDto>().ReverseMap();
        CreateMap<Contact, ContactEditDto>().ReverseMap();
        CreateMap<Contact, ContactResultDto>().ReverseMap();
        CreateMap<Folder, FolderAddDto>().ReverseMap();
        CreateMap<Folder, FolderEditDto>().ReverseMap();
        CreateMap<Folder, FolderResultDto>().ReverseMap();
    }
}