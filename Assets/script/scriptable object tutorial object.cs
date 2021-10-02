using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptableobjecttutorialobject : ScriptableObject
{
    public scriptableobjecttutorial scriptable;

    private void Start()
    {
        var x = scriptable.speed;
    }
}
