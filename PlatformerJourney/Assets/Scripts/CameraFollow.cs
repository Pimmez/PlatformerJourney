using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] private float dampTime = 0.15f;
	[SerializeField] private Transform target;
	[SerializeField] private Camera cam;
	[SerializeField] private Vector3 offset;
	private Vector3 velocity = Vector3.zero;

	private void FixedUpdate()
	{
		if (target)
		{
			Vector3 point = cam.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - cam.ViewportToWorldPoint(offset + new Vector3(0,0, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
	}
}