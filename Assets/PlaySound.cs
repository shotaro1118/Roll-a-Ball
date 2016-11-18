using UnityEngine;
using System.Collections;
 
public class PlaySound : MonoBehaviour {

	private CharacterController	charaCon;
	private AudioSource sound01;
	private AudioSource sound02;

	void Start () {
		//AudioSourceコンポーネントを取得し、変数に格納
		AudioSource[] audioSources = GetComponents<AudioSource>();
		sound01 = audioSources[0];
		sound02 = audioSources[1];
		charaCon = GetComponent< CharacterController > ();
	}

	void Update () {
		//指定のキーが押されたら音声ファイル再生
		if (transform.position.y > 1080.0f && transform.position.y < 1120.0f) {
			sound02.PlayOneShot(sound02.clip);
		}		
	}
}