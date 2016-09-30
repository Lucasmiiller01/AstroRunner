using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    public GameObject[] Tobjs = new GameObject[3];
    int nextObj;
    int lastObj;
    public GameObject nextObjects;

	void Start () {
        InvokeRepeating("NextObj", 0f, 2f);
	}
    void NextObj()
    {
        int radom = Random.Range(0,Tobjs.Length);
        nextObj = radom;
        lastObj = nextObj;
        if (nextObj == lastObj) radom = Random.Range(0, Tobjs.Length);
        nextObjects = Tobjs[nextObj];
     
    }
	void Update () {
	
	}
}
