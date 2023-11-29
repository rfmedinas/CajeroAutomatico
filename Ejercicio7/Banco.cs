using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Banco
    {
    public int id { get; private set; }
    public String name { get; private set; }
    public Double topeRetiro { get; private set; }
    public int pesosPuntos { get; private set; }
    public List<Cuenta> cuentas = new List<Cuenta>();

public Banco(int id, string name, double topeRetiro, int pesosPuntos)
    {
        this.id = id;
        this.name = name;
        this.topeRetiro = topeRetiro;
        this.pesosPuntos = pesosPuntos;
        
    }
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
        public Boolean transferencia (String origen, String destino, Double valor)
    {
       Cuenta cuentaOrigen = obtenerCuenta(origen);
       Cuenta cuentaDestino = obtenerCuenta(destino);
        if (cuentaOrigen.cuenta.Equals(origen) && cuentaDestino.cuenta.Equals(destino))
        {
            if (cuentaOrigen.retiro(valor))
            {
                cuentaDestino.consignar(valor);
                return true;
            }
          }
        return false;
    }
    public void agregarCuenta(Cuenta cuenta)
    {
        this.cuentas.Add(cuenta);
    }
    public Boolean autenticar(String cuenta, String clave)
    {
        foreach (Cuenta numCuenta in cuentas)
        {
          numCuenta.isLoggin = false;
        }
        foreach (Cuenta numCuenta in cuentas)
        {
            if (numCuenta.cuenta.Equals(cuenta) && numCuenta.clave.Equals(clave))
            {
                numCuenta.isLoggin = true;
                return true;
            }
        }
        return false;
    }
    public Cuenta cuentaLogeada()
    {
        foreach ( Cuenta numCuenta in cuentas)
        {
            if (numCuenta.isLoggin)
            {
            return numCuenta;
            } 
        }
        return null;
    }
}





