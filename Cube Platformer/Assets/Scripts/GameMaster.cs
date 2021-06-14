using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

	public void NewLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}
