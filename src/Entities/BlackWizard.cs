namespace RPG.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Fireball(int Dano)
        {
            return $"{this.Name} utilizou bola de fogo dando {Dano} de dano.";
        }

    }
}