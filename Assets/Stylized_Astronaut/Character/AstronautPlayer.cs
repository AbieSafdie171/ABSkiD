using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



	public class AstronautPlayer : MonoBehaviour {

		private Animator anim;
		private CharacterController controller;

		public AstronautThirdPersonCamera shake;

		public static float speed = 25f;
		public float turnSpeed;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;

		// Hannah Abikzer
		public static bool fran = false;
		public AudioSource thicc;

		// Daniel Moss
		public static bool danielAlcohol = false;

		// Jacque Velasco
		public static bool jacquePickup = false;

		// Jordan Zicklin
		public static bool dadBod = false;
		public AudioSource shakeDadBod;

		// Lucinda Smith
		public static bool ghoster = false;


		public GameObject leftSki;

		public GameObject rightSki;

		public HealthBar healthBar;

		public FloatBar oxygenBar;

		public FloatBar heatBar;

		public HealthBar xFactorBar;

		void Start () {
			fran = false;
			danielAlcohol = false;
			jacquePickup = false;
			ghoster = false;
			controller = GetComponent <CharacterController>();
			anim = gameObject.GetComponentInChildren<Animator>();
		}

		void Update (){

			if(controller.isGrounded){
				moveDirection = transform.forward * speed;
			}

			float turn = Input.GetAxis("Horizontal");

			float val = turn * turnSpeed * Time.deltaTime;

			float curAngle = transform.eulerAngles.y;

			if (curAngle < 290 && curAngle > 270){
				transform.Rotate(0, 2, 0);}
			else if (curAngle > 70 && curAngle < 90){
				transform.Rotate(0, -2, 0);}

			// turn right
			if (val > 0 && (curAngle >= 290 || curAngle <= 70)){
				transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);}

			// turn left
			if (val < 0 && (curAngle >= 290 || curAngle <= 70)){
				transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);}

			
			controller.Move(moveDirection * Time.deltaTime);

			if (transform.position.x <= -20f){
				moveDirection.x += 2.0f;
			}

			if (transform.position.x >= 20f){
				moveDirection.x -= 2.0f;
			}


			moveDirection.y -= gravity * Time.deltaTime;
		}


	private void OnTriggerEnter(Collider other){

            if (other.gameObject.name == "tree 5(Clone)" || other.gameObject.name =="tree 6(Clone)"
			|| other.gameObject.name == "tree 16(Clone)" || other.gameObject.name == "Tree Trunk 1(Clone)")
			{
				if (fran || dadBod || ghoster){
					if (fran){
						thicc.Play();
						Destroy(other.gameObject);
					}
					else if (dadBod){
						shakeDadBod.Play();
						Destroy(other.gameObject);
					}
					/*
					else if (ghoster){

					}
					*/
				} 
				else {
					int cHealth = healthBar.GetCurrentHealth();
					cHealth--;
					healthBar.SetHealth(cHealth);

				if (healthBar.GetCurrentHealth() == 0){
					SceneManager.LoadScene("TreeDeath");
				}
				}
			}

            if (other.gameObject.name == "Heart(Clone)" || other.gameObject.name == "Heart(Clone)(Clone)")
			{
				int cHealth = healthBar.GetCurrentHealth();
				if (jacquePickup){
					cHealth += 2;}
				else {
					cHealth++;
					}
				healthBar.SetHealth(cHealth);
			}

			if (other.gameObject.name == "Oxygen(Clone)" || other.gameObject.name == "Oxygen(Clone)(Clone)")
			{
				int increase = 200;
				if (jacquePickup)
					increase *= 2;
				float cHealth = oxygenBar.GetCurrentHealth();

				cHealth += increase;
				oxygenBar.SetHealth(cHealth);
				
			}

			if (other.gameObject.name == "Sun(Clone)" || other.gameObject.name == "Sun(Clone)(Clone)")
			{
				int increase = 200;
				float cHealth = heatBar.GetCurrentHealth();
				if (jacquePickup)
					increase *= 2;

				cHealth += increase;
				heatBar.SetHealth(cHealth);
				
			}

			if (other.gameObject.name == "X-Factor(Clone)" || other.gameObject.name == "X-Factor(Clone)(Clone)")
			{
				int cHealth = xFactorBar.GetCurrentHealth();
				cHealth++;
				xFactorBar.SetHealth(cHealth);
			}
			if (other.gameObject.name == "watermelon(Clone)" || other.gameObject.name == "watermelon(Clone)(Clone)")
			{
				int increase = 200;
				if (jacquePickup)
					increase *= 2;
				/*
				int cHealth = xFactorBar.GetCurrentHealth();
				cHealth++;
				xFactorBar.SetHealth(cHealth);
				*/
				float cHealth2 = heatBar.GetCurrentHealth();
				cHealth2 += increase;
				heatBar.SetHealth(cHealth2);

				int cHealth3 = healthBar.GetCurrentHealth();
				if (jacquePickup){
					cHealth3 += 2;}
				else {
					cHealth3++;
					}
				healthBar.SetHealth(cHealth3);

				float cHealth4 = oxygenBar.GetCurrentHealth();
				cHealth4 += increase;
				oxygenBar.SetHealth(cHealth4);

				GameManager.increaseScore(500);

			}

			if (other.gameObject.name == "Alcohol(Clone)" || other.gameObject.name == "Alcohol(Clone)(Clone)")
			{
				GameManager.increaseScore(250);

				float tol = (float)GameManager.alcoholTolerance;

				float d;
				float m;

				d = (Mathf.Abs(tol - 100f)) / 20f;

				m = (Mathf.Abs(tol - 100f)) / 75f;


				if (danielAlcohol == false)
					StartCoroutine(shake.Shake(d, m));

				int cHealth = healthBar.GetCurrentHealth();

				if (danielAlcohol == false)
					cHealth--;

				healthBar.SetHealth(cHealth);

				if (cHealth == 0){
					SceneManager.LoadScene("AlcoholDeath");
				}

				float oxHealth = oxygenBar.GetCurrentHealth();

				float heatHealth = heatBar.GetCurrentHealth();

				int alcIncrease = 200;

				if (danielAlcohol || jacquePickup)
					alcIncrease *= 2;

				if (oxHealth >= heatHealth){
					heatHealth += alcIncrease;
					heatBar.SetHealth(heatHealth);
				} else{
					oxHealth += alcIncrease;
					oxygenBar.SetHealth(oxHealth);
				}

			}

			

    }

	}
