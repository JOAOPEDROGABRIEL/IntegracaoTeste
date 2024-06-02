using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsuarioAPI.Entities;
    public class UsuarioItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
