namespace dio_banco_carrefour_desafio_rpg.src.Entities
{
    public class Kinight : Hero
    {
        public Kinight(string Name, int Level, string HeroType) :
            base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}