using MediatR;
using Microsoft.AspNetCore.Mvc;
using Server.Domain.Application.CQRS.Commands.LanguageCommands.CreateLanguage;
using Server.Domain.Application.CQRS.Commands.LanguageCommands.DeleteLanguage;
using Server.Domain.Application.CQRS.Commands.LanguageCommands.UpdateLanguage;
using Server.Domain.Application.CQRS.Queries.LanguageQueries.GetAllLanguage;
using Server.Domain.Application.CQRS.Queries.LanguageQueries.GetByIdLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private IMediator mediator;

        public LanguageController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAll(int limit)
        {
            GetAllLanguageQueryRequest request = new GetAllLanguageQueryRequest();
            request.Limit = limit;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> GetById(int id)
        {
            GetByIdLanguageQueryRequest request = new GetByIdLanguageQueryRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPost]
        [Route("create")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create(CreateLanguageCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpDelete]
        [Route("delete")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            DeleteLanguageCommandRequest request = new DeleteLanguageCommandRequest();
            request.Id = id;

            var res = await mediator.Send(request);
            return new JsonResult(res);
        }

        [HttpPut]
        [Route("update")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(UpdateLanguageCommandRequest request)
        {
            ;
            var res = await mediator.Send(request);
            return new JsonResult(res);
        }
    }
}
