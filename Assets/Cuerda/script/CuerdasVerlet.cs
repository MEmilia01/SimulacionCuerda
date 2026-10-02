using System.Collections.Generic;
using UnityEngine;

public class CuerdasVerlet : MonoBehaviour
{
    [Min(2)]
    [SerializeField] uint munputos = 10;
    [SerializeField] float longitudescuerdas = 5f;

    [SerializeField] Vector3 aceleracion = new Vector3(0, -9.8f, 0);
    List<VeretPartice> listasparticulas;

    void Start()
    {
        listasparticulas = new List<VeretPartice>();
        for (int i = 0; i < munputos; i++) { listasparticulas.Add(new VeretPartice(new Vector3(i * longitudescuerdas, 0, 0), i == 0)); }
    }

    // Update is called once per frame
    void Update()
    {
        Dibujarlista();
    }

    void Dibujarlista()
    {
        for (int i = 0; i < listasparticulas.Count; i++)
        {
            Debug.DrawLine(listasparticulas[i - 1].posicion, listasparticulas[i].posicion, );
        }
    }
}
