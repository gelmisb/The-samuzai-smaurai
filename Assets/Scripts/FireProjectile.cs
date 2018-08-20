using UnityEngine;
using System.Collections;

public class FireProjectile : MonoBehaviour 
{
	// shortest time between firing another projectile
	const float FIRE_DELAY = 0.50f;
	
	// ref to prefab of object to be 'fired'
	public Rigidbody projectilePrefab;

	// change size of force (speed) given to projectile
	public float projectileSpeed = 600f;

	// value Time.time must reach before next projectile can be fired
	private float nextFireTime = 0f;

	private const float MIN_Y = -1;

	//--------------------------------
	// every frame check if fire key pressed (if past time to fire next projectile)
	void Update() 
	{
		if( Time.time > nextFireTime )
			CheckFireKey();
	}	

	//-----------------------------------
	// if fire pressed create projectile and update time for next time allowed to fire
	private void CheckFireKey() 
	{
		if( Input.GetButton("Fire1")) 
		{
			CreateProjectile();
			
			// ensure a delay before next projectile can be fired
			nextFireTime = Time.time + FIRE_DELAY;
		}
	}
	
	private void CreateProjectile() 
	{
		Vector3 position = transform.position;
		Quaternion rotation = transform.rotation;
		Rigidbody projectileRigidBody = (Rigidbody)Instantiate(projectilePrefab, position, rotation);

		// create and apply velocity 
		// use TransformDirection() so direction is relative to current direction spawner is facing
		Vector3 projectileVelocity = transform.TransformDirection(Vector3.forward * projectileSpeed);
		projectileRigidBody.AddForce(projectileVelocity);

		// destroy object after 1.5 seconds ...
		GameObject projectileGO = projectileRigidBody.gameObject;
		Destroy(projectileGO, 1f);
	}   	
}
