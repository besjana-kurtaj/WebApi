namespace WebApi.Services.ServicesCharacter
{
    public interface IChearacterServieces
    {

       Task<List<Character>> GetAllCharacters();
       Task<Character> GetCharacterById(int id);
       Task<List<Character>> AddCharacter(Character newChar);

    }
}