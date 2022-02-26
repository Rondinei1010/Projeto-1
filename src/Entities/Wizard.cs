namespace Projeto1.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
         public override string Attack(){
            return this.Name + " " + "Lançou Magia";
        }

        public string Attack(int Bonus){
        
        if (Bonus > 6){
            return this.Name + " " + "Lançou Magia com Super Bonus  de ataque de " + Bonus;
        }else{
            return this.Name + " " + "Lançou uma Magia com força fraca de ataque de " + Bonus;
        }

        
            
        }

        public override string Defense(){
            return this.Name + " " + "Defendeu com uma Magia de defesa";
        }
    }
}