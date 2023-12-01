using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//** Autor:Ráúl Fernando Medina Sandoval
//** Fecha: 28/11/2023
//** Descripcion: La clase Banco representa una entidad bancaria
//** y gestiona un conjunto de operaciones relacionadas con la gestión de cuentas, transferencias y autenticación de usuarios.

public class Banco
    {
    // Propiedades de la clase Banco
    public int id { get; private set; }
    public String name { get; private set; }
    public Double topeRetiro { get; private set; }
    public int pesosPuntos { get; private set; }
    public List<Cuenta> cuentas = new List<Cuenta>();
    
    // Constructor de la clase Banco
    public Banco(int id, string name, double topeRetiro, int pesosPuntos)
    {
        this.id = id;
        this.name = name;
        this.topeRetiro = topeRetiro;
        this.pesosPuntos = pesosPuntos;
        
    }
    // Método para obtener un numero de cuenta
      public Cuenta obtenerCuenta(String cuenta)
    {
        foreach ( Cuenta numCuenta in cuentas)
        {
            if (numCuenta.cuenta.Equals(cuenta))
            {
                return numCuenta;
            }
        }
      return new Cuenta();
    }
    // Método para realizar una transferencia entre  cuentas
    public Boolean transferencia (String origen, String destino, Double valor)
    {
       Cuenta cuentaOrigen = obtenerCuenta(origen);
       Cuenta cuentaDestino = obtenerCuenta(destino);
        if (cuentaOrigen.cuenta.Equals(origen) && cuentaDestino.cuenta.Equals(destino))
        {
            if (cuentaOrigen.retiro(valor))
            {
                cuentaDestino.consignar(valor);
                return true; // La transferencia fue exitosa
            }
          }
        return false;// La transferencia No exitosa
    }
    // Método para agregar una cuenta a la lista de cuentas del banco
    public void agregarCuenta(Cuenta cuenta)
    {
        this.cuentas.Add(cuenta);
    }
    // Método para autenticar una cuenta por número y clave
    public Boolean autenticar(String cuenta, String clave)
    {
        foreach (Cuenta numCuenta in cuentas)
        {
          numCuenta.isLoggin = false; // Se inicializa el estado de login como falso para todas las cuentas
        }
        foreach (Cuenta numCuenta in cuentas)
        {
            if (numCuenta.cuenta.Equals(cuenta) && numCuenta.clave.Equals(clave))
            {
                numCuenta.isLoggin = true; // Se marca la cuenta como logueada si la autenticación es exitosa
                return true; // Autenticación exitosa
            }
        }
        return false; // Autenticación fallida
    }
    // Método que vevuelve la cuenta que está actualmente logueada
    public Cuenta cuentaLogeada()
    {
        foreach ( Cuenta numCuenta in cuentas)
        {
            if (numCuenta.isLoggin)
            {
            return numCuenta; // Devuelve la cuenta logueada
            } 
        }
        return null;
    }
    public Boolean validarTope(Double valor)
    {
        return valor > topeRetiro;
    }

}





