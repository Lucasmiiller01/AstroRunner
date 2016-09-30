using UnityEngine;
using System.Collections;

public class SpawnsObjectsManager : MonoBehaviour {

    public GameObject ground;
   // public Transform target;
    public Transform target_;

	void Start () {
       // InvokeRepeating("GeneratorOfObjects", 3f, 2f);
        InvokeRepeating("GeneratorOfMap", 2f, 2f);
	}
	
	void Update () {
	
	}
  
    void GeneratorOfMap()
    {
        GameObject gameObject = (GameObject)Instantiate(ground, new Vector2(target_.position.x + 10, -0.4f), Quaternion.identity);
        target_ = gameObject.transform;
    }
    void OnCollisionStay2D (Collision2D coll) {
        if (coll.gameObject.tag.Equals("map"))
            Destroy(coll.gameObject);
    }
}
