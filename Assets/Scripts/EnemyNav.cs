using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyNav : MonoBehaviour {
	private UnityEngine.AI.NavMeshAgent navMeshAgent;//this is for the player to 
	private GameObject player;//making player as an object
	public GameObject creature;//calling creature's go
	public GameObject coin;//game object for coin pick up
	private PlayerDisplay playerDisplay;//calling in the script
	private int enemyLives = 30;//enemy has only 30 lives
	public TextMesh damage;//show the lives remaining
	private float delayBetweenDeaths = 1;//delay between deaths
	private float nextTimeAllowedToDie = 0;//hold not to let it die
	void Start () {//starting the start script
		coin.SetActive (false);//coin is not picket up originally
		navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();//getting nav mesh agent for the enemy
		playerDisplay = GetComponent<PlayerDisplay> ();//getting playerdisplay component
		player = GameObject.FindGameObjectWithTag("Player");//saying to find player
	}//end of start method
	void Update () {//start of update method
		Vector3 playerPosition = player.transform.position;//instanciating where the playyer is on every frame
		navMeshAgent.SetDestination (playerPosition);//telling the enemy to travel to the player
		playerDisplay.UpdateEnemyLives (enemyLives);//updating its lives on every frame
		CheckIfDead();//checking if the creature has died on every frame
		string msg = "" + enemyLives;
		damage.text = msg;//shows the health thats remaining for the enemy
	}//end of update
	public void CheckIfDead(){//start of check if dead method
		if (enemyLives <= 0) {//checking if enemy's lives are lower or equal to 0
			creature.GetComponent<Animation>().wrapMode= WrapMode.Default;//default mode for animation
			creature.GetComponent<Animation>().CrossFade("Dead");//crossfading the animation and playig it
			if (Time.time > nextTimeAllowedToDie) {//giving some time for the enemy to die
				nextTimeAllowedToDie = Time.time + delayBetweenDeaths;//the other line sounds cruel
				Destroy (creature);//destroyng the enemy
			}//end of if for time
		}//end of if lives are 0
	}//end of check if dead method
	void OnTriggerStay(Collider hit){//calling the on trigger stay
		if (hit.CompareTag("PlayerSphere")) {//comparing the tags with the players
			if (Time.time > nextTimeAllowedToDie) {//the heath goes down with the time
				enemyLives-= 3;//takes 3 helth per second
				nextTimeAllowedToDie = Time.time + delayBetweenDeaths;//checking time
			}//end of time if statement
		}//end of if compare tag
	}//end of on trigger staumethod
	void OnTriggerEnter(Collider hit){//when the player enters the other collider
		if (hit.CompareTag ("PlayerSphere")) {//comparing the colliders
			CheckIfDead();//checking if the creature has died yet
			creature.GetComponent<Animation>().wrapMode= WrapMode.Loop;//looping the animation which prevents from uncalled actions
			creature.GetComponent<Animation>().CrossFade("Attack");//initiating attack animation for the enemy
		}//end of compare tag  if statement
	}//end of on trigger enter method
	void OnTriggerExit(Collider hit){//initaiting n trigger exit method
		if (hit.CompareTag("PlayerSphere")) {//so whe the playre sphere leave sthis colider
			CheckIfDead();//check if creature has died yet
			creature.GetComponent<Animation>().wrapMode= WrapMode.Loop;//looping the walking animation
			creature.GetComponent<Animation>().CrossFade("Walk");//calling and playing the walk animation
		}//end of compare that if statement
	}//end of on trigger hit method
}//end of main class



