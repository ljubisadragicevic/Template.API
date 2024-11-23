using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Mapper
{
    public class Logic2ServiceMapping : Profile
    {
        public Logic2ServiceMapping()
        {
            CreateMap<Template.Logic.Model.ClientResponse, Template.Service.Model.ClientResponse>();
        }
    }
}
