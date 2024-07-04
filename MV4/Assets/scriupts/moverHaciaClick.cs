using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverHaciaClick : MonoBehaviour
{
    private Vector3 targetPosition;
    private float speed = 5f; // Velocidad de movimiento del objeto

    void Update()
    {
        // Verificar si se hizo clic con el botón izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Obtener la posición del clic en el suelo
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                targetPosition = hit.point;
                targetPosition.y = transform.position.y; // Mantener la misma altura que el objeto

                // Girar el objeto para que mire hacia la posición del clic
                transform.LookAt(targetPosition);
            }
        }

        // Mover el objeto hacia la posición del clic
        if (transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}

