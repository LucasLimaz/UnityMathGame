using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "floor")
        {
            Debug.Log(col);
            Debug.Log("OnCollisionEnter2D");
            var manager = GameObject.FindObjectOfType<ScoreManager>();
            manager.LoseLife();
            Destroy(transform.parent.gameObject);
        }
        
    }

}
