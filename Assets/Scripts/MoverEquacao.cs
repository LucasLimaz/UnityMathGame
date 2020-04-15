using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverEquacao : MonoBehaviour
{

    ScoreManager score;
    public float Speed = 1f;
    bool isOn = true;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
            
        if(isOn == true)
        { 
            Vector3 pos = transform.position;
            pos.y =     pos.y - Speed * Time.deltaTime;
            transform.position = pos;

            if(pos.y <= -475.8375)
            {
                GameObject.Destroy(gameObject);
                GameObject.Find("ScoreManager").GetComponent<ScoreManager>().LoseLife();
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("floor"))
        {
            GameObject.Destroy(gameObject);
            isOn = false;
        }
    }

    public void DestruirObjeto()
    {
        GameObject.Destroy(gameObject);
    }
}
