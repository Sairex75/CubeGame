using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script : MonoBehaviour
{
    [SerializeField] public InputField numbersInput;
   float speed = 0.2f;

    public void NumbersFromInputField()
    {
        int number = int.Parse(numbersInput.text);
        transform.Translate(new Vector3(0.3f, 0.0f, 0.0f) * speed * number);
    }

   
   
    void Update()
    {
        NumbersFromInputField();
    }
}


