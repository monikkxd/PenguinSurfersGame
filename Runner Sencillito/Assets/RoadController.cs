using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public float speed = 5f; // Velocidad de desplazamiento hacia adelante
    private Renderer roadRenderer;

    void Start()
    {
        roadRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        // Desplazamiento hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Si la carretera ya no está visible en la pantalla, eliminarla
        if (!roadRenderer.isVisible)
        {
            Destroy(gameObject);
        }
    }
}

