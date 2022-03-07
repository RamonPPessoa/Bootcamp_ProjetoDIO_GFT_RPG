namespace ProjetoPOO.src.Models
{
    public class Wizard : Hero
    {
     
         public Wizard(string Name,int level,string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;

        }

        public Wizard()
        {
            
        }

           public override string Attack ()
        {
             return this.Name + "Lançou magia";
         }

         public  string Attack (int bonus)
        {
            if(bonus > 6)
            {
                return this.Name + "Lançou magia muito poderosa com bonus de " + bonus;
            }
            else
            {
                return this.Name + "Lançou magia fraca com bonus de " + bonus;
            }
             
         }

    }

}