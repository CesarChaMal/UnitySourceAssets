using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	
	public Transform target;
	bool toggler;
	Vector3 random_pos;
	
	void Update()
	{
		bool space = Input.GetKeyDown(KeyCode.Space);
		bool r = Input.GetKeyDown(KeyCode.R);
		
		if (space)
		{
			transform.rotation = Quaternion.identity;
			toggler = !toggler;
		}
		
		if (r)
		{
			random_pos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
		}
		
		if (!toggler)
		{
			transform.rotation = Quaternion.LookRotation(target.position);
		}
		
		target.position = Vector3.Slerp(target.position, random_pos, Time.deltaTime);
		
	}
	
}
