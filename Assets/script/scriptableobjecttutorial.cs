using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//adiciona esse script para ser criado no menu

[CreateAssetMenu(fileName = "scriptabletest", menuName = "ScriptableObjects/test", order = 1)]

//file name= nome generico qnd se cria
// menuName = nome no menu - o "/" serve p criar um submenu, order = ordem 1

public class scriptableobjecttutorial : ScriptableObject
{
    // scriptable objects é tipo variavel em forma de codigo - pode ser usado por outros scripts
    // nao se usa funcoes nele

    public float speed;

}
