using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.Xml;

namespace Zasylogic.Models
{
    public class Cliente
    {
       
        public  string Nombre { set; get; }
        public string Apellidos { set; get; }
        public string Telefono { set; get; }

        public string Email { set; get; }

        public TiposMotivo Motivo { get; set; }

        public string  Sexo    { set; get; }

        public DateTime CreatedAt { set; get; }






    }


}