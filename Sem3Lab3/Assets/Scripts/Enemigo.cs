using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public static int score = 0;
    private string nombre;

    public Enemigo(string _nombre)
    {
        nombre = _nombre;
    }

    ~Enemigo()
    {
        score += 100;
        print("¡" + nombre + " fue destruido! Score actual: " + score);
    }
}
