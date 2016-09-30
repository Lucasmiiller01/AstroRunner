using UnityEngine;
using System.Collections;

public class PlataformBehaviuor : MonoBehaviour {

    private GameObject gameController;
	void Start () {

        gameController = GameObject.Find("GameController");
        Debug.Log(gameController);
        GeneratorOfObjects();
	}
	
	void Update () {
	
	}
    void GeneratorOfObjects()
    {
        GameObject gameObject;
        if(gameController.GetComponent<GameController>().nextObjects != null) gameObject = (GameObject)Instantiate(gameController.GetComponent<GameController>().nextObjects, new Vector2(this.transform.position.x, 0), Quaternion.identity);
        else gameObject = (GameObject)Instantiate(gameController.GetComponent<GameController>().Tobjs[Random.Range(1,3)], new Vector2(this.transform.position.x, 0), Quaternion.identity);
        gameObject.transform.parent = this.transform;
    }
     void OnCollisionEnter2D(Collision2D coll) {
         if (coll.gameObject.tag.Equals("Player")) Invoke("Decrease", 4f);

    }
     void Decrease()
     {
         this.GetComponent<Rigidbody2D>().gravityScale = 1;
         this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
     }
}
