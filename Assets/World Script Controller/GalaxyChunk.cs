using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyChunk : MonoBehaviour {



	int chunkID;
	enum LoadRange {Full, sphere, point};
	LoadRange loadRange;

	//array of all the planets
	CelestialBody[,] celestialBodies;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void generateChunk (int seed, int chunkX, int chunkY)
	{
		//code to procedurally genrate a new chunk 
		//if body found pass cords(x,y,z) to generate
	}

}
