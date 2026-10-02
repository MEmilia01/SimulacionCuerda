using UnityEngine;

public class Verletpoit : MonoBehaviour
{

    Vector3 posicionactual;
    Vector3 posicionpasada;
    [SerializeField] Vector3 velocidadinicial = new Vector3 (5,5,0);
    [SerializeField] Vector3 aceleracion = new Vector3 (0,-9.8f,0);
    void Start()
    {
        posicionactual = transform.position;
        posicionpasada = posicionactual - velocidadinicial*Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicionnueva = posicionactual + (posicionactual-posicionpasada) +aceleracion * Time.deltaTime* Time.fixedDeltaTime;
        posicionpasada = posicionactual;
        posicionactual = posicionnueva;
        transform.position = posicionactual;
    }
}
