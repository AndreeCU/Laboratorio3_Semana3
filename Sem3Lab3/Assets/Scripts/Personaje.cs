using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    protected string nombre;
    protected int fuerza;
    protected int agilidad;
    protected int inteligencia;

    public Personaje(string _nombre, int _fuerza, int _agilidad, int _inteligencia)
    {
        nombre = _nombre;
        fuerza = _fuerza;
        agilidad = _agilidad;
        inteligencia = _inteligencia;
    }

    public virtual void MostrarDatos()
    {
        print("Nombre: " + nombre + ", Fuerza: " + fuerza + ", Agilidad: " + agilidad + ", Inteligencia: " + inteligencia);
    }

    public string ObtenerNombre()
    {
        return nombre;
    }

    public int ObtenerFuerza()
    {
        return fuerza;
    }

    public int ObtenerAgilidad()
    {
        return agilidad;
    }

    public int ObtenerInteligencia()
    {
        return inteligencia;
    }
}
