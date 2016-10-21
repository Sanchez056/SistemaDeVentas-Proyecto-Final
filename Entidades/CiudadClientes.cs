using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class CiudadClientes
    {
        [Key]
        public int CiudadClienteId { get; set; }

        public string CiudadCliente{ get; set; }

    }
}
