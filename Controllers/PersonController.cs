using System.Collections;
using Microsoft.AspNetCore.Mvc;
using QueryApi.Repositories;
using QueryApi.Domain;

namespace Controllers
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

    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        [Route("EJERCICIO 1")]
        public IActionResult GetAll()
        {
            var repository = new PersonRepository();
            var persons = repository.GetAll();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("EJERCICIO 2")]
        public IActionResult GetField()
        {
            var repository = new PersonRepository();
            var persons = repository.GetField();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("EJERCICIO 3")]
        public IActionResult GetByGender(char Letra)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByGender(Letra);
            return Ok(persons);
        } 

          [HttpGet]
        [Route("EJERCICIO 4")]
        public IActionResult GetByRangeAge(int Edad1, int Edad2)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByRangeAge(Edad1, Edad2);
            return Ok(persons);
        }


        [HttpGet]
        [Route("Ejercicio 5")]
        public IActionResult GetJobs()
        {
            var repository = new PersonRepository();
            var persons = repository.GetJobs();
            return Ok(persons);
        } 

        [HttpGet]
        [Route("EJERCICIO 6")]
        public IActionResult GetContains(string ParteNombre)
        {
            var repository = new PersonRepository();
            var persons = repository.GetContains(ParteNombre);
            return Ok(persons);
        } 


        [HttpGet]
        [Route("EJERCICIO 7")]
        public IActionResult GetByAger(int Edad1, int Edad2, int Edad3)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByAger( Edad1,  Edad2,  Edad3);
            return Ok(persons);
        }

        [HttpGet]
        [Route("EJERCICIO 8")]
        public IActionResult GetByMaxAge(int Edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetByMaxAge(Edad);
            return Ok(persons);
        }   

        [HttpGet]
        [Route("EJERCICIO 9")]
        public IActionResult GetPersonsOrdered(int edad)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrdered(edad);
            return Ok(persons);
        }

          [HttpGet]
        [Route("EJERCICIO 10")]
        public IActionResult GetPersonsOrderedDesc(int EdadMax, int EdadMin)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPersonsOrderedDesc(EdadMax, EdadMin);
            return Ok(persons);
        }

        [HttpGet]
        [Route("EJERCICIO 11")]
        public IActionResult CountPerson(char gender)
        {
            var repository = new PersonRepository();
            var persons = repository.CountPerson(gender);
            return Ok(persons);

        
        }

        [HttpGet]
        [Route("EJERCICIO 12")]
        public IActionResult ExistPerson(string Apellido)
        {
            var repository = new PersonRepository();
            var persons = repository.ExistPerson(Apellido);
            return Ok(persons);
        }

        [HttpGet]
        [Route("EJERCICIO 13")]
        public IActionResult GetPerson(string job, int Age)
        {
            var repository = new PersonRepository();
            var persons = repository.GetPerson(job, Age);
            return Ok(persons);
        }

         [HttpGet]
        [Route("EJERCICIO 14")]
        public IActionResult TakePerson(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.TakePerson(job);
            return Ok(persons);
        }
        
         [HttpGet]
        [Route("EJERCICIO 15")]
        public IActionResult SkipPerson(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipPerson(job);
            return Ok(persons);
        }

        [HttpGet]
        [Route("EJERCICIO 16")]
        public IActionResult SkipTakePerson(string job)
        {
            var repository = new PersonRepository();
            var persons = repository.SkipTakePerson(job);
            return Ok(persons);
        }


    
    
        




    }
}