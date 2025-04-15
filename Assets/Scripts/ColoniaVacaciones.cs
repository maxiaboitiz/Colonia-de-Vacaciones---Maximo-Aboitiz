using System.Collections;
using System.Collections.Concurrent;
using UnityEngine;

public class ColoniaVacaciones : MonoBehaviour
{
    public int inscritosJuveniles;
    public int inscritosInfantiles;

    void Start()
    {
        // Start is called before the first frame
        if (inscritosJuveniles < 0 || inscritosJuveniles > 100 || inscritosInfantiles < 0 || inscritosInfantiles > 100)
        {
            Debug.LogError("Error: Tiene que ser un número no negativo menor o igual a 100.");
            return;
        }

        int profesoresJuveniles = inscritosJuveniles / 20;
        int profesoresInfantiles = inscritosInfantiles / 10;

        int listaEsperaJuveniles = inscritosJuveniles % 20;
        int listaEsperaInfantiles = inscritosInfantiles % 10;
        int totalListaEspera = listaEsperaJuveniles + listaEsperaInfantiles;

        int totalProfesores = profesoresJuveniles + profesoresInfantiles;
        int coordinadores = (totalProfesores + 4) / 5; 

        Debug.Log("Se necesitan " + profesoresJuveniles + " profesores para los inscriptos juveniles.");
        Debug.Log("Se necesitan " + profesoresInfantiles + " profesores para los inscriptos infantiles.");
        Debug.Log("Se necesitan " + coordinadores + " coordinadores.");
        Debug.Log("Inscriptos en lista de espera: " + totalListaEspera);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

