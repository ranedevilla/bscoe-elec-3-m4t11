using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class flying		 : MonoBehaviour {

	float xThrow;
	float yThrow;
	public float forX = 2f;
	public float forY =2f;
	public float rotateX = -3f;
	public float rotationX = -15f;
	public float rotationY = 1f;
	public float rotationZ = -18f;
	public float locX, clampedX,locY,clampedY;


	void Start () {

	}

	void Update ()
	{
		xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
		yThrow = CrossPlatformInputManager.GetAxis("Vertical");

		float xThrowPos = xThrow * 5f * Time.deltaTime;
		float yThrowPos = yThrow * 5f * Time.deltaTime;


		 locX = transform.localPosition.x + xThrowPos;
		 clampedX = Mathf.Clamp(locX, -forX, forX);

		 locY = transform.localPosition.y + yThrowPos;
		 clampedY = Mathf.Clamp(locY, -forY, forY);

		transform.localPosition = new Vector3(clampedX, clampedY, transform.localPosition.z);

		forRotation();
	}

	private void forRotation()
	{

		float p = (transform.localPosition.y * rotateX) + (yThrow * rotationX);
		float y = transform.localPosition.x * rotationY;
		float r = xThrow * rotationZ;

		transform.localRotation = Quaternion.Euler(p, y, r);
	}

}