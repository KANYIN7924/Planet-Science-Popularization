using UnityEngine;
using System.Collections;

/// <summary>
/// Spin the object at a specified speed
/// </summary>
public class SpinFree : MonoBehaviour {
	[Tooltip("Spin:是或不是")]
	public bool spin;
	[Tooltip("旋转父对象，而不是脚本附加的对象")]
	public bool spinParent;//旋转
	public float speed = 10f;

	[HideInInspector]
	public bool clockwise = true;//顺时针方向
	[HideInInspector]
	public float direction = 1f;//旋转
	[HideInInspector]
	public float directionChangeSpeed = 2f;//方向改变的速度

	// Update is called once per frame
	void Update() {
		if (direction < 1f) {
			direction += Time.deltaTime / (directionChangeSpeed / 2);
		}

		if (spin) {
			if (clockwise) {
				if (spinParent)
					transform.parent.transform.Rotate(Vector3.forward, (speed * direction) * Time.deltaTime);
				else
					transform.Rotate(Vector3.forward, (speed * direction) * Time.deltaTime);
			} else {
				if (spinParent)
					transform.parent.transform.Rotate(-Vector3.forward, (speed * direction) * Time.deltaTime);
				else
					transform.Rotate(-Vector3.forward, (speed * direction) * Time.deltaTime);
			}
		}
	}
}