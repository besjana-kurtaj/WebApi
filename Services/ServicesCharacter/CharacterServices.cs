namespace WebApi.Services.ServicesCharacter
{
    public class CharacterServices : IChearacterServieces
    {
            private static List<Character> characters=new List<Character>(){
                new Character(),
                new Character{Id=1,Name="Same"}
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newChar)
        {
            var serviceResponse=new ServiceResponse<List<Character>>();

           characters.Add(newChar);
           serviceResponse.Data=characters;
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
           var serviceResponse=new ServiceResponse<List<Character>>();
           serviceResponse.Data=characters;
           return serviceResponse;
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
          var serviceResponse=new ServiceResponse<Character>();
          var character=characters.FirstOrDefault(x=>x.Id==id);
          serviceResponse.Data=character;
          return  serviceResponse;
        }
    }
}