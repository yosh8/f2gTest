using UnityEngine;
using System.Collections;

public class GUIMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI () {
        // ボタンを表示する
        GUI.Button( new Rect(20, 20, 100, 50), "Button" );
    }
}
