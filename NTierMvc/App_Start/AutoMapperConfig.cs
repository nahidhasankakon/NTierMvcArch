using AutoMapper;
using NTierMvc.DAL;
using NTierMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierMvc.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Employee, EmployeeVm>());
        }
    }
}