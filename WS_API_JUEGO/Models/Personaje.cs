using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Firebase;
using Firebase.Database;
using Firebase.Storage;
using Firebase.Auth;

namespace WS_API_JUEGO.Models
{
    public class Personaje
    {

        public String Nombre { get; set; }
        public String ImageUrl { get; set; } 

        public Personaje()
        {
        }
    }
}