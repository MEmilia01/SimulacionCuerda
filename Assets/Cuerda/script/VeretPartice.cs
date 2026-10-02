using UnityEngine;

public class VeretPartice : MonoBehaviour
{
    public Vector3 posicion;
    public Vector3 posicionpasada;
    public bool puntofinjo;

    public VerletParticle(Vector3 pos, bool puntofijo)
    {
        posicion = pos;
        posicionpasada = pos;
        this.puntofinjo = puntofijo;
    }
    
    public void Simulacion(Vector3 aceleracion, float fdt)
    {
        if (puntofinjo) { return; }

    }
}
