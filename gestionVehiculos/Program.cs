using System;
using System.Collections.Generic;

class Program
{
    static List<Vehiculo> vehiculos = new List<Vehiculo>();
    static List<Moto> motos = new List<Moto>();
    static List<Auto> autos = new List<Auto>();
    static List<Camioneta> camionetas = new List<Camioneta>();
    static void Main()
    {
        /*Una empresa de transporte necesita un sistema de consola para administrar distintos tipos de vehículos. 
        El sistema debe permitir: 
        • Registrar diferentes vehículos. 
        • Mostrar la información de cada vehículo. 
        • Simular aceleraciones y frenadas. 
        • Mostrar cómo cambia la velocidad de cada vehículo luego de realizar acciones. 
        • Permitir que cada tipo de vehículo tenga un comportamiento diferente al acelerar y frenar. 

        Requisitos funcionales: 
        • Cada vehículo debe tener información básica. 
        • El sistema debe poder trabajar con varios tipos de vehículos distintos. 
        • Cada tipo de vehículo debe implementar su propia lógica de aceleración y frenado. 
        • Desde el programa principal se deben ejecutar acciones sobre distintos vehículos 
        y mostrar los resultados en consola.*/

        Console.WriteLine("--- Bienvenido ---");
        Console.WriteLine("");
        int op = 0;

        do
        {
            Console.WriteLine("Selecciona una opcion del menu:");
            Console.WriteLine("");
            Console.WriteLine("1. Registrar vehiculo.");
            Console.WriteLine("2. Mostrar todos los vehiculos resgistrados.");
            Console.WriteLine("3. Simular acelerado.");
            Console.WriteLine("4. Simular frenado.");
            Console.WriteLine("5. Salir.");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (op)
            {
                case 1:
                    RegistrarVehiculo();
                    break;

                case 2:
                    VerRegistrados();
                    break;

                case 3:
                    SimularAceleracion();
                    break;
                case 4:
                    SimularFrenado();
                    break;

                case 5:
                    Console.WriteLine("Hasta luego...");
                    break;

                default:
                    Console.WriteLine("Ingresa una opcion valida.");
                    Console.WriteLine("");
                    break;
            }
        }
        while (op != 5);
    }
    static void RegistrarVehiculo()
    {
        int op = 0;

        do
        {
            Console.WriteLine("Ingresa el tipo de vehiculo que quieres registrar:");
            Console.WriteLine("");
            Console.WriteLine("1. Auto.");
            Console.WriteLine("2. Moto.");
            Console.WriteLine("3. Camioneta.");
            Console.WriteLine("4. Volver al menu principal.");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            switch (op)
            {
                case 1:
                    RegistrarAuto();
                    break;

                case 2:
                    RegistrarMoto();
                    break;

                case 3:
                    RegistrarCamioneta();
                    break;
                case 4:
                    Console.WriteLine("Hasta luego...");
                    break;

                default:
                    Console.WriteLine("Ingresa una opcion valida.");
                    Console.WriteLine("");
                    break;
            }
        }
        while (op != 4);

    }
    static void RegistrarAuto()
    {
        Console.WriteLine("Ingresa la marca del auto:");
        Console.WriteLine("");
        string marca = Console.ReadLine();

        Console.WriteLine("Ingresa el modelo del auto:");
        Console.WriteLine("");
        string modelo = Console.ReadLine();

        Console.WriteLine("Ingresa la velocidad maxima del auto:");
        Console.WriteLine("");
        float velocidadMaxima = float.Parse(Console.ReadLine());

        Auto auto = new Auto(marca, modelo, velocidadMaxima, 0);
        vehiculos.Add(auto);
        autos.Add(auto);
    }
    static void RegistrarMoto()
    {
        Console.WriteLine("Ingresa la marca de la moto:");
        Console.WriteLine("");
        string marca = Console.ReadLine();

        Console.WriteLine("Ingresa el modelo de la moto:");
        Console.WriteLine("");
        string modelo = Console.ReadLine();

        Console.WriteLine("Ingresa la velocidad maxima de la moto:");
        Console.WriteLine("");
        float velocidadMaxima = float.Parse(Console.ReadLine());

        Moto moto = new Moto(marca, modelo, velocidadMaxima, 0);
        vehiculos.Add(moto);
        motos.Add(moto);
    }
    static void RegistrarCamioneta()
    {
        Console.WriteLine("Ingresa la marca de la camioneta:");
        Console.WriteLine("");
        string marca = Console.ReadLine();

        Console.WriteLine("Ingresa el modelo de la camioneta:");
        Console.WriteLine("");
        string modelo = Console.ReadLine();

        Console.WriteLine("Ingresa la velocidad maxima de la camioneta:");
        Console.WriteLine("");
        float velocidadMaxima = float.Parse(Console.ReadLine());

        Camioneta camioneta = new Camioneta(marca, modelo, velocidadMaxima, 0);
        vehiculos.Add(camioneta);
        camionetas.Add(camioneta);
    }
    static void VerRegistrados()
    {
        Console.WriteLine("--- Autos ---");
        Console.WriteLine("");
        int idAuto = 1;

        if (autos.Count == 0)
        {
            Console.WriteLine("Aun no hay autos registrados.");
            Console.WriteLine("");
        }
        else
        {
            foreach (Auto a in autos)
            {
                Console.WriteLine($"{idAuto}. Marca: {a.Marca} --- Modelo: {a.Modelo} --- Velocidad maxima: {a.VelocidadMaxima}.");
                Console.WriteLine("");
                idAuto++;
            }
        }

        Console.WriteLine("--- Motos ---");
        Console.WriteLine("");
        int idMoto = 1;

        if (motos.Count == 0)
        {
            Console.WriteLine("Aun no hay motos registrados.");
            Console.WriteLine("");
        }
        else
        {
            foreach (Moto m in motos)
            {
                Console.WriteLine($"{idMoto}. Marca: {m.Marca} --- Modelo: {m.Modelo} --- Velocidad maxima: {m.VelocidadMaxima}.");
                Console.WriteLine("");
                idMoto++;
            }
        }


        Console.WriteLine("--- Camionetas ---");
        Console.WriteLine("");
        int idCamioneta = 1;

        if (camionetas.Count == 0)
        {
            Console.WriteLine("Aun no hay camionetas registrados.");
            Console.WriteLine("");
            idCamioneta++;
        }
        else
        {
            foreach (Camioneta c in camionetas)
            {
                Console.WriteLine($"{idCamioneta}. Marca: {c.Marca} --- Modelo: {c.Modelo} --- Velocidad maxima: {c.VelocidadMaxima}.");
                Console.WriteLine("");
            }
        }
    }

    static void SimularAceleracion()
    {
        Console.WriteLine("--- Vehiculos ---");
        Console.WriteLine("");
        int idVehiculo = 1;
        int eleccionVehiculo;

        if (vehiculos.Count == 0)
        {
            Console.WriteLine("Aun no hay vehiculos registrados.");
            Console.WriteLine("");
        }
        else
        {
            foreach (Vehiculo v in vehiculos)
            {
                Console.WriteLine($"{idVehiculo}. Marca: {v.Marca} --- Modelo: {v.Modelo} --- Velocidad maxima: {v.VelocidadMaxima}.");
                Console.WriteLine("");
                idVehiculo++;
            }
            Console.WriteLine("Ingrese el numero del vehiculo que desea acelerar:");
            eleccionVehiculo = int.Parse(Console.ReadLine());

            if (eleccionVehiculo > vehiculos.Count)
            {
                Console.WriteLine("Ingresa un numero valido.");
                Console.WriteLine("");
            }
            else
            {
                Vehiculo vehiculoSeleccionado = vehiculos[eleccionVehiculo - 1];
                float velocidadActual = vehiculoSeleccionado.Acelerar(vehiculoSeleccionado.VelocidadMaxima, vehiculoSeleccionado.VelocidadActual);
                Console.WriteLine("El vehiculo ha acelerado. Su velocidad actual es: " + velocidadActual);
            }
        }
    }

    static void SimularFrenado()
    {
        Console.WriteLine("--- Vehiculos ---");
        Console.WriteLine("");
        int idVehiculo = 1;
        int eleccionVehiculo;

        if (vehiculos.Count == 0)
        {
            Console.WriteLine("Aun no hay vehiculos registrados.");
            Console.WriteLine("");
        }
        else
        {
            foreach (Vehiculo v in vehiculos)
            {
                Console.WriteLine($"{idVehiculo}. Marca: {v.Marca} --- Modelo: {v.Modelo} --- Velocidad maxima: {v.VelocidadMaxima}.");
                Console.WriteLine("");
                idVehiculo++;
            }
            Console.WriteLine("Ingrese el numero del vehiculo que desea frenar:");
            eleccionVehiculo = int.Parse(Console.ReadLine());

            if (eleccionVehiculo > vehiculos.Count)
            {
                Console.WriteLine("Ingresa un numero valido.");
                Console.WriteLine("");
            }
            else
            {
                Vehiculo vehiculoSeleccionado = vehiculos[eleccionVehiculo - 1];
                float velocidadActual = vehiculoSeleccionado.Frenar(vehiculoSeleccionado.VelocidadActual, vehiculoSeleccionado.VelocidadMaxima);
                Console.WriteLine("El vehiculo ha frenado. Su velocidad actual es: " + velocidadActual);
            }
        }
    }
}
