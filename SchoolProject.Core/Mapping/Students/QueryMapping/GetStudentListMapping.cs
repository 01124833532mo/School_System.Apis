﻿using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile
    {
       public void GetStudentsListMapping()
        {
            CreateMap<Student, GetStudentListResponse>()
               .ForMember(d => d.DepartmentName, o => o.MapFrom(src => src.Department.Name));
        }
    }
}