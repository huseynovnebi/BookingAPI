using Application.Helpers;
using Application.Interfaces;
using Application.Models;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IUnitOfWork _unitofwork;

        private readonly Storage _storage;

        public MainController(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
            _storage = new Storage();
            _storage.homes = StorageData.GenerateLargeStorage();
        }

 
        [HttpGet]
        [Route("/api/available-homes")]
       
        public async Task<IActionResult> AvailableHomes([FromQuery] AvailableHomesGet homes)
        {

            var dict = await _unitofwork.BookRepo.AvailableHomesRepo(homes,_storage);

            var response = dict.Select(kvp => new
            {
                homeId = kvp.Key.homeId,
                homeName = kvp.Key.homeName,
                availableSlots = kvp.Value
            }).ToList();

            return Ok(new
            {
                status = "OK",
                homes = response
            });
            
        }



    }
}
