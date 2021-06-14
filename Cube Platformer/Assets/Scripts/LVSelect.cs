using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVSelect : MonoBehaviour {

	public void LoadLv1 ()
	{
		SceneManager.LoadScene("Level1");
	}

	public void LoadLv2()
	{
		SceneManager.LoadScene("Levl2");
	}

    public void LoadLv3()
    {
        SceneManager.LoadScene("Level3");
    }
}
