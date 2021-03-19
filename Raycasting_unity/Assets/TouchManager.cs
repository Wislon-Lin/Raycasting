#define PERS

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour 
{


	void Start () 
	{


	}

	void Update () 
	{
		#if OTHO
		if (Input.GetMouseButton (0)) 
	    {
			Vector3 mousePos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y,0.4f));
			Debug.DrawRay (mousePos, Vector3.forward * 1000, Color.green);	
		}
		#endif

		#if PERS
		if (Input.GetMouseButton (0))
		{
			Vector3 mousePosFar=new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.farClipPlane);
			Vector3 mousePosNear=new Vector3(Input.mousePosition.x,Input.mousePosition.y,Camera.main.nearClipPlane);
			Vector3 mousePosF=Camera.main.ScreenToWorldPoint(mousePosFar);
			Vector3 mousePosN=Camera.main.ScreenToWorldPoint(mousePosNear);
			Debug.DrawRay(mousePosN,mousePosF-mousePosN,Color.red);
		}
			
		#endif
	
	}
}
