using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_MoveToPoint : MonoBehaviour {

    public bool LimitedLife;
    public float SecondsToDestroy;
    public float Speed;
    public List<GameObject> Locations;
    public int Incrementor;
    public float MinimumDistance;

	// Use this for initialization
	void Start ()
    {

	    if(LimitedLife == true)
        {
            Destroy(this.gameObject, SecondsToDestroy);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.Lerp(transform.position, Locations[Incrementor].transform.position, Speed * Time.deltaTime);
        float _distance = Vector3.Distance(transform.position, Locations[Incrementor].transform.position);
        if(_distance <= MinimumDistance)
        {
            if(Incrementor+1 > Locations.Count-1)
            {
                Incrementor = 0;
            }
            else
            {
                Incrementor++;
            }
        }

    }
}
