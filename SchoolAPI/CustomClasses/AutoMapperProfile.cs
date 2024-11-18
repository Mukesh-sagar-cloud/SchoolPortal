using SchoolAPI.Models;
using AutoMapper;
using SchoolAPI.CustomClasses;

namespace SchoolAPI.CustomClasses
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Map DepartmentDto to DeptMaster and vice versa
            CreateMap<DepartmentDto, DeptMaster>();
            CreateMap<DeptMaster, DepartmentDto>();
        }
    }
}
