
namespace DestinyCore 
{
    public enum DestinyPlatform 
    {
        PS = 2, Xbox = 1
    }

    public class Account
    {
        public string GamerTag {get; set;}
        public DestinyPlatform Platform {get; set;}
        public int Grimoire {get; set;}
        public string membershipId {get; set;}
    }
    public class Character
    {
        public string charId {get; set;}
        public string Race {get; set;}
        public string Gender {get; set;}
        public string Class {get; set;}
        public int Level {get; set;}
        public int LightLevel {get; set;}
    }
}