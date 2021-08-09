
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ShadowCaster2DTileMap))]
public class ShadowCastersGeneratorEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        ShadowCaster2DTileMap generator = (ShadowCaster2DTileMap)target;
        EditorGUILayout.Space();
        EditorGUILayout.Space();
        EditorGUILayout.Space();


        if (GUILayout.Button("Generate"))
        {

            generator.Generate();

        }

        EditorGUILayout.Space();
        if (GUILayout.Button("Destroy All Children"))
        {

            generator.DestroyAllChildren();

        }
    }

}