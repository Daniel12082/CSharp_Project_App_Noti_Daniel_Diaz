using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class MaestroVsSubmoduloController: BaseControllerApi
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IMapper _mapper;
    
            public MaestroVsSubmoduloController(IUnitOfWork unitOfWork, IMapper mapper)
            {
                _unitOfWork = unitOfWork;
                _mapper = mapper;
            }
    
            [HttpGet]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<ActionResult<IEnumerable<MaestroVsSubmodulo>>> Get()
            {
                var entidades = await _unitOfWork.MaestroVsSubmodulo.GetAllAsync();
                return _mapper.Map<List<MaestroVsSubmodulo>>(entidades);
            }
    
            [HttpGet("{id}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<ActionResult<MaestroVsSubmoduloDto>> Get(int id)
            {
                var entidad = await _unitOfWork.MaestroVsSubmodulo.GetByIdAsync(id);
                if(entidad == null)
                {
                    return NotFound();
                }
                return _mapper.Map<MaestroVsSubmoduloDto>(entidad);
            }
    
            [HttpPost]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<ActionResult<MaestroVsSubmodulo>> Post(MaestroVsSubmoduloDto MaestroVsSubmoduloDto)
            {
                var entidad = _mapper.Map<MaestroVsSubmodulo>(MaestroVsSubmoduloDto);
                this._unitOfWork.MaestroVsSubmodulo.Add(entidad);
                await _unitOfWork.SaveAsync();
                if(entidad == null)
                {
                    return BadRequest();
                }
                MaestroVsSubmoduloDto.Id = entidad.Id;
                return CreatedAtAction(nameof(Post), new {id = MaestroVsSubmoduloDto.Id}, MaestroVsSubmoduloDto);
            }
    
            [HttpPut("{id}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<ActionResult<MaestroVsSubmoduloDto>> Put(int id, [FromBody] MaestroVsSubmoduloDto MaestroVsSubmoduloDto)
            {
                if(MaestroVsSubmoduloDto == null)
                {
                    return NotFound();
                }
                var entidades = _mapper.Map<MaestroVsSubmodulo>(MaestroVsSubmoduloDto);
                _unitOfWork.MaestroVsSubmodulo.Update(entidades);
                await _unitOfWork.SaveAsync();
                return MaestroVsSubmoduloDto;
            }
    
            [HttpDelete("{id}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            public async Task<IActionResult> Delete(int id)
            {
                var entidad = await _unitOfWork.MaestroVsSubmodulo.GetByIdAsync(id);
                if(entidad == null)
                {
                    return NotFound();
                }
                _unitOfWork.MaestroVsSubmodulo.Delete(entidad);
                await _unitOfWork.SaveAsync();
                return NoContent();
            }
        }
}