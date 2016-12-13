using System;
using System.Threading.Tasks;

namespace DestinyCore {

    public class Client
    {
        private string _apikey;
        public Client (string apikey){
            this._apikey = apikey;
        }
        public async Task<object> getCharacterAsync(string gamertag, DestinyPlatform platform)
        {
            throw new NotImplementedException();
        }
        public async Task<object> getCharacterDetailAsync (string gamertag, DestinyPlatform platform, string charId)
        {
            throw new NotImplementedException();
        }
        public async Task<object> getCharacterHistoricalMatchesAsync (string gamertag, DestinyPlatform platform, string charId, int matchesToLoad = 50)
        {
            throw new NotImplementedException();
        }
            
        
    }

    

}