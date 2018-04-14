using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public GameObject completeLevelUI;
	
	
	public void CompleteLevel ()
	{
		completeLevelUI.SetActive(true);
	}
	
	
	
	
	public void EndGame ()
	{
	
	if(gameHasEnded == false)
	{
		gameHasEnded = true;
		Invoke("Restart", 1f);
	}

	}



	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	
	
	
	
	
	
	
}