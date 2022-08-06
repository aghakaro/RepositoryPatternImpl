using System;
using System.Collections.Generic;
using AutoMapper;
using Contracts.Interfaces;
using Domain.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public OwnerController(IRepositoryWrapper repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllOwners()
        {
            try
            {
                var owners = _repository.Owner.GetAllOwners();
                var ownersResult = _mapper.Map<IEnumerable<OwnerDto>>(owners);
                return Ok(ownersResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        
        [HttpGet]
        public IActionResult GetOwnerByName(string name)
        {
            try
            {
                var owner = _repository.Owner.GetOwnerByName(name);
                var ownerResult = _mapper.Map<OwnerDto>(owner);
                return Ok(ownerResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}