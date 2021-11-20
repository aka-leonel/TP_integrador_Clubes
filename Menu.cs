using System;
using System.Collections.Generic;
using System.Text;
using TrabajoIntegrador;

namespace TrabajoIntegrador
{
    class Menu
    {
        public Menu()
        {
            //params?
        }

        private int subMenuEditar(ref Club[] listado, int tam)
        {
            int r = 0;
            string lectura;
            int salida = 4;
            while (r != salida)
            {
                Console.Clear();
                Console.WriteLine("***Actualizar film***\n");
                Console.WriteLine("1-Editar nombre");
                Console.WriteLine("2-Editar Estreno");
                Console.WriteLine("3-Editar precio");
                Console.WriteLine("4-Menu anterior");
                Console.WriteLine("***Ingrese opcion: ");

                lectura = Console.ReadLine();
                bool lecturaExistosa = int.TryParse(lectura, out r);

                if (lecturaExistosa)
                {
                    switch (r)
                    {
                        case 1:
                            //edit nombre
                            break;
                        case 2:
                            //edit estreno
                            break;
                        case 3:
                            //edit price
                            break;
                        case 4:
                            Console.WriteLine("***Ir al menu anterior ");
                            break;
                        default:
                            Console.WriteLine("***Opcion invalida: " + r);
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("***Opcion invalida: " + lectura);
                }
                Console.ReadKey();
            }
            return r;
        }
        public int hardcodearListado(ref Club[] listado, int cantidadAhardcodear)
        {
            int i = 0;
            for (; i < cantidadAhardcodear; i++)
            {
                listado[i] = new Club();
            }
            return i;
        }

        public int inicializarListado(ref Club[] listado, int maxSize)
        {
            int i = 0;
            for (; i < maxSize; i++)
            {
                listado[i] = new Club();
            }
            return i;
        }
        public int mostrarMenu(ref Club[] listado, ref int nCargados, int maxSize)
        {
            int r = 1;
            string lectura;
            int salida = 4;

            while (r != salida)
            {
                Console.Clear();
                Console.WriteLine("***Menu Clubes***\n");
                Console.WriteLine("1-Listar Todos los Clubes");
                Console.WriteLine("2-Cargar un nuevo club");
                Console.WriteLine("3-");
                Console.WriteLine("4-SALIR");
                Console.WriteLine("***Ingrese opcion: ");

                lectura = Console.ReadLine();
                bool lecturaExistosa = int.TryParse(lectura, out r);

                if (lecturaExistosa)
                {
                    switch (r)
                    {
                        case 1:
                            listarTodo(listado, nCargados);
                            break;
                        case 2:
                            Console.WriteLine("2-Cargar un nuevo club");
                            cargarNuevoClub(ref listado, ref nCargados, maxSize);
                            break;
                        case 3:
                            break;
                        case 4:
                            Console.WriteLine("***Opcion salida***");
                            break;
                        default:
                            Console.WriteLine("***Opcion invalida: " + r);
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("***Opcion invalida: " + lectura);
                }
                Console.ReadKey();

            }
            return r;
        }

        public int listarTodo(Club[] listado, int nCargados)
        {
            for(int i=0; i< nCargados; i++)
            {
                if(listado[i] == null)
                {
                    Console.WriteLine("Tengo un null***");
                }
                else
                {
                    Console.WriteLine("ID Nombre   TipoInstitucion  Sede   CantidadDeSocios  Barrio  Comuna  Domicilio  Telefono   email   PaginaWeb   Actividades");
                       
                    Console.WriteLine(listado[i].ToString());
                }
                
            }
            return 0;
        }
        private Club pedirDatos()
        {
            Club aux = new Club();

            Console.WriteLine("Ingrese nombre de club");
            aux.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el id: ");
            aux.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Club o Club de Barrio: ");
            aux.TipoInstitucion = Console.ReadLine();

            Console.WriteLine("Ingrese (Central – Única – Anexo - Polideportivo):");
            aux.Sede = Console.ReadLine();

            Console.WriteLine("Cantidad de socios:");
            aux.CantidadDeSocios = int.Parse(Console.ReadLine());

            Console.WriteLine("Barrio: ");
            aux.Barrio = Console.ReadLine();

            Console.WriteLine("Comuna (numero):");
            aux.Comuna = int.Parse(Console.ReadLine());

            Console.WriteLine("Domicilio: ");
            aux.Domicilio = Console.ReadLine();

            Console.WriteLine("Telefono: ");
            aux.Telefono = Console.ReadLine();

            Console.WriteLine("Email: ");
            aux.Email = Console.ReadLine();

            Console.WriteLine("PaginaWeb: ");
            aux.PaginaWeb = Console.ReadLine();

            Console.WriteLine("Actividades: ");
            aux.Actividades = Console.ReadLine();

            return aux;
        }
       private int cargarNuevoClub(ref Club[] listado, ref int nCargados, int maxSize)
        {
            int r = 0;
            Club auxiliar = new Club();
            if(nCargados < maxSize)
            {
                if (listado[nCargados] == null)
                {
                    Console.WriteLine("***Se le pedira que ingrese los datos del nuevo club***\n");
                    auxiliar = pedirDatos();
                  
                    listado[nCargados] = auxiliar;
                    nCargados++;
                    r++;
                }
                else
                {
                    Console.WriteLine("NO Es NULL***");
                    Console.ReadKey();
                }

            }
            else
            {
                Console.WriteLine("No hay espacio para guardar otro club");
            }


            return r;
        }

       


    }
}
