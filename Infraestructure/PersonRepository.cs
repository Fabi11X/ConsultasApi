using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using QueryApi.Domain;
using System.Threading.Tasks;

namespace QueryApi.Repositories
{
    /*Nombre de la escuela: Universidad Tecnologica Metropolitana

    Asignatura: Aplicaciones Web Orientadas a Objetos

    Nombre del Maestro: Chuc Uc Joel Ivan

    Nombre de la actividad: Actividad 1

    Nombre del alumno: Fabian Francisco Aguilar Rivero

    Cuatrimestre: 4

    Grupo: B

    Parcial: 2
    */

    public class PersonRepository
    {
        List<Person> _persons;

        public PersonRepository()
        {
            var fileName = "dummy.data.queries.json";
            if(File.Exists(fileName))
            {
                var json = File.ReadAllText(fileName);
                _persons = JsonSerializer.Deserialize<IEnumerable<Person>>(json).ToList();
            }
        }

        //  //EJERCICIO_1
        public IEnumerable<Person> GetAll()
        {
            var query = _persons.Select(person => person);
            return query;
        }

        //  //EJERCICIO_2
        public IEnumerable<Object> GetField(){
            var query = _persons.Select(person => new {
                NombreCompleto = $"{person.FirstName} {person.LastName}",
                AnioNacimiento = DateTime.Now.AddYears(person.Age *-1).Year,
                CorreoElectronico = person.Email
            });
            return query;
        }

        //  //EJERCICIO_3
        public IEnumerable<Person> GetByGender(char Letra){
            //var gender = 'M';
            var query = _persons.Where(person => person.Gender == Letra);
            return query;
        }

          //EJERCICIO_4
       
        public IEnumerable<Person> GetByRangeAge(int Edad1, int Edad2){
           // var minage = 30;
           // var maxage = 40;
            var query = _persons.Where(person => person.Age >= Edad1 && person.Age <= Edad2);
            return query;
        }
        
         //EJERCICIO_5
         public IEnumerable<string> GetJobs(){
            var query = _persons.Select(person => person.Job).Distinct();
            return query;
        }

         //  //EJERCICIO_6
        public IEnumerable<Person> GetContains(string ParteNombre){
            //var partName = "ar";
            var query = _persons.Where(person => person.FirstName.Contains(ParteNombre));
            return query; 
        }


         //EJERCICIO_7
          public IEnumerable<Person> GetByAger(int Edad1, int Edad2, int Edad3){
            var ages = new List<int>{ Edad1,  Edad2,  Edad3};
            var query = _persons.Where(person => ages.Contains(person.Age));
            return query; 
        }
       

        //EJERCICIO_8
        public IEnumerable<Person> GetByMaxAge(int Edad){
            //var age = 30;
            var query = _persons.Where(person => person.Age <= Edad);
            return query;
        }

        //EJERCICIO_9

          public IEnumerable<Person> GetPersonsOrdered(int edad){
            //var job = "Payment Adjustment Coordinator";

           var query = _persons.Where(person => person.Age > edad)
                        .OrderBy(person => person.Age);
            return query;
        }

         //EJERCICIO_10

        public IEnumerable<Person> GetPersonsOrderedDesc(int EdadMax, int EdadMin){
        var genero = 'M';
        var query = _persons.Where(person => person.Gender == genero && person.Age >= EdadMin && person.Age <= EdadMax)
                    .OrderByDescending(person => person.FirstName);
        return query;

        }

         //EJERCICIO_11

          public int CountPerson(char gender)
        {
            //var gender = 'F';
            var query = _persons.Count(person => person.Gender == gender);
            return query;
        }

         //EJERCICIO_12

          public bool ExistPerson(string Apellido)
        {
           // var lastName = "Tuffell";
            var query = _persons.Exists(person => person.LastName == Apellido);
            return query;
        }

        //EJERCICIO_13

         public Person GetPerson(string job, int Age)
        {
            //var id = 340;
            var query = _persons.FirstOrDefault(person => person.Job == job && person.Age == Age);
            return query;
        }

        //EJERCICIO_14

         public IEnumerable<Person> TakePerson(string job)
        {
            //var job = "Geological Engineer";
            var take = 3;
            var query = _persons.Where(person => person.Job == job).Take(take);
            return query;
        }

        //EJERCICIO_15

          public IEnumerable<Person> SkipPerson(string job)
        {
           // var job = "Professor";
            var skip = 4;
            var query = _persons.Where(person => person.Job == job).Skip(skip);
            return query;
        }

         //EJERCICIO_16
        public IEnumerable<Person> SkipTakePerson(string job)
        {
            //var job = "Professor";
            var skip = 3;
            var take = 3;
            var query = _persons.Where(person => person.Job == job).Skip(skip).Take(take);
            return query;
        }

    }
}