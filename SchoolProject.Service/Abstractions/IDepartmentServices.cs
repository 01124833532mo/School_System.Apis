﻿using SchoolProject.Data.Entities;

namespace SchoolProject.Service.Abstractions
{
    public interface IDepartmentServices
    {
        public Task<Department> GetDepartmentById(int id);
    }
}