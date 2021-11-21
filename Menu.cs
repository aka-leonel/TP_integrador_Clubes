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

        //revisar el xq del return
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
        public int hardcodearListado(ref Club[] listado)
        {
            int i = 0;

            listado[0] = new Club(7, "Independiente", "Club",
            "Central", 120, "Avellaneda", 33, "Avellaneda", "44441414",
            "independiente@mail.com", "www.indep.com", "Futbol Karate Tenis");
            i++;

            listado[1] = new Club(5, "Racing", "Club",
            "Central", 128, "Avellaneda",
            77, "Avellaneda", "64451414",
            "racing@mail.com", "www.racing.com", "Atletismo Futbol Tenis Basquet");
            i++;

            listado[2] = new Club(3, "Boca", "Club de Barrio",
            "Central", 875, "CABA", 86, "Avellaneda", "44441414",
            "independiente@mail.com", "www.indep.com", "Futbol Basquet");
            i++;

            listado[3] = new Club(2, "River", "Club",
            "Central", 456, "CABA", 86, "Avellaneda", "44441414",
            "independiente@mail.com", "www.indep.com", "Futbol Coro Teatro");
            i++;

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
            int salida = 8;

            while (r != salida)
            {
                Console.Clear();
                Console.WriteLine("***Menu Clubes***\n");
                Console.WriteLine("1-Listar Todos los Clubes");
                Console.WriteLine("2-Cargar un nuevo club");
                Console.WriteLine("3-Ordenar por...");
                Console.WriteLine("4-Buscar Club por ID");
                Console.WriteLine("5-Buscar Actividades");
                Console.WriteLine("6-Reportar Paginas web");
                Console.WriteLine("7-ver club con mas socios");
                Console.WriteLine(salida+"-SALIR");
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
                            Console.WriteLine("***submenu ordenamientos");
                            subMenuOrdenar(ref listado, ref nCargados, maxSize);
                            break;
                        case 4:
                            funcionDebusquedaPorId(ref listado, nCargados, maxSize);
                            break;
                        case 5:
                            submenuBuscarActividades(ref listado, nCargados, maxSize);
                            break;
                        case 6:
                            reportarPaginasWeb(listado, nCargados);
                            break;
                        case 7:
                            reportarClubConMasSocios(listado, nCargados);
                            break;
                        case 8:
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

        private void reportarClubConMasSocios(Club[] listado, int nCargados)
        {
            int indiceDelMasNumeroso = -1;//pesimista
            int maximoNumeroDeSocios = 0;
            if (nCargados > 0)
            {
                for(int i=0; i<nCargados; i++)
                {
                    if(listado[i].CantidadDeSocios> maximoNumeroDeSocios)
                    {
                        indiceDelMasNumeroso = i;
                        maximoNumeroDeSocios = listado[i].CantidadDeSocios;
                    }
                }
                //termine de recorrer
                if (indiceDelMasNumeroso != -1)
                {
                    Console.Clear();
                    Console.WriteLine("**Informacion del club con mayor numero de socios**");
                    Console.WriteLine("Club: "+listado[indiceDelMasNumeroso].Nombre+"   Id: " + listado[indiceDelMasNumeroso].CantidadDeSocios);
                }
                else
                {
                    Console.WriteLine("No hay socios cargados en los clubes");
                }
            }
            else { 
                Console.WriteLine("No hay clubes cargados");
            }
            Console.ReadKey();
        }

        private void reportarPaginasWeb(Club[] listado, int nCargados)
        {
            
            if (nCargados > 0)
            {
                for(int i=0; i<nCargados; i++)
                {
                    //listado[i].PaginaWeb
                    if (listado[i].PaginaWeb.Length > 0)
                    {
                        Console.WriteLine(listado[i].Nombre + " Sitio web: " + listado[i].PaginaWeb);
                    }                                       
                    
                }
            }
            else
            {
                Console.WriteLine("Nada cargado");
            }
            Console.ReadKey();
        }

        private void subMenuOrdenar(ref Club[] listado, ref int nCargados, int maxSize)
        {
            int r = 0;
            string lectura;
            int salida = 6;
            while (r != salida)
            {
                Console.Clear();
                Console.WriteLine("***Ordenamientos***\n");
                Console.WriteLine("1-Ordenar por ID asc");
                Console.WriteLine("2-Ordenar por ID desc");
                Console.WriteLine("3-Ordenar por Nombre asc");
                Console.WriteLine("4-Ordenar por Nombre desc");
                Console.WriteLine("5-Ordenar por cantidad de socios");
                Console.WriteLine("6-**Menu anterior**");
                Console.WriteLine("***Ingrese opcion: ");

                lectura = Console.ReadLine();
                bool lecturaExistosa = int.TryParse(lectura, out r);

                if (lecturaExistosa)
                {
                    switch (r)
                    {
                        case 1:
                            ordenarPorId(ref listado, nCargados, 1);
                            Console.WriteLine("***Se ordenaron los clubes por ID ascendente");
                            break;
                        case 2:
                            ordenarPorId(ref listado, nCargados, 0);
                            Console.WriteLine("***Se ordenaron los clubes por ID descendente");
                            break;
                        case 3:
                            odenarPorNombre(ref listado, nCargados, 1);
                            Console.WriteLine("***Se ordenaron los clubes por Nombre ascendente");
                            break;
                        case 4:
                            odenarPorNombre(ref listado, nCargados, 0);
                            Console.WriteLine("***Se ordenaron los clubes por Nombre descendente");
                            break;
                        case 5:
                            odenarPorCantidadDeSocios(ref listado, nCargados, 0);
                            Console.WriteLine("***Se ordenaron los clubes por cantidad de socios");
                            break;
                        case 6:
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

        }
        private void odenarPorCantidadDeSocios(ref Club[] listado, int nCargados, int creciente)
        {
            Club aux = new Club();
            for (int i = 0; i < nCargados - 1; i++)
            {
                for (int j = i + 1; j < nCargados; j++)
                {
                    if (listado[i].CantidadDeSocios > listado[j].CantidadDeSocios)
                    {
                        //swappeo
                        aux = listado[i];
                        listado[i] = listado[j];
                        listado[j] = aux;
                    }
                }
            }
        }
        private void odenarPorNombre(ref Club[] listado, int nCargados, int creciente)
        {
            Club aux = new Club();
            if (nCargados > 0)
            {
                for (int i = 0; i < nCargados - 1; i++)
                {
                    for (int j = i + 1; j < nCargados; j++)
                    {

                        int esPosterior = String.Compare(listado[i].Nombre, listado[j].Nombre);
                        if (creciente == 1 && esPosterior > 0
                            || creciente == 0 && esPosterior < 0)
                        {
                            aux = listado[i];
                            listado[i] = listado[j];
                            listado[j] = aux;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("****No hay datos cargados");
                Console.ReadKey();
            }
        }
        private void ordenarPorId(ref Club[] listado, int nCargados, int creciente)
        {
            Club aux = new Club();
            if (nCargados > 0)
            {
                for (int i = 0; i < nCargados - 1; i++)
                {
                    for (int j = i + 1; j < nCargados; j++)
                    {
                        //orden creciente    || orden decreciente
                        if (creciente == 1 && listado[i].Id > listado[j].Id
                            || creciente == 0 && listado[i].Id < listado[j].Id)
                        {
                            //switch
                            aux = listado[i];
                            listado[i] = listado[j];
                            listado[j] = aux;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("****No hay datos cargados");
                Console.ReadKey();
            }
        }
        public int listarTodo(Club[] listado, int nCargados)
        {
            Console.WriteLine("Socios ID Nombre Telefono  Actividades");
            for (int i = 0; i < nCargados; i++)
            {
                if (listado[i] == null)
                {
                    Console.WriteLine("Tengo un null***");
                }
                else
                {


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
            if (nCargados < maxSize)
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
        private void funcionDebusquedaPorId(ref Club[] listado, int nCargados, int maxSize)
        {
            string lectura;
            bool lecturaExistosa;
            int idBuscado;
            int indiceDevuelto = -1;

            Console.Clear();
            Console.WriteLine("Ingrese el Id buscado:");
            lectura = Console.ReadLine();
            lecturaExistosa = int.TryParse(lectura, out idBuscado);

            if (lecturaExistosa)
            {
                //primero ordena por id luego hace busqueda binaria
                ordenarPorId(ref listado, nCargados, 1);

                indiceDevuelto = busquedaBinaria(listado, idBuscado, 0, nCargados - 1);

                if (indiceDevuelto != -1)
                {
                    Console.WriteLine("***Informacion del club\n" + listado[indiceDevuelto].ToString());

                }
                else
                {
                    Console.WriteLine("****No se hallo el id: " + idBuscado);
                }

            }
            else
            {
                Console.WriteLine("***Ingreso invalido: " + lectura);
            }
            Console.ReadKey();

        }
        private int busquedaBinaria(Club[] listado, int busqueda, int izquierda, int derecha)
        {
            if (izquierda > derecha)
            {
                return -1;
            }
            // Comprobar si está en el centro
            int indiceCentral = Convert.ToInt32(Math.Floor(Convert.ToDouble(izquierda + derecha) / 2));
            int valorCentral = listado[indiceCentral].Id;
            if (valorCentral == busqueda)
            {
                return indiceCentral;
            }
            // Si no, debido a que esto ya está ordenado, analizamos dónde podría estar
            if (busqueda < valorCentral)
            {
                // Si lo que buscamos es menor, debe estar a la izquierda
                derecha = indiceCentral - 1;
            }
            else
            {
                // Si no, está a la derecha
                izquierda = indiceCentral + 1;
            }
            return busquedaBinaria(listado, busqueda, izquierda, derecha);
        }
        private void submenuBuscarActividades(ref Club[] listado, int nCargados, int maxSize)
        {
            string lectura;
            int opcion;
            bool lecturaExitosa = false;
            int salida = 3;
            do
            {
                Console.Clear();
                Console.WriteLine("**Reportes de Actividades***\n");
                Console.WriteLine("1-Ver todas las actividades!");
                Console.WriteLine("2-Buscar una actividad");
                Console.WriteLine("3-Volver al menu anterior");
                Console.WriteLine("\n***Ingrese opcion:");
                lectura = Console.ReadLine();
                lecturaExitosa = int.TryParse(lectura, out opcion);

                if (lecturaExitosa)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("1-Ver todas las actividades!");
                            listarActividades(listado, nCargados);
                            break;
                        case 2:
                            Console.WriteLine("2-Buscar una actividad");
                            buscarUnaActividad(listado, nCargados);
                            break;
                        case 3:
                            Console.WriteLine("3-Volver al menu anterior");
                            break;
                        default:
                            Console.WriteLine("Opcion invalida: " + lectura);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opcion invalida: " + lectura);
                    opcion = salida;

                }
            } while (opcion != salida);




        }

        private void listarActividades(Club[] listado, int nCargados)
        {
            string actividadesLeidas = "";
            int banderaActividades = 0;//pesimista
            if (nCargados > 0)
            {
                for (int i = 0; i < nCargados; i++)
                {
                    actividadesLeidas += listado[i].Actividades + "\\";
                    banderaActividades++;
                }
                if (banderaActividades > 0)
                {
                    Console.WriteLine("Actividades disponibles: \n" + actividadesLeidas);
                }
            }
            else
            {
                Console.WriteLine("***No hay elementos cargados");
            }

            Console.ReadKey();
        }

        private void buscarUnaActividad(Club[] listado, int nCargados)
        {
            string actividadBuscada;
            Console.WriteLine("Ingrese la actividad buscada:");
            actividadBuscada = Console.ReadLine();
            string informeSalida = "";
            for (int i = 0; i < nCargados; i++)
            {
                if (listado[i].tieneActividad(actividadBuscada))
                {
                    informeSalida = informeSalida + " \n" + listado[i].Nombre;
                }
            }
            Console.WriteLine("Informe de clubes con " + actividadBuscada + "\n" + informeSalida);
            Console.WriteLine("***Fin de informe***");
            Console.ReadKey();
        }
        /*7. reporte de todos los clubes que tengan declarada cierta actividad deportiva (fútbol, básquet, vóley, etc). Este reporte debe pedirme por consola la actividad que quiero buscar y luego sacar el reporte. Además, quiero generar un nuevo vector, de cada uno de los tipos de actividades.

Descomposicion del problema o historia de usuario:

--Primera parte:
"reporte de todos los clubes que tengan declarada cierta actividad deportiva (fútbol, básquet, vóley, etc). Este reporte debe pedirme por consola la actividad que quiero buscar y luego sacar el reporte."

1 Ingreso una actividad-string-: Ejemplo 'Basquet'
2 Se buscan los clubes que incluyan 'basquet' dentro de Actividades
3 Se me devuelve un listado de esos clubes -si existen
        *//*
--Segunda parte
"Además, quiero generar un nuevo vector, de cada uno de los tipos de actividades"
       Esta tarea es más general que la anterior. Creo conveniente ponerla como una  opcion aparte dentro del submenu de informes.
*/
    }
}
