using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT11_Exemple
{

    [Serializable]
    public  class Etudiant
    {
        public int numins { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public Adresse adresse { get; set; }

        public override string ToString()
        {
            return $"Numéro d'inscription: {numins} \t Nom : {nom} \t Prenom : {prenom} \t" +
                $"rue : {adresse.rue} \t ville : {adresse.ville} \t Pays : {adresse.pays}";
        }
    }
}
