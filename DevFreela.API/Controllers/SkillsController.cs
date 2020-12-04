using DevFreela.Application.Commands.CreateSkill;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    public class SkillsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SkillsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkills(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateSkillInputModel inputModel)
        {
            var command = new CreateSkillCommand(inputModel.Description);

            var result = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetSkills), new { id = result.Id }, result);
        }
    }
}
