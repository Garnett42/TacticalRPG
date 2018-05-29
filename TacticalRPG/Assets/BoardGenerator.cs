using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGenerator : MonoBehaviour {

    public Sprite BorderImg;
    public Sprite Background;

    int width = 3;
    int height = 6;

	// Use this for initialization
	void Start () {
		//Place 18 boarder pieces
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                GameObject GO = new GameObject("BorderPiece_" + i + "" +j );
                GO.transform.SetParent(transform);
                GO.AddComponent<SpriteRenderer>();
                GO.GetComponent<SpriteRenderer>().sprite = BorderImg;
                GO.transform.position = new Vector2(2*i, j);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
