using UnityEngine;
using System.Collections;

public class ARMemo : MonoBehaviour {

	/// <summary>
	/// The animation playing.
	/// </summary>
	private Animation m_anim;
	
	/// <summary>
	/// Start this instance.
	/// </summary>
	private void Start()
	{
		m_anim = GetComponent<Animation>();
		m_anim.Play("ShowMemo", PlayMode.StopAll);
	}
	
	/// <summary>
	/// Plays an animation, then destroys.
	/// </summary>
	private void Hide()
	{
		m_anim.Play("HideMemo", PlayMode.StopAll);
	}
	
	/// <summary>
	/// Callback for the animation system.
	/// </summary>
	private void HideDone()
	{
		Destroy(gameObject);
	}

}
