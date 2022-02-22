using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
	private float countdown = 2f;

	// Update is called once per frame
	void Update()
	{
		BombDestroyCountDown();
	}

	void BombDestroyCountDown()
    {
		countdown -= Time.deltaTime;

		if (countdown <= 0f)
		{
			Destroy(gameObject);
		}
	}
}
