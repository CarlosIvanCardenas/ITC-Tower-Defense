using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float speed = 10f;

	private Transform target;
	private int wavepointIndex = 0;

	void Start()
	{
		target = Waypoints.points [0];
	}

	void Update ()
	{
		Vector3 dir = target.position - transform.position;
		transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);

		if (Vector3.Distance (transform.position, target.position) <= 0.4f) 
		{
			GetNextWaypoint ();
			RotateEnemy();
		}
	}

	void GetNextWaypoint()
	{
		if (wavepointIndex >= Waypoints.points.Length - 1) 
		{
			Destroy (gameObject);
			return;
		}

		wavepointIndex++;
		target = Waypoints.points [wavepointIndex];
	}

	void RotateEnemy ()
	{
		switch (wavepointIndex) 
		{
		case 1:
			transform.Rotate (new Vector3(0,-90,0));
			break;
		case 2:
			transform.Rotate (new Vector3(0,90,0));
			break;
		case 3:
			transform.Rotate (new Vector3(0,90,0));
			break;
		case 4:
			transform.Rotate (new Vector3(0,-90,0));
			break;
		case 5:
			transform.Rotate (new Vector3(0,-90,0));
			break;
		case 6:
			transform.Rotate (new Vector3(0,-90,0));
			break;
		case 7:
			transform.Rotate (new Vector3(0,-90,0));
			break;
		case 8:
			transform.Rotate (new Vector3(0,90,0));
			break;
		case 9:
			transform.Rotate (new Vector3(0,90,0));
			break;
		case 10:
			transform.Rotate (new Vector3(0,90,0));
			break;
		}
	}

}
