using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoIntegrador
{
    class Club
    {
        private int id;
        private string nombre;
        private string tipoInstitucion;//Club o Club de Barrio
        private string sede;//Central – Única – Anexo - Polideportivo
        private int cantidadDeSocios;
        private string barrio;
        private int comuna;
        private string domicilio;
        private string telefono;
        private string email;
        private string paginaWeb;
        private string actividades;
  
        public Club()
        {
            Id = -1;
            Nombre = "Ejemplo";
            TipoInstitucion = "Club";//Club o Club de Barrio
            Sede = "Central";//Central – Única – Anexo - Polideportivo
            CantidadDeSocios = 23;
            Barrio = "Almagro";
            Comuna = 1;
            Domicilio = "domicilio nº 123";
            Telefono = "23456789";
            Email = "example@domain.com";
            PaginaWeb = "www.example.com";
            Actividades = "Atletismo";          

        }

        public Club(int id, string nombre, string tipoInstitucion,
            string sede, int cantidadDeSocios, string barrio,
            int comuna, string domicilio, string telefono,
            string email, string paginaWeb, string actividades)
        {
            this.id = id;
            this.nombre = nombre;
            this.tipoInstitucion = tipoInstitucion;//Club o Club de Barrio
            this.sede = sede;//Central – Única – Anexo - Polideportivo
            this.cantidadDeSocios = cantidadDeSocios;
            this.barrio = barrio;
            this.comuna = comuna;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.email = email;
            this.paginaWeb = paginaWeb;
            this.actividades = actividades;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TipoInstitucion { get; set; }//Club o Club de Barrio
        public string Sede { get; set; }//Central – Única – Anexo - Polideportivo
        public int CantidadDeSocios { get; set; }
        public string Barrio { get; set; }
        public int Comuna { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }
        public string Actividades { get; set; }

        public override string ToString()
        {
            return Id + " " + Nombre + " " +TipoInstitucion + " " +Sede + " " +CantidadDeSocios 
                + " " +Barrio + " " +Comuna + " " +Domicilio + " " +Telefono + " " +Email + " " +PaginaWeb + " " +Actividades;
        }
        
       

    }

    
}
