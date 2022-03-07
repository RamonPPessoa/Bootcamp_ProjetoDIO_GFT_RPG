namespace ProjetoPOO.src.Models
{
    public class Elf : Hero
    {
        public int Age;
        public string Habilidades;


         public Elf(string Name,int level,string HeroType, int Age,string Habilidades)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
            this.Age = Age;
            this.Habilidades = Habilidades;

        }

         public override string ToString() 
            {
                return this.Name + " Possui um nivel de poder " + this.level + " Ele é um " + this.HeroType + " Tem a idade " + this.Age + " anos  e  possui " + this.Habilidades;
             } 
    }
} 