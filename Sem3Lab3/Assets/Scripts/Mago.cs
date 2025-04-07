using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mago : Personaje
{
    private int mana;

    public Mago(string _nombre, int _fuerza, int _agilidad, int _inteligencia, int _mana)
        : base(_nombre, _fuerza, _agilidad, _inteligencia)
    {
        mana = _mana;
    }

    public Mago(Mago otro)
        : base(otro.ObtenerNombre(), otro.ObtenerFuerza(), otro.ObtenerAgilidad(), otro.ObtenerInteligencia())
    {
        mana = otro.mana;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        print("Maná: " + mana);
    }
}
