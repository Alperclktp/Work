using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FPSCounter : MonoBehaviour
{
	[SerializeField] private Text fpsCounter;
	float count;

	IEnumerator Start()
	{
		while (true)
		{
			if (Time.timeScale == 1)
			{
				yield return new WaitForSeconds(0.1f);
				count = (1 / Time.deltaTime);
				fpsCounter.text = (Mathf.Round(count) + " FPS");
			}
			else
			{
				fpsCounter.text = "Pause";
			}
			yield return new WaitForSeconds(0.5f);
		}
	}
}
