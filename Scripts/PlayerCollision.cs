using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public Movement mov;
	
	AudioSource errorAudio;
	AudioSource normAudio;
	
	
	void Start() {
	AudioSource[] audios = GetComponents<AudioSource>();
     errorAudio = audios[1];
     normAudio = audios[0];
	 }
	void OnCollisionEnter(Collision col) 
	{
		if(col.gameObject.tag == "Obstacle")
		{
			mov.enabled = false;
			normAudio.Stop();
			errorAudio.Play();
			FindObjectOfType<GameManager>().EndGame();		
		}	

	}


	}
