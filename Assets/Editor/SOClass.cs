using UnityEngine;
using UnityEditor;

public class SOClass
{
	[MenuItem("Assets/Create/SOClass")]
	public static void CreateAsset ()
	{
		ScriptableObjectUtility.CreateAsset<GameSettings> ();
	}
}