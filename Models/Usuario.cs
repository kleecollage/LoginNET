﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginNET.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }


        public string ConfirmarClave { get; set; }
    }
}