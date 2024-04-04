using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WS_API_JUEGO.Models;
using System.Web.Http;

namespace WS_API_JUEGO.Controllers
{
    public class PersonajeController : ApiController
    {
        //Coleccion de Personajes
        List<Personaje> personajes = new List<Personaje>{
            new Personaje() { Nombre = "Guerrero", ImageUrl = "/Images/ic_warrior_body.png"},
            new Personaje() { Nombre = "Explorador", ImageUrl = "/Images/ic_explorer_body.png"},
            new Personaje() { Nombre = "Mago", ImageUrl = "/Images/ic_mage_body.png"},
            new Personaje() { Nombre = "Bárbaro", ImageUrl = "/Images/ic_berserker_body.png"},
            new Personaje() { Nombre = "Bardo", ImageUrl = "/Images/ic_bard_body.png"},
            new Personaje() { Nombre = "Monje", ImageUrl = "/Images/ic_monk_body.png"}
        };
        

        //Get Listar todos los personajes
        public List<Personaje> Get()
        {
            return personajes;
        }
    }
}
