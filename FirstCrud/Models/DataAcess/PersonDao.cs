using FirstCrud.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstCrud.Models.DataAcess
{
    public class PersonDao
    {

        public void Save(PersonModel p)
        {
            using (var context = new PeopleEntities())
            {
                Person pe = new Person();
                pe.Id = p.Id;
                pe.Name = p.Name;

                context.Person.Add(pe);
                context.SaveChanges();

            }
        }
        public List<PersonModel> show()
        {
            List<PersonModel> result = new List<PersonModel>();

            using (var context = new PeopleEntities())
            {
                var resultadoconsulta = (from d in context.Person select d).ToList();
                foreach (var item in resultadoconsulta)
                {
                    PersonModel x = new PersonModel();

                    x.Id = item.Id;
                    x.Name = item.Name;
                    result.Add(x);
                }
            }
            return result;
        }
        public void Delite(int id)
        {
            using (var context = new PeopleEntities())
            {
                var reg = (from d in context.Person select d)
                    .Where(x => x.Id.Equals(id)).FirstOrDefault();
                context.Person.Remove(reg);
                context.SaveChanges();
            }
        }
        public void UpdatePerson(PersonModel pe)
        {
            using (var contexto = new PeopleEntities())
            {
                var data = (from d in contexto.Person select d)
                    .Where(x => x.Id.Equals(pe.Id)).FirstOrDefault();
                data.Id = pe.Id;
                data.Name = pe.Name;
                

                contexto.SaveChanges();
            }
        }
        public PersonModel GetPerson(int id)
        {
            PersonModel selec = new PersonModel();
            using (var contexto = new PeopleEntities())
            {
                var per = (from d in contexto.Person select d)
                    .Where(x => x.Id.Equals(id)).FirstOrDefault();

                selec.Name = per.Name;
                selec.Id = per.Id;
                

            }
            return selec;
        }


    }
}