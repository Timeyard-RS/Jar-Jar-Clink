using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S_Flick : MonoBehaviour {

	public GameObject ParentManager;
    public GameObject JarTouched;
    

	Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;
    Vector2 testSwipe;

    public float thrust;
    public float UpThrust;
    public float ThrowForce;
    
	public Rigidbody rb;

	public bool thrown;
	public bool land;
	public bool Completed;

     float SwipeXLimits = 0.4f;
     float MinimumYSwipe = 35;

    float Rotation;
	public float shrinker;

	public float ColourCounter;
	public float ColourCounterMax;

    public float timer;
    public float NextAvailableCap;
    public float LifeCap;
    public float CoinInterpSpeed;

    public float CoinThrustForwards;

    public bool OnceComplete;
    public bool InTheJar;
    public bool DingOnce;

	public Color[] Colours;

	public string ColourName;

    public S_GameManager gameManager;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody>();
		ColourCounter = ColourCounterMax;
        gameManager = GameObject.Find("GAME MANAGER").GetComponent<S_GameManager>();
        SwipeXLimits = ParentManager.GetComponent<S_GameManager>().SwipeXLimits;

    }
	
	// Update is called once per frame
	void Update()
	{
        if(thrown == true)
        {
            timer += Time.deltaTime;
        }

        if(timer > NextAvailableCap && OnceComplete == false && land == false)
        {
            OnceComplete = true;
            ParentManager.GetComponent<S_GameManager>().NextThrowable();
            

            if (land == false)
            {
                //ParentManager.GetComponent<S_GameManager>().Quantity += ParentManager.GetComponent<S_GameManager>().ComboCountIndex;
                ParentManager.GetComponent<S_GameManager>().DecreaseCoinRequiredCounter();
            }
        }

        if(timer > LifeCap)
        {
            Destroy(gameObject);

            //Remove Spawnable if one exists
            if(gameManager.CurrentJar.transform.GetChild(0).childCount > 0)
            {
                Destroy(gameManager.CurrentJar.transform.GetChild(0).GetChild(0).gameObject);
                gameManager.CreateSpawnable = false;
            }

        }



        if(land == true)
        {
            transform.position = Vector3.Lerp(transform.position, JarTouched.transform.GetChild(0).position, CoinInterpSpeed * Time.deltaTime);
        }

		if (Input.GetMouseButtonDown (0) && thrown == false && ParentManager.GetComponent<S_GameManager>().Quantity > 0) {
			//save began touch 2d point
			firstPressPos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);


		}
		if (Input.GetMouseButtonUp (0) && thrown == false && ParentManager.GetComponent<S_GameManager>().Quantity > 0) {

			//save ended touch 2d point
			secondPressPos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);

			//create vector from the two points
			currentSwipe = new Vector2 (secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
            testSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            //normalize the 2d vector
            currentSwipe.Normalize ();

			//swipe upwards
			if (testSwipe.y > MinimumYSwipe && currentSwipe.x > -SwipeXLimits && currentSwipe.x < SwipeXLimits) {
				Debug.Log ("up swipe");
				print ("Swipe Up " + testSwipe.y);
                CoinThrustForwards = testSwipe.y;
                ThrowObject ();
				thrown = true;
				gameObject.name = ColourName;
			}
		}

        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase ==TouchPhase.Began && thrown == false && ParentManager.GetComponent<S_GameManager>().Quantity > 0)
            {
                //save began touch 2d point
                firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
            if (touch.phase == TouchPhase.Ended && thrown == false && ParentManager.GetComponent<S_GameManager>().Quantity > 0)
            {

                //save ended touch 2d point
                secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

                //create vector from the two points
                currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
                testSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                //normalize the 2d vector
                currentSwipe.Normalize();

                //swipe upwards
                if (testSwipe.y > MinimumYSwipe && currentSwipe.x > -SwipeXLimits && currentSwipe.x < SwipeXLimits)
                {
                    Debug.Log("up swipe");
                    print("Swipe Up "+ testSwipe.y);

                    CoinThrustForwards = testSwipe.y;
                    ThrowObject();
                    thrown = true;
                    gameObject.name = ColourName;
                }
            }
        }

        ////Rotate thrown cube
        //if (thrown == true && land == false)
        //{
        //    transform.Rotate(Rotation, Rotation, Rotation);
        //}
    }

    public void FixedUpdate()
    {
        //Rotate thrown cube
        if (thrown == true && land == false)
        {
            transform.Rotate(Rotation, Rotation, Rotation);
        }
    }

    //Throwing
    void ThrowObject()
	{
        if(gameManager.AdvancedThrowing == true)
        {
            if (CoinThrustForwards > gameManager.List_Of_Throwables[gameManager.Save_Throwable].Physics_Limitation)
            {
                CoinThrustForwards = gameManager.List_Of_Throwables[gameManager.Save_Throwable].Physics_Limitation;
            }

            if(CoinThrustForwards <= 300)
            {
                rb.AddForce(transform.forward * (thrust-55));
                rb.AddForce(transform.up * (UpThrust-55));
                print("Small Throw");
            }
            else if (CoinThrustForwards > 300 && CoinThrustForwards <= 500)
            {
                rb.AddForce(transform.forward * thrust);
                rb.AddForce(transform.up * UpThrust);
                print("Medium Throw");
            }
            else if (CoinThrustForwards > 500 )
            {
                rb.AddForce(transform.forward * (thrust+25));
                rb.AddForce(transform.up * (UpThrust+25));
                print("Large Throw");
            }

            //rb.AddForce(transform.forward * CoinThrustForwards * gameManager.List_Of_Throwables[gameManager.Save_Throwable].Physics_ForwardMultiplier);
            //print("Thruster: " + CoinThrustForwards);
            //rb.AddForce(transform.up * CoinThrustForwards * gameManager.List_Of_Throwables[gameManager.Save_Throwable].Physics_UpMultiplier);
        }
        else
        {
            rb.AddForce(transform.forward * thrust);
            rb.AddForce (transform.up * UpThrust);
        }


        rb.AddForce (transform.right * (currentSwipe.x * thrust));
		gameObject.GetComponent<Rigidbody> ().useGravity = true;
		//transform.localScale += new Vector3 (0.5f, 0.5f, 0.5f);
		Rotation = Random.Range (-10, 10);
        gameManager.ThrowSound();
        ParentManager.GetComponent<S_GameManager>().Quantity--;
        ParentManager.GetComponent<S_GameManager>().UpdateUI();

    }

    //Landing
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Jar" && land == false)
        {
            transform.SetParent(other.transform);
            land = true;
            JarTouched = other.gameObject;
            ParentManager.GetComponent<S_GameManager>().HitJar();
            if (ParentManager.GetComponent<S_GameManager>().ComboCounter.transform.childCount > 0)
            {
                ParentManager.GetComponent<S_GameManager>().ComboCounter.transform.GetChild(ParentManager.GetComponent<S_GameManager>().ComboCountIndex).GetComponent<Image>().color = Color.yellow;
            }
            //ParentManager.GetComponent<S_GameManager>().ColourComboDots();
            ParentManager.GetComponent<S_GameManager>().ComboCountIndex++;
            ParentManager.GetComponent<S_GameManager>().Score++;
            ParentManager.GetComponent<S_GameManager>().UpdateUI();


            
            if (ParentManager.GetComponent<S_GameManager>().ComboCountIndex == ParentManager.GetComponent<S_GameManager>().ComboCap)
            {
                //ParentManager.GetComponent<S_GameManager>().NextThrowable(0);
                //Destroy(other.gameObject);
                //ParentManager.GetComponent<S_GameManager>().SmashJar();
                //ParentManager.GetComponent<S_GameManager>().AwardCombo();

            }

            ParentManager.GetComponent<S_GameManager>().StartJarDelaySmash(other.gameObject);
            //ParentManager.GetComponent<S_GameManager>().SmashJar(other.gameObject);
            //ParentManager.GetComponent<S_GameManager>().NextThrowable();
            
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jar" && land == false && DingOnce == false)
        {
            DingOnce = true;
            ParentManager.GetComponent<S_GameManager>().HitJar();
        }

        if (collision.gameObject.tag == "Floor" && land == false )
        {
            ParentManager.GetComponent<S_GameManager>().HitSurface();

            if(ParentManager.GetComponent<S_GameManager>().List_Of_Throwables[ParentManager.GetComponent<S_GameManager>().Save_Throwable].DestroyOnFloorImpact == true)
            {
                timer = LifeCap;
                GameObject _spawnedParticle = Instantiate(ParentManager.GetComponent<S_GameManager>().List_Of_Throwables[ParentManager.GetComponent<S_GameManager>().Save_Throwable].DestructionParticle, transform.position, transform.rotation) as GameObject;
                Destroy(_spawnedParticle, 2);
            }
        }
    }

    //Staying
    void FreezeObject()
	{
		Completed = true;
		gameObject.GetComponent<Rigidbody> ().isKinematic = true;
		gameObject.transform.SetParent (ParentManager.transform);
		//ParentManager.GetComponent<S_GameManager> ().CheckMatch ();
	}
}
