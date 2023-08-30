// See https://aka.ms/new-console-template for more information
using Semana01;





CajeroAutomatico usuario = new CajeroAutomatico();

usuario.Saldo = 100;
usuario.Titular = "Diego";
usuario.Pin = 123;

Console.WriteLine("Ingresa tu Pin");
int pin = Convert.ToInt32(Console.ReadLine());

if (pin == usuario.Pin)
{
    Console.WriteLine("Contraseña correcta");

    while (true)
    {
        Console.WriteLine("Elige una operacion:");
        Console.WriteLine("1: Consultar saldo 2: Depositar 3: Retirar saldo 4: Cambiar pin 5: Salir");
        int opcion = Convert.ToInt32(Console.ReadLine());

        if (opcion == 1)
        {
            usuario.ConsultarSaldo();
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Monto a depositar");
            int monto = Convert.ToInt32(Console.ReadLine());
            usuario.DepositarFondos(monto);
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Monto a retirar");
            int monto = Convert.ToInt32(Console.ReadLine());
            usuario.RetirarEfectivo(monto);
        }
        else if (opcion == 4)
        {
            Console.WriteLine("Cambiar pin");
            int newPin = Convert.ToInt32(Console.ReadLine());

            if (newPin == usuario.Pin)
            {
                Console.WriteLine("Pin no debe ser igual al anterior");
            }
            else
            {
                usuario.CambiarPin(newPin);
                usuario.Pin = newPin; 
            }
        }
        else if (opcion == 5)
        {
            Console.WriteLine("Saliendo...");
            break; 
        }
        else
        {
            Console.WriteLine("Opción inválida");
        }
    }
}
else
{
    Console.WriteLine("Contraseña incorrecta");
}
