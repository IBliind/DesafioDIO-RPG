namespace RPG.src.Entities
{
    public class WhiteWizard:Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }
        public string Heal(int Bonus, string Name)
        {
            if (Bonus > 6)
            {
                return $"{this.Name} lançou cura super efetiva com bônus de {Bonus} em {Name}.";
            }
            else
            {
                return $"{this.Name} lançou cura com força fraca com bônus de {Bonus}.";
            }
            
        }
    }
}