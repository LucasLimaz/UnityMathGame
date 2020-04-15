using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorEquacao : MonoBehaviour
{

    public GameObject geradorEquacao;
    public float timeToCreate = 3f;
    float clock = 3;
    public float espacoEntreEquacao = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;
        if (clock >= timeToCreate)
        {
            Vector3 pos = transform.position;
            pos.x = pos.x - Random.Range(-espacoEntreEquacao, espacoEntreEquacao);
            clock = 0;
            GameObject.Instantiate(geradorEquacao, pos, Quaternion.identity);
        }
    }
}
