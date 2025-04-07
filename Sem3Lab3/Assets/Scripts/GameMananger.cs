using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMananger : MonoBehaviour
{
    void Start()
    {
        // Crear personaje normal
        Personaje p1 = new Personaje("Aldo", 10, 5, 3);
        p1.MostrarDatos();

        // Crear guerrero
        Guerrero g1 = new Guerrero("Thor", 15, 6, 2, 80);
        g1.MostrarDatos();

        // Crear mago
        Mago m1 = new Mago("Merlín", 5, 8, 15, 120);
        m1.MostrarDatos();

        // Crear mago a partir de otro mago
        Mago m2 = new Mago(m1);
        m2.MostrarDatos();

        // Crear y destruir enemigo en un método temporal
        CrearEnemigo(); // Al salir del método, el enemigo queda sin referencias

        print("Continuamos con otras acciones...");
    }

    void CrearEnemigo()
    {
        Enemigo enemigoTemporal = new Enemigo("Orco Salvaje");
        // El objeto queda fuera de alcance al salir del método
    }
}
