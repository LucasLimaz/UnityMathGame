using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public GameObject Prefab;
    public List<GameObject> EquationList;
    public Vector3 Position;
    public int score;
    public int vida;
    public Shader Selected;
    public Sprite prefabSprite;

    // Start is called before the first frame update
    void Start()
    {
        EquationList = new List<GameObject>();
        score = 0;
        vida = 20;
        UpdateHudText();
        InvokeRepeating("SpawnObject", 0f, 6.0f);
    }

    //Update do antigo MouseManager Script agora com lista de objetos para seleçao
  

    public void AddScore(){
        score++;
        UpdateHudText();
    }

    public void LoseLife(){
        vida--;
        UpdateHudText();
    }

    public void UpdateHudText(){
        ScoreText.text = $"Vida: {vida}\nPontos: {score}";
    }

    public void SpawnObject(){

        var randomLocation = new Vector3(Random.Range(-260f, 261f), Random.Range(0f, 30f), 0);
        //EquationList.Add(Instantiate(Prefab,randomLocation,Quaternion.identity));

        //obj.transform.position = new Vector3(Random.Range(-260f,261f),Random.Range(0f,30f),0); //x: -260˜260 // y: 0˜100
        /*Debug.Log("hmm");
        Debug.Log(obj.GetComponent<Sprite>());
        Debug.Log(obj.GetComponent<SpriteRenderer>());*/
    }

    private void Update()
    {
        foreach(GameObject x in EquationList)
        {
            if (x == null)
            {
                EquationList.Remove(x);
            }
        }
    }
}
