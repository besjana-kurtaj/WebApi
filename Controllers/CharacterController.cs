using Microsoft.AspNetCore.Mvc;
using WebApi.Services.ServicesCharacter;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController:ControllerBase
    {
        private readonly IChearacterServieces _chearacterServieces;

        public CharacterController(IChearacterServieces chearacterServieces)
       {
            _chearacterServieces = chearacterServieces;
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get(){
            return Ok(await _chearacterServieces.GetAllCharacters());
           
        }
        [HttpGet("GetSingle/{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id){
            return Ok(await _chearacterServieces.GetCharacterById(id));
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newChar){
           return Ok(await _chearacterServieces.AddCharacter(newChar));
        }
    }
}