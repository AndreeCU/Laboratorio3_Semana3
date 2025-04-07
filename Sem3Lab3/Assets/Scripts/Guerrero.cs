using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guerrero : Personaje
{
    private int ira;

    public Guerrero(string _nombre, int _fuerza, int _agilidad, int _inteligencia, int _ira)
        : base(_nombre, _fuerza, _agilidad, _inteligencia)
    {
        ira = _ira;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        print("Ira: " + ira);
    }
}
