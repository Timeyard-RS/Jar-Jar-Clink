using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_Spawnable : MonoBehaviour {

    public bool Firework;
    public float Yforce;
    public float SecondsToDestroy;

    public GameObject Particles;
    public S_GameManager GameManager;

	// Use this for initialization
	void Start ()
    {
        GameManager = GameObject.Find("GAME MANAGER").GetComponent<S_GameManager>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Firework == true)
        {
            transform.GetComponent<Rigidbody>().AddForce(new Vector3(0, Yforce, 0));
        }
		
	}

    public void IgniteFirework()
    {
        GetComponent<CapsuleCollider>().enabled = true;
        GetComponent<AudioSource>().Play();
        Firework = true;
        Destroy(this.gameObject, SecondsToDestroy);
        Particles.SetActive(true);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Balloon" && Firework == true)
        {
            GameManager.PopBalloon(other.gameObject);
            print("Balloon Collision");
        }
    }
}
