using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RemainingCounterText : MonoBehaviour
{
    internal void SetRemaining(int remaining)
    {
        GetComponent<TMP_Text>().text = "x" + remaining;
    }
}
