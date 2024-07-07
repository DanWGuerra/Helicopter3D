using UnityEngine;
using System.Collections;

public class DiamondSpawner : MonoBehaviour
{

	public GameObject[] Diamonds;

	// Use this for initialization
	void Start()
	{

		// infinite coin spawning function, asynchronous
		StartCoroutine(SpawnDiamonds());
	}

	// Update is called once per frame
	void Update()
	{

	}

	IEnumerator SpawnDiamonds()
	{
		while (true)
		{

			// number of coins we could spawn vertically
			int DiamondsThisRow = Random.Range(1, 2);

			// instantiate all coins in this row separated by some random amount of space
			for (int i = 0; i < DiamondsThisRow; i++)
			{
				Instantiate(Diamonds[Random.Range(0, Diamonds.Length)], new Vector3(26, Random.Range(-6, 8), 10), Quaternion.identity);
			}

			// pause 1-5 seconds until the next coin spawns
			yield return new WaitForSeconds(Random.Range(10, 15));
		}
	}
}