using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;



public class ClickableLetters : MonoBehaviour, IPointerClickHandler
{
    char _randomLetter;
    public void OnPointerClick(PointerEventData eventData)
    {

        Debug.Log($"Clicked on letter {_randomLetter}");
        if (_randomLetter == GameController.Instance.Letter)
        {
            GetComponent<TMP_Text>().color = Color.green;
            enabled = false;
            GameController.Instance.HandleCorrectLetterClick();
          

        }
    }

    //private void OnEnable()
    //{
    //    int a = Random.Range(0, 26);
    //    _randomLetter = (char)('a' + a);
      

    //    if (Random.Range(0, 100) > 50)
    //        GetComponent<TMP_Text>().text = _randomLetter.ToString();
    //    else
    //        GetComponent<TMP_Text>().text = _randomLetter.ToString().ToUpper();


    //}

    private void Update()
    {

    }
   internal void SetLetter(char letter)
    {
        enabled = true;
        GetComponent<TMP_Text>().color = Color.white;
        _randomLetter = letter;

        if (Random.Range(0, 100) > 50)
            GetComponent<TMP_Text>().text = _randomLetter.ToString();
        else
            GetComponent<TMP_Text>().text = _randomLetter.ToString().ToUpper();

    }


}
