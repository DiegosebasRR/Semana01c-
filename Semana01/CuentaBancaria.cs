using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    public class CuentaBancaria
    {
        public int NumeroCuenta { get; set; }
        public string Titular { get; set; }
            
        public double  Saldo { get; set; }

        public int Pin { get; set; }
    }

    public class CajeroAutomatico: CuentaBancaria
    {
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo actual {Saldo}");
        }

        public void DepositarFondos(double cantidad)
        {
            Saldo += cantidad;

            if (cantidad > 0)
            {
                Console.WriteLine($"Se depositaron {cantidad} soles, saldo actual {Saldo}");
            }else
            {
                Console.WriteLine($"La cantidad mayor a depositar debe ser mayor 0");
            }
     
        }

        public void RetirarEfectivo(double cantidad)
        {
            

            if (cantidad > 0 && cantidad <= Saldo)
            {
                Saldo -= cantidad;
                Console.WriteLine($"Se retiraron {cantidad} soles, saldo actual {Saldo}");
            }
            else
            {
                Console.WriteLine($"La cantidad mayor a retirar es invalida o es mayor al saldo");
            }

        }

        public void CambiarPin(int newPin)
        {
            Pin = newPin;

            Console.WriteLine($"Pin cambiado, Nuevo pin es {newPin}");
        }
    }
}
