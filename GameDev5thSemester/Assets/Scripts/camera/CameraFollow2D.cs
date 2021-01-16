using UnityEngine;
using System.Collections;

public class CameraFollow2D : MonoBehaviour
{
	public Vector2 offset = new Vector2(2f, 1f);
	public bool faceLeft;
	private Transform player;
	private int lastX;

	void Start()
	{
		offset = new Vector2(offset.x, offset.y);
		FindPlayer(faceLeft);
	}

	public void FindPlayer(bool playerFaceLeft)
	{
		player = GameObject.FindGameObjectWithTag("Player").transform;
		lastX = Mathf.RoundToInt(player.position.x);
		if (playerFaceLeft)
		{
			transform.position = new Vector3(player.position.x - offset.x, player.position.y + offset.y, transform.position.z);
		}
		else
		{
			transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);
		}
	}

	void Update()
	{
		if (player)
		{
			int currentX = Mathf.RoundToInt(player.position.x);
			if (currentX > lastX) faceLeft = false; else if (currentX < lastX) faceLeft = true;

			Vector3 target;
			if (faceLeft)
			{
				target = new Vector3(player.position.x, player.position.y, transform.position.z);
			}
			else
			{
				target = new Vector3(player.position.x, player.position.y, transform.position.z);
			}
			Vector2 currentPosition = Vector3.Lerp(transform.position, target, 1);
			transform.position = currentPosition;
		}
	}
}