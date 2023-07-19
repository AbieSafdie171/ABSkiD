using UnityEngine;
using System.Collections;



	public class AstronautPlayer : MonoBehaviour {

		private Animator anim;
		private CharacterController controller;

		public float speed = 600.0f;
		public float turnSpeed = 400.0f;
		private Vector3 moveDirection = Vector3.zero;
		public float gravity = 20.0f;


		public GameObject leftSki;

		public GameObject rightSki;

		public HealthBar healthBar;

		void Start () {
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

            if (other.gameObject.name == "tree 5(Clone)"){
				int cHealth = healthBar.GetCurrentHealth();
				cHealth--;
				healthBar.SetHealth(cHealth);
				}

			if (other.gameObject.name == "tree 6(Clone)"){
        		int cHealth = healthBar.GetCurrentHealth();
				cHealth--;
				healthBar.SetHealth(cHealth);
				}

			if (other.gameObject.name == "tree 16(Clone)"){
        		int cHealth = healthBar.GetCurrentHealth();
				cHealth--;
				healthBar.SetHealth(cHealth);
				}

			if (other.gameObject.name == "Tree Trunk 1(Clone)"){
        		int cHealth = healthBar.GetCurrentHealth();
				cHealth--;
				healthBar.SetHealth(cHealth);
				}



			/*
            if (gameObject != null)
                treeSound.Play();

            int cHealth = healthBar.GetCurrentHealth();

            cHealth--;

            healthBar.SetHealth(cHealth);
			*/

    }



	}
