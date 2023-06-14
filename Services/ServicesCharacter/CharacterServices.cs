namespace WebApi.Services.ServicesCharacter
{
    public class CharacterServices : IChearacterServieces
    {
            private static List<Character> characters=new List<Character>(){
                new Character(),
                new Character{Id=1,Name="Same"}
        };
        public async Task<List<Character>> AddCharacter(Character newChar)
        {
           characters.Add(newChar);
            return characters;
        }

        public async Task<List<Character>> GetAllCharacters()
        {
           return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
          return  characters.FirstOrDefault(x=>x.Id==id);
        }
    }
}