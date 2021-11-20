/*Consigna:


Espacio del Problema
Estamos trabajando en una empresa dedicada al negocio de venta de ropa deportiva y nos piden una cantidad de informes y datos que hay que entregar sobre los clubes de la Ciudad de Buenos Aires.

Además, nos piden un programa con un menú para que el usuario elija el reporte/información que necesite.

Se sabe, que la cantidad total de Clubes es de 300, pero al inicio de éste espacio del problema, sólo se encuentran cargados 100.

De cada Institución, se tiene la siguiente información:
- Id del Club.
- Nombre.
- Tipo de Institución (Club o Club de Barrio).
- Sede (Central – Única – Anexo - Polideportivo).
- Cantidad de Socios.
- Barrio.
- Comuna (Identificado por un número entero).
- Domicilio.
- Teléfono.
- E-mail.
- Página web.
- Actividades (Fútbol – Básquet – Natación – Voley – Tenis – Artes Marciales).
  

    
1. listar todo.

- 1 Función para la carga de datos.
2. añadir un Club al final, si hay lugar


- 1 Función de ordenamiento.
3. listar clubes ordenados por el id. 
4. clubes ordenados por el nombre del Club.

    - 1 Función de búsqueda.
5. buscar club por id y que me muestre información. (usar Algoritmo de búsqueda binaria).

6.  clubes ordenados por cantidad de socios (usar Algoritmo de Burbujeo)
7. reporte de todos los clubes que tengan declarada cierta actividad
deportiva (fútbol, básquet, vóley, etc). Este reporte debe pedirme por consola la actividad que quiero buscar y luego sacar el reporte. Además, quiero generar un nuevo vector, de cada uno de
los tipos de actividades.
8. Como usuario quiero tener un reporte de todos los clubes que tengan una página web. El reporte lo necesito ordenado por Comuna (usar Algoritmo de Burbujeo).
9. Como usuario quiero tener un reporte que diga el Id y nombre, del Club que mayor cantidad de socios tiene. 
 */



using System;

namespace TrabajoIntegrador
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int clubesYaCargados = 0;
            int maximoDeClubes = 300;
            int cantidadHardcode = 3;
            Club[] listadoGeneral = new Club[maximoDeClubes];
          
            Menu miMenu = new Menu();          
            clubesYaCargados += miMenu.hardcodearListado(ref listadoGeneral,  cantidadHardcode);
           
            //TODO
           miMenu.mostrarMenu(ref listadoGeneral, ref clubesYaCargados, maximoDeClubes);

           // miMenu.listarTodo(listadoGeneral, 300);
        }
    }
}
