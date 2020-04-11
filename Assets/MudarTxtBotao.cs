using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MudarTxtBotao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = mudarValor();
        //txt.text = "teste";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MudarValor()
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = mudarValor();
    }
    public string mudarValor()
    {

        int a = Random.Range(0, 100);
        return a.ToString();
    }
}
