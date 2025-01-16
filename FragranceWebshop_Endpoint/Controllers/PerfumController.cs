using FragranceWebshop_Logic.Logic;
using FragranceWebshop_Entities.Entity_Models;
using FragranceWebshop_Entities.Dtos.PerfumDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace FragranceWebshop_Endpoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfumController: ControllerBase
    {
        PerfumLogic logic;

        public PerfumController(PerfumLogic logic)
        {
            this.logic = logic;
        }

        [HttpPost("Addperfum")]
        [Authorize (Roles = "Admin")]
        public void AddPerfum(PerfumCreateDto perfum)
        {
            logic.AddPerfum(perfum);
        }

        [HttpDelete("DeletePerfumById")]
        [Authorize(Roles = "Admin")]
        public void DeletePerfumById(string id)
        {
            logic.DeletePerfumById(id);
        }

        [HttpGet("GetAllPerfum")]
        public IEnumerable<PerfumViewDto> GetAllPerfum()
        {
            return logic.GetAllPerfum();
        }

        [HttpPut("UpdatePerfumPrice")]
        [Authorize(Roles = "Admin")]
        public void UpdatePerfumPrice(string id, int price)
        {
            logic.UpdatePerfum(id, price);
        }

        [HttpGet("PerfumesBySeason")]
        public IEnumerable<PerfumViewDto> PerfumesBySeason(string season)
        {
            return logic.GetPerfumesBySeason(season);
        }

        [HttpGet("PerfumesPriceRange")]
        public IEnumerable<PerfumViewDto> PerfumesPriceRange(int min, int max)
        {
            return logic.GetPerfumesByPriceRange(min, max);
        }

    }
}
