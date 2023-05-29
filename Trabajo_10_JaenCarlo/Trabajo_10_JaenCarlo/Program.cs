using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_10_JaenCarlo
{
    class Program
    {
        static void Main(string[] args)
        {

            
            TourVacaciones Miobjeto = new TourVacaciones(); // creo un objeto tipo tourVacaciones para poder utilizar los metodos de esa clase
            TourVacaciones[] arregloObjetos = Miobjeto.MetodoCrearObjetosArreglo();
            Miobjeto.MostrarArregloObjetos(arregloObjetos);


            //En el método main, defina un arreglo de clases anónimas que almacene la información de 6 vehículos,
            //para cada vehículo debe almacenar los siguientes datos (usted inventará los valores de los datos).
            var vehiculos = new[]
            {
                new { Placa = "ABC123", Tipo = "Automóvil", Color = "Rojo", Año = 2020, Fabricante = "Ford", Modelo = "Focus" },
                new { Placa = "DEF456", Tipo = "SUB 4x2", Color = "Azul", Año = 2018, Fabricante = "Chevrolet", Modelo = "Tracker" },
                new { Placa = "GHI789", Tipo = "SUB 4x4", Color = "Negro", Año = 2021, Fabricante = "Jeep", Modelo = "Wrangler" },
                new { Placa = "JKL012", Tipo = "Automóvil", Color = "Blanco", Año = 2019, Fabricante = "Toyota", Modelo = "Corolla" },
                new { Placa = "MNO345", Tipo = "SUB 4x4", Color = "Gris", Año = 2022, Fabricante = "Land Rover", Modelo = "Discovery" },
                new { Placa = "PQR678", Tipo = "Automóvil", Color = "Plateado", Año = 2020, Fabricante = "Honda", Modelo = "Civic" }
            };

            // Cree un ciclo for each que muestre en pantalla de forma ordenada y
            // tabulada los datos del arreglo creado en el punto anterior. 
            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine("Placa: " + vehiculo.Placa);
                Console.WriteLine("Tipo: " + vehiculo.Tipo);
                Console.WriteLine("Color: " + vehiculo.Color);
                Console.WriteLine("Año: " + vehiculo.Año);
                Console.WriteLine("Fabricante: " + vehiculo.Fabricante);
                Console.WriteLine("Modelo: " + vehiculo.Modelo);
                Console.WriteLine("--------------------------");
            }
            Console.ReadKey();
        }
    }

    class TourVacaciones
    {
        private int idTour;
        private string destino;
        private decimal precio;
        private DateTime fechaSalida;
        private DateTime fechaRegreso;
        private string descripcion;

        //atributo llamado contador que sea de tipo estático
        private static int contador = 0;


        // Getters

        public int GetIdTour()
        {
            return idTour;
        }

        public string GetDestino()
        {
            return destino;
        }

        public DateTime GetFechaSalida()
        {
            return fechaSalida.Date;
        }

        public DateTime GetFechaRegreso()
        {
            return fechaRegreso.Date;
        }

        public decimal GetPrecio()
        {
            return precio;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        // Setters

        public void SetIdTour(int idTour)
        {
            this.idTour = idTour;
        }

        public void SetDestino(string destino)
        {
            this.destino = destino;
        }

        public void SetFechaSalida(DateTime fecha)
        {
            fechaSalida = fecha;
        }

        public void SetFechaRegreso(DateTime fecha)
        {
            fechaRegreso = fecha;
        }

        public void SetPrecio(decimal precio)
        {
            this.precio = precio;
        }
        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }


        //Cree un método que retorne un arreglo de objetos TourVacaciones,
        //el trabajo que hará el método será pedirle al usuario los datos de 5 tours,
        //crear un arreglo de objetos, ir guardando los datos que escriba el usuario de cada Tour en un objeto
        //y almacenar en cada posición cada objeto. Finalmente retornar el arreglo con los 5 objetos.
        //Debe utilizar los métodos de acceso creados.

        public TourVacaciones[] MetodoCrearObjetosArreglo()
        {
            TourVacaciones[] arregloObjetos = new TourVacaciones[1];

            for (int i = 0; i < arregloObjetos.Length; i++)
            {
                TourVacaciones tour = new TourVacaciones();

                Console.WriteLine("Ingrese la informacion del tour #" + (i + 1));
                tour.SetIdTour(i);

                Console.WriteLine("Ingrese el nombre del destino");
                tour.SetDestino(Console.ReadLine());

                Console.WriteLine("\nIngrese la fecha de salida");
                Console.WriteLine("Ingrese el año");
                int ano = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el mes");
                int mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el dia");
                int dia = Convert.ToInt32(Console.ReadLine());

                DateTime salida = new DateTime(ano,mes,dia);
                tour.SetFechaSalida(salida);

                Console.WriteLine("\nIngrese la fecha de regreso");
                Console.WriteLine("Ingrese el año");
                ano = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el mes");
                mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el dia");
                dia = Convert.ToInt32(Console.ReadLine());

                DateTime regreso = new DateTime(ano, mes, dia);
                tour.SetFechaRegreso(regreso);

                Console.WriteLine("\nIngrese el precio");
                decimal precio = Convert.ToDecimal(Console.ReadLine());
                if (precio < 0)
                {
                    Console.WriteLine("Dato invalido por default cera 0");
                    tour.SetPrecio(0);
                }
                else
                {
                    tour.SetPrecio(precio);
                }

                Console.WriteLine("\nIngrese la descripcion");
                tour.SetDescripcion(Console.ReadLine());
                Console.WriteLine();
                arregloObjetos[i] = tour;
            }

            return arregloObjetos;
        }

        public void MostrarArregloObjetos(TourVacaciones[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("\n*************************************" +
                                  "\nTour #" + (i + 1) +
                                  "\nId tour: " + arreglo[i].idTour + 
                                  "\nDestino: " + arreglo[i].destino +
                                 "\nFecha de Salida: " + arreglo[i].fechaSalida +
                                 "\nFecha de Regreso: " + arreglo[i].fechaRegreso +
                                  "\nPrecio: " + arreglo[i].precio +
                                 "\nDescripcion: " + arreglo[i].descripcion + "\n" +
                                 "*************************************\n");
            }
        }


        //Cree un método constructor que reciba todos los atributos.
        //otro método constructor que no reciba ningún parámetro e
        //inicialice todos los atributos a sus valores por defecto.
        public TourVacaciones(int idTour, string destino,decimal precio, DateTime fechaSalida, DateTime fechaRegreso, string descripcion) {
            
            //en los métodos constructores agregue el código necesario para que cada
            //vez que se cree una instancia de la clase se aumente el contador
            contador++;

            if (precio > 0)
            {
            this.idTour = idTour;
            this.destino = destino;
            this.precio = precio;
            this.fechaSalida = fechaSalida;
            this.fechaRegreso = fechaRegreso;
            this.descripcion = descripcion;
            }
            else
            {
                Console.WriteLine("El precio debe ser mayor a 0...!!!");
            }
        
        }

        public TourVacaciones()
        {
            //en los métodos constructores agregue el código necesario para que cada
            //vez que se cree una instancia de la clase se aumente el contador
            contador++;

            idTour = 1111;
            destino = "Colombia";
            precio = 800000;
            fechaSalida = new DateTime(2024,8,2);
            fechaRegreso = new DateTime(2024, 8, 28);
            descripcion = "Tu aventura comienza en la animada ciudad de Bogotá, la capital de Colombia." +
                " Aquí encontrarás una combinación fascinante de lo moderno y lo histórico. " +
                "Podrás visitar el famoso Museo del Oro, que alberga una vasta colección de artefactos precolombinos de oro, " +
                "y caminar por las coloridas calles del barrio La Candelaria, donde se encuentran las antiguas casas coloniales" +
                " y numerosos cafés acogedores.";
        }
        //1Defina en su clase TourVacaciones un método estático que muestre
        //en pantalla la cantidad de objetos existentes, se llamará MostrarCantidadObjetos() 
        public static void MostrarCantidadObjetos()
        {
            Console.WriteLine("Cantidad de objetos TourVacaciones existentes es: " + contador);
        }

    }
}
