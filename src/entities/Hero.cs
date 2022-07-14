using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_poo.src.entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int HealthPoints){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoints = HealthPoints;
        }
        public Hero(){
            
        }
        public string Name;
        public int Level;
        public string HeroType;
        public int HealthPoints;

        public override string ToString(){
            return $"{this.Name} {this.Level} {this.HeroType}";
        }

        public virtual string Attack(){
            return $"{this.Name} atacou com sua espada.";
        }
    }
}