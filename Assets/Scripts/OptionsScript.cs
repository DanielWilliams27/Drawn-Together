using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public Dropdown up, down, left, right;

    public void ChangeUpKey()
    {
        if (up.captionText.text == down.captionText.text
            || up.captionText.text == left.captionText.text
            || up.captionText.text == right.captionText.text)
        {
            GlobalScript.up = KeyCode.W;
            GlobalScript.down = KeyCode.S;
            GlobalScript.left = KeyCode.A;
            GlobalScript.right = KeyCode.D;

            up.value = 0;
            down.value = 0;
            left.value = 0;
            right.value = 0;
        }
        else
        {
            switch (up.captionText.text)
            {
                case "A":
                    GlobalScript.up = KeyCode.A;
                    break;
                case "B":
                    GlobalScript.up = KeyCode.B;
                    break;
                case "C":
                    GlobalScript.up = KeyCode.C;
                    break;
                case "D":
                    GlobalScript.up = KeyCode.D;
                    break;
                case "E":
                    GlobalScript.up = KeyCode.E;
                    break;
                case "F":
                    GlobalScript.up = KeyCode.F;
                    break;
                case "G":
                    GlobalScript.up = KeyCode.G;
                    break;
                case "H":
                    GlobalScript.up = KeyCode.H;
                    break;
                case "I":
                    GlobalScript.up = KeyCode.I;
                    break;
                case "J":
                    GlobalScript.up = KeyCode.J;
                    break;
                case "K":
                    GlobalScript.up = KeyCode.K;
                    break;
                case "L":
                    GlobalScript.up = KeyCode.L;
                    break;
                case "M":
                    GlobalScript.up = KeyCode.M;
                    break;
                case "N":
                    GlobalScript.up = KeyCode.N;
                    break;
                case "O":
                    GlobalScript.up = KeyCode.O;
                    break;
                case "P":
                    GlobalScript.up = KeyCode.P;
                    break;
                case "Q":
                    GlobalScript.up = KeyCode.Q;
                    break;
                case "R":
                    GlobalScript.up = KeyCode.R;
                    break;
                case "S":
                    GlobalScript.up = KeyCode.S;
                    break;
                case "T":
                    GlobalScript.up = KeyCode.T;
                    break;
                case "U":
                    GlobalScript.up = KeyCode.U;
                    break;
                case "V":
                    GlobalScript.up = KeyCode.V;
                    break;
                case "W":
                    GlobalScript.up = KeyCode.W;
                    break;
                case "X":
                    GlobalScript.up = KeyCode.X;
                    break;
                case "Y":
                    GlobalScript.up = KeyCode.Y;
                    break;
                case "Z":
                    GlobalScript.up = KeyCode.Z;
                    break;
                case "Up":
                    GlobalScript.up = KeyCode.UpArrow;
                    break;
                case "Down":
                    GlobalScript.up = KeyCode.DownArrow;
                    break;
                case "Left":
                    GlobalScript.up = KeyCode.LeftArrow;
                    break;
                case "Right":
                    GlobalScript.up = KeyCode.RightArrow;
                    break;
                default:
                    GlobalScript.up = KeyCode.W;
                    break;
            }
        }
    }
}
