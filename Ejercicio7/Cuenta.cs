using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//** Autor:Ráúl Fernando Medina Sandoval
//** Fecha: 28/11/2023
//** Descripcion: La clase Cuenta representa una cuenta bancaria y proporciona métodos para 
//** realizar operaciones como redimir puntos, consignar, retirar, y consultar saldo y puntos.
//**También gestiona el estado de inicio de sesión para la cuenta.
public class Cuenta
    {
    // Propiedades de la clase Cuenta
    public Double saldo { get; private set; }
    public int puntos { get; private set; }
    public String usuario { get; private set; }
    public String clave { get; private set; }
    public String cuenta { get; private set; }
    public Boolean isLoggin { get; set; }
    // Constructor de la clase Cuenta
    public Cuenta(double saldo, int puntos, string usuario, String clave, string cuenta)
    {
        this.saldo = saldo;
        this.puntos = puntos;
        this.usuario = usuario;
        this.clave = clave;
        this.cuenta = cuenta;
        this.isLoggin = false;
    }
    // Constructor  de la clase cuenta por defecto
    public Cuenta() 
    { 
    }

    public Double redimirPuntos(int puntos, Double pesosPuntos)
    {
        Double result = puntos * pesosPuntos;
        this.saldo += result;
        this.puntos -= puntos;
        return result;
    }
    // Método para verificar si es posible redimir la cantidad de puntos especificada
    public Boolean puedeRedimir(int puntos)
    {
        return this.puntos >= puntos;   // Devuelve true si la cuenta tiene suficientes puntos para redimir, de lo contrario, false 
    }

    // Método para consignar un valor a la cuenta
    public void consignar( Double valor)
        {
        this.saldo += valor; // Aumenta el saldo de la cuenta con el valor consignado
    }
    // Método para realizar un retiro de la cuenta
    public Boolean retiro(Double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;   // Realiza el retiro si hay suficientes fondos en la cuenta
            return true;   // Indica que el retiro fue exitoso
        }
        return false;    // Indica que el retiro no fue posible por falta de fondos
    }
   
    // Método para consultar el saldo actual de la cuenta
    public Double consultarSaldo()
    {
        return this.saldo;
    }
    // Método para consultar la cantidad de puntos asociados a la cuenta
    public int consultarPuntos()
    {
        return this.puntos;
    }
    // Método para establecer el estado de inicio de sesión (logueado o no)
    public void setLogin(Boolean login)
    {
        this.isLoggin=login;
    }
}



