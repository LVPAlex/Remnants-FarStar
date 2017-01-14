using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyController : MonoBehaviour {

	//Master galaxy settings
	int chunkRadius = 6;//max number of chunks to load from the player
	public const double LIGHTYEAR = 9460800000000.0;
	public int chunkSide = 100; //height and width of galaxy


	public List<GalaxyChunk> chunks;

	GameObject playerObj;
	Transform lastPos;
	int timer;
	int checkDelay = 1;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= checkDelay) { //Add instructions to handle how fast the player is moving like on a ship they would chceck the 
			//playe position much more frequently than when on a planet

			lastPos = playerObj.transform;//save the last position

			//update loaded chunks

			//call chunkcheck


		}




	}

	void chunkCheck()
	{


			//checks if all chunks can be kept or if new chunks need to be loaded and the old ones destroyed
			//if the player position has a left over chunk loaded and more than 6.5 chunks away destroy else keep

		//if loaidng a new chunk call chunk generation and send chunk iD
	}


	//populate local region
	//check for loading additional chucnk information


	//destroy unloaded chunk information
	void destroyChunk(){//pass chunk ID




	}
}
