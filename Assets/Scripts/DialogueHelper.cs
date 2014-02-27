using UnityEngine;
using System.Collections;

public class DialogueHelper : MonoBehaviour {

	public Hashtable textHash = new Hashtable();
	public string testText1 = "This is a test of the emergency dialogue system";
	public string testOptiont1o1 = "OhGodOhGodOhGod";
	public string testOptiont1o2 = "Uh, okay?";
	public string testText2 = "Calm down, man";
	public string[] optionSet1;
	public string testText3 = "Yeah, no big deal. Just thought you should know";
	public string testOption2o1 = "OhGodOhGodOhGod";
	public string testOption2o2 = "Okay, I can do that";
	public string[] optionSet2;
	public string testOption3o1 = "Wait, is this a trap?";
	public string testOption3o2 = "Good to know";
	public string[] optionSet3;
	public string currentText;
	public string[] currentOptions;
	public float upCornery;
	public DoubleHealthScript health;
	public float screenwidth = 820;
	public float screenheight = 495;

	public Texture2D TextBoxBG;
	// Use this for initialization
	void Start () {
		optionSet1 = new string[] {testOptiont1o1, testOptiont1o2};
		string[][] one = new string[][] {new string[] {testText1}, optionSet1};
		textHash.Add("Start", one );
		currentText = testText1;

		optionSet2 = new string[] {testOption2o1, testOption2o2};
		optionSet3 = new string[] {testOption3o1, testOption3o2};
		currentOptions = optionSet1;

		upCornery = Screen.height - 100;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		GUI.DrawTexture(new Rect(0,upCornery,Screen.width,100), TextBoxBG);
		GUILayout.BeginArea(new Rect(10,upCornery+10, Screen.width-20, 80));
		GUILayout.BeginVertical();
		GUILayout.Label(currentText);
		if(GUILayout.Button(currentOptions[0])){
			currentText = testText2;
			currentOptions = optionSet2;
			health.hitHealth2(10);
		}
		if(GUILayout.Button (currentOptions[1])){
			currentText = testText3;
			currentOptions = optionSet3;
			health.hitHealth2(-10);
		}
		GUILayout.EndVertical();
		GUILayout.EndArea();
	}
}
