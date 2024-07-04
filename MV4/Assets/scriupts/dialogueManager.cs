using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;
    public string[] interestingData; // Array de datos interesantes
    public float minDelay = 5f; // Tiempo m�nimo de espera entre di�logos
    public float maxDelay = 10f; // Tiempo m�ximo de espera entre di�logos

    void Start()
    {
        // Iniciar la corrutina para mostrar di�logos
        StartCoroutine(ShowRandomDialog());
    }

    IEnumerator ShowRandomDialog()
    {
        // Bucle infinito para generar di�logos aleatorios
        while (true)
        {
            // Generar un lapso de tiempo aleatorio antes del pr�ximo di�logo
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            // Seleccionar un dato interesante aleatorio del array
            string randomData = interestingData[Random.Range(0, interestingData.Length)];

            // Mostrar el dato interesante en el cuadro de di�logo
            dialogText.text = randomData;

            // Esperar un breve tiempo antes de limpiar el cuadro de di�logo
            yield return new WaitForSeconds(3f);

            // Limpiar el cuadro de di�logo
            dialogText.text = "";
        }
    }
}

