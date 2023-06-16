namespace WebApi.Services.ServicesCharacter
{
    public interface IChearacterServieces
    {

       Task<ServiceResponse<List<Character>>> GetAllCharacters();
       Task<ServiceResponse<Character>> GetCharacterById(int id);
       Task<ServiceResponse<List<Character>>> AddCharacter(Character newChar);

    }
}