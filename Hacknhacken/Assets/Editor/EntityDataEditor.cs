using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EntityData))]
public class EntityDataEditor : Editor
{

    /// <summary>
    /// GameObject of the inspector
    /// </summary>
    private GameObject gameobject;
    public override void OnInspectorGUI()
    {
        EntityData entityData = (EntityData)target;
        gameobject = entityData.gameObject;

        if (gameobject.GetComponent<Camera>() != null)
        {
            entityData.entity.type = Entity.Type.Camera;
        }

        base.OnInspectorGUI();
    }

}
