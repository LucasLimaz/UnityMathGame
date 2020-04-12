using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
	public GameObject ScoreManagerObject;
	ScoreManager ScriptWithList;
	public Sprite sprite1; 
	public Sprite sprite2; 
	public GameObject selectedObject;
	public SpriteRenderer changeSpriteVar;

	private void Start()
	{
		ScriptWithList = ScoreManagerObject.GetComponent<ScoreManager>();
	}
	private void Update()
    {
		if (selectedObject == null && ScriptWithList.EquationList.Count > 0)
		{
			selectedObject = ScriptWithList.EquationList[0];
			changeSpriteVar = selectedObject.GetComponentInChildren<SpriteRenderer>();
			changeSpriteVar.sprite = sprite2;
		}
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		if (Input.GetMouseButtonDown(0))
		{
			if (hit && hit.collider.gameObject.transform.root.CompareTag("CanClick"))
			{
				if (selectedObject != null)
				{
					changeSpriteVar=selectedObject.GetComponentInChildren<SpriteRenderer>();
					changeSpriteVar.sprite = sprite1;
				}
				selectedObject = hit.collider.gameObject.transform.root.gameObject;
				changeSpriteVar = selectedObject.GetComponentInChildren<SpriteRenderer>();
				changeSpriteVar.sprite = sprite2;
			}
		}
	}
}
