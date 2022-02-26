namespace Projeto1.src.Entities
{
    public class BlackWizard : Hero
    {
             public BlackWizard(string Name, int Level, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " " + "Lançou a Magia Negra";
        }

        public override string Defense(){
            return this.Name + " " + "Defendeu com uma Magia negra de defesa";
         }
    
    }

}