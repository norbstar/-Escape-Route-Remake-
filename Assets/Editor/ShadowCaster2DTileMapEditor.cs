#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShadowCaster2DCreator))]
public class ShadowCaster2DTileMapEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
		EditorGUILayout.BeginHorizontal();
		
        if (GUILayout.Button("Create"))
		{
			var creator = (ShadowCaster2DCreator) target;
			creator.Create();
		}

		if (GUILayout.Button("Remove Shadows"))
		{
			var creator = (ShadowCaster2DCreator) target;
			creator.DestroyOldShadowCasters();
		}

		EditorGUILayout.EndHorizontal();
	}
}
#endif
