using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoIntegrador
{
    class Club
    {/*
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
  */
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
            Id = id;
            Nombre = nombre;
            TipoInstitucion= tipoInstitucion;//Club o Club de Barrio
            Sede = sede;//Central – Única – Anexo - Polideportivo
            CantidadDeSocios = cantidadDeSocios;
            Barrio = barrio;
            Comuna = comuna;
            Domicilio = domicilio;
            Telefono = telefono;
            Email = email;
            PaginaWeb = paginaWeb;
            Actividades = actividades;
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
            return CantidadDeSocios+" "+Id + " " + Nombre + " " +Telefono + " " +Actividades;
            
        }

        internal bool tieneActividad(string actBuscada)
        {
            bool r = false;
            int len = this.Actividades.Length;

            
            for (int i = 0; i <= len - actBuscada.Length; i++) {                 
                string auxPalabra = (this.Actividades.Substring(i, actBuscada.Length)).ToLower();
                if (auxPalabra == actBuscada.ToLower()){
                    r = true;
                    break;
                }
            }

            return r;
        }
    }

    
}
