using AspnetCoreSPATemplate.Services.Common;
using AspnetCoreSPATemplate.Services.Me;
using AspnetCoreSPATemplate.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AspnetCoreSPATemplate.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize(Policy = "RequireStandard")]
    public class MeController : ControllerBase
    {
        private readonly IMeRepository _meRepo;

        public MeController(
            IMeRepository userRepo
        )
        {
            _meRepo = userRepo;
        }

        // http://localhost:5000/api/v1/me/
        [HttpGet]
        public async Task<ActionResult> Get([FromRoute]MeGetRequest rq)
        {
            try
            {
                rq.Id = this.Context.User.GetUserId();
                MeGetResponse rs = await (new MeGetService(this.Context, _meRepo)).RunAsync(rq);
                return new ApiActionResult(this.Context.Request, rs);
            }
            catch (Exception ex)
            {
                return new ApiActionResult(this.Context.Request, ex);
            }
        }

        // http://localhost:5000/api/v1/me/
        //[HttpPatch]
        //public async Task<ActionResult> Update([FromBody]MeUpdateRequest rq)
        //{
        //    try
        //    {
        //        MeUpdateResponse rs = await (new MeUpdateService(this.Context, _meRepo)).RunAsync(rq);
        //        return new ApiActionResult(this.Context.Request, rs);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new ApiActionResult(this.Context.Request, ex);
        //    }
        //}
    }
}