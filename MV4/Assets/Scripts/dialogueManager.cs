using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialogueManager : MonoBehaviour
{
    //public Text dialogText;
    public TMP_Text dialogText;
    private string[] interestingData; // Array para almacenar datos interesantes

    public float minDelay = 5f; // Tiempo mínimo de espera entre diálogos
    public float maxDelay = 10f; // Tiempo máximo de espera entre diálogos

    void Start()
    {
        // Cargar los datos interesantes desde el archivo JSON
        TextAsset jsonFile = Resources.Load<TextAsset>("datosInteresantes");
        DialogData data = JsonUtility.FromJson<DialogData>(jsonFile.text);
        interestingData = data.hechos_interesantes;

        // Iniciar la corrutina para mostrar diálogos
        StartCoroutine(ShowRandomDialog());
    }

    IEnumerator ShowRandomDialog()
    {
        // Bucle infinito para generar diálogos aleatorios
        while (true)
        {
            // Generar un lapso de tiempo aleatorio antes del próximo diálogo
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            // Seleccionar un dato interesante aleatorio del array
            string randomData = interestingData[Random.Range(0, interestingData.Length)];

            // Mostrar el dato interesante en el cuadro de diálogo
            dialogText.text = randomData;

            // Esperar un breve tiempo antes de limpiar el cuadro de diálogo
            yield return new WaitForSeconds(10f);

            // Limpiar el cuadro de diálogo
            dialogText.text = "";
        }
    }


    public void MostrarProximoDialogo()
    {
        StartCoroutine(ShowRandomDialog());
    }

}



[System.Serializable]
public class DialogData
{
    public string[] hechos_interesantes;
}
