using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
        public RoleController(IRoleRepository roleRepository)
        {

            _roleRepository = roleRepository;
        }
        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetAll();
        }
        [HttpGet("{id}")]
        public Role Get(int id)
        {
            return _roleRepository.GetById(id);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _roleRepository.Delete(id);
        }
        [HttpPut("{id},{name},{d}")]
        public Role Put(int id,string name,string d)
        {
            Role r = new Role() { Id = id, Name = name, Description = d };
            return _roleRepository.Update(r);
        }
    }
}
