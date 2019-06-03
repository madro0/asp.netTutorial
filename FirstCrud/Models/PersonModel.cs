using FirstCrud.Models.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstCrud.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PersonModel> Lista { get; set; }


        public void Save()
        {
            PersonDao pe = new PersonDao();
            pe.Save(this);
        }

        public List<PersonModel> show()
        {
            PersonDao pe = new PersonDao();
            return pe.show();
        }
        public void Delite(int id)
        {
            PersonDao pe = new PersonDao();
            pe.Delite(id);
        }
        public void UpdatePerson(PersonModel pe)
        {
            PersonDao p = new PersonDao();
            p.UpdatePerson(pe);
        }

        public PersonModel GetPerson(int id)
        {
            PersonDao pe = new PersonDao();
            return pe.GetPerson(id);
        }
        
    }
}