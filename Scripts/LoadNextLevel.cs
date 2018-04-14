using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNextLevel : MonoBehaviour {

public void LoadNext ()
{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}

}
