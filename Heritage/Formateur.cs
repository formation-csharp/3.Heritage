﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    public class Formateur : Personne
    {  
        public Formateur(string Nom):base(Nom)
        {
   
        }
        public override string ToString()
        {
            // méthode 2: concaténation
            return $"Formateur {this.Nom} {this.DateNaissance}";
        }

        public override bool Equals(object obj)
        {
            Personne personne = obj as Personne;
            if (this.Nom == personne.Nom) return true;
            else
            {
                return false;
            }
        }
    }
}
