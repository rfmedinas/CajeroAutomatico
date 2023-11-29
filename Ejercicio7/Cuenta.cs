using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Cuenta
    {
    public Double saldo { get; private set; }
    public int puntos { get; private set; }
    public String usuario { get; private set; }
    public String clave { get; private set; }
    public String cuenta { get; private set; }
    public Boolean isLoggin { get; set; }

    public Cuenta(double saldo, int puntos, string usuario, String clave, string cuenta)
    {
        this.saldo = saldo;
        this.puntos = puntos;
        this.usuario = usuario;
        this.clave = clave;
        this.cuenta = cuenta;
        this.isLoggin = false;
    }
    public Cuenta() { }
    public Double redimirPuntos(int puntos, Double pesosPuntos)
    {
        Double result = puntos * pesosPuntos;
        this.saldo += result;
        this.puntos -= puntos;
        return result;
    }
    public Boolean puedeRedimir(int puntos)
    {
        return this.puntos >= puntos;   
    }
    public void consignar( Double valor)
    {
        this.saldo += valor;
    }
    public Boolean retiro(Double valor)
    {
        if (this.saldo >= valor)
        {
            this.saldo -= valor;
            return true;
        }
        return false;
    }
    public Double consultarSaldo()
    {
        return this.saldo;
    }
    public int consultarPuntos()
    {
        return this.puntos;
    }
    public void setLogin(Boolean login)
    {
        this.isLoggin=login;
    }
}



