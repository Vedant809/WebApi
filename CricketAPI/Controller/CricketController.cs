using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CricketAPI.Repository;
using CricketAPI.Entity;
using System.Linq.Expressions;

namespace CricketAPI.Controller
{
    [Route("api/Cricket")]
    [ApiController]
    public class CricketController : ControllerBase
    {
        private readonly ICricketRepository _repo;

        public CricketController(ICricketRepository repo)
        {
            _repo=repo;
        }
        [HttpGet]
        [Route("GetPlayerInfo")]
        public async Task<IActionResult> GetPlayerInfo()
        {
            try
            {
                var playerInfo = await _repo.GetCricketPlayerNames();
                return Ok(playerInfo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        [HttpGet]
        [Route("GetIndianPlayer")]
        public async Task<IActionResult> GetIndianPlayer()
        {
            try
            {
                var indianPlayer = await FilterData();
                return Ok(indianPlayer);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }


        //[HttpGet]
        //[Route("FilteredData")]
        private async Task<Cricket> FilterData()
        {
            var indianPlayer=await _repo.GetCricketPlayerNames();
            var filterData = indianPlayer.FirstOrDefault();
            return filterData;
        }
    }
}
