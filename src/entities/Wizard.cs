using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_poo.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int HealthPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack(){
            return $"{this.Name} lançou magia.";
        }
        public string Attack(int Bonus){
            if (Bonus > 6)
            {
                return $"{this.Name} lançou magia forte com bonus de ataque de {Bonus}.";
            }
            else
            {
                return $"{this.Name} lançou magia fraca com bonus de ataque de {Bonus}.";
            }
        }
    }
}