using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyPeoject.Common;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using MyProject.Services.Interfaces;
using MyProject.webAPI.Modes;
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
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        [HttpGet]
        public async Task<List<RoleDTO>> Get()
        {
            return await _roleService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<RoleDTO> Get(int id)
        {
            return await _roleService.GetByIdAsync(id);
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _roleService.DeleteAsync(id);
        }
        [HttpPut("{id},{name},{d}")]
        public async Task<RoleDTO> Put(int id, string name, string d)
        {
            var r = _roleService.UpdateAsync(new RoleDTO { Id = id, Name = name, Description = d });
            return r.Result;
        }
        [HttpPost]
        public async Task<RoleDTO> Post([FromBody] RoleModel model)
        {
            //var roleTask1 = _roleService.AddAsync(new RoleDTO());
            //var roleTask2 = _roleService.AddAsync(new RoleDTO());
            //var roleTask3 = _roleService.AddAsync(new RoleDTO());

            //await Task.WhenAll(roleTask1, roleTask2);
            //var x = await roleTask3;
            //return roleTask1.Result;

        }

        //     [HttpPost]
        //public async Task<RoleDTO> Post([FromBody] RoleModel model)
        //{
        //    var roleTask1 = _roleService.AddAsync(new RoleDTO());
        //    var roleTask2 = _roleService.AddAsync(new RoleDTO());
        //    var roleTask3 = _roleService.AddAsync(new RoleDTO());

        //    await Task.WhenAll(roleTask1, roleTask2);
        //    var x = await roleTask3;
        //    return roleTask1.Result;
        //}

    }
}
