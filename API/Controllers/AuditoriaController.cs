using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Controllers;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAnimals.Controllers
{
    public class AuditoriaController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuditoriaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<AuditoriaDto>>> Get()
        {
            var Auditoriaes = await _unitOfWork.Auditoria.GetAllAsync();
            return _mapper.Map<List<AuditoriaDto>>(Auditoriaes);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Auditoria>> Post(AuditoriaDto AuditoriaDto)
        {
            var Auditoria = _mapper.Map<Auditoria>(AuditoriaDto);
            this._unitOfWork.Auditoria.Add(Auditoria);
            await _unitOfWork.SaveAsync();
            if (Auditoria == null)
            {
                return BadRequest();
            }
            AuditoriaDto.Id = Auditoria.Id;
            return CreatedAtAction(nameof(Post), new { id = AuditoriaDto.Id }, AuditoriaDto);
        }
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AuditoriaDto>> Get(int id)
        {
            var Auditoria = await _unitOfWork.Auditoria.GetByIdAsync(id);
            if (Auditoria == null){
                return NotFound();
            }
            return _mapper.Map<AuditoriaDto>(Auditoria);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<AuditoriaDto>> Put(int id, [FromBody] AuditoriaDto AuditoriaDto)
        {
            if (AuditoriaDto == null)
                return NotFound();
            var Auditoriaes = _mapper.Map<Auditoria>(AuditoriaDto);
            _unitOfWork.Auditoria.Update(Auditoriaes);
            await _unitOfWork.SaveAsync();
            return AuditoriaDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Auditoria = await _unitOfWork.Auditoria.GetByIdAsync(id);
            if (Auditoria == null)
            {
                return NotFound();
            }
            _unitOfWork.Auditoria.Delete(Auditoria);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}