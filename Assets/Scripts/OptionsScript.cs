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

        up.RefreshShownValue();
    }

    public void ChangeDownKey()
    {
        if (down.captionText.text == up.captionText.text
            || down.captionText.text == left.captionText.text
            || down.captionText.text == right.captionText.text)
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
            switch (down.captionText.text)
            {
                case "A":
                    GlobalScript.down = KeyCode.A;
                    break;
                case "B":
                    GlobalScript.down = KeyCode.B;
                    break;
                case "C":
                    GlobalScript.down = KeyCode.C;
                    break;
                case "D":
                    GlobalScript.down = KeyCode.D;
                    break;
                case "E":
                    GlobalScript.down = KeyCode.E;
                    break;
                case "F":
                    GlobalScript.down = KeyCode.F;
                    break;
                case "G":
                    GlobalScript.down = KeyCode.G;
                    break;
                case "H":
                    GlobalScript.down = KeyCode.H;
                    break;
                case "I":
                    GlobalScript.down = KeyCode.I;
                    break;
                case "J":
                    GlobalScript.down = KeyCode.J;
                    break;
                case "K":
                    GlobalScript.down = KeyCode.K;
                    break;
                case "L":
                    GlobalScript.down = KeyCode.L;
                    break;
                case "M":
                    GlobalScript.down = KeyCode.M;
                    break;
                case "N":
                    GlobalScript.down = KeyCode.N;
                    break;
                case "O":
                    GlobalScript.down = KeyCode.O;
                    break;
                case "P":
                    GlobalScript.down = KeyCode.P;
                    break;
                case "Q":
                    GlobalScript.down = KeyCode.Q;
                    break;
                case "R":
                    GlobalScript.down = KeyCode.R;
                    break;
                case "S":
                    GlobalScript.down = KeyCode.S;
                    break;
                case "T":
                    GlobalScript.down = KeyCode.T;
                    break;
                case "U":
                    GlobalScript.down = KeyCode.U;
                    break;
                case "V":
                    GlobalScript.down = KeyCode.V;
                    break;
                case "W":
                    GlobalScript.down = KeyCode.W;
                    break;
                case "X":
                    GlobalScript.down = KeyCode.X;
                    break;
                case "Y":
                    GlobalScript.down = KeyCode.Y;
                    break;
                case "Z":
                    GlobalScript.down = KeyCode.Z;
                    break;
                case "Up":
                    GlobalScript.down = KeyCode.UpArrow;
                    break;
                case "Down":
                    GlobalScript.down = KeyCode.DownArrow;
                    break;
                case "Left":
                    GlobalScript.down = KeyCode.LeftArrow;
                    break;
                case "Right":
                    GlobalScript.down = KeyCode.RightArrow;
                    break;
                default:
                    GlobalScript.down = KeyCode.S;
                    break;
            }
        }

        down.RefreshShownValue();
    }

    public void ChangeLeftKey()
    {
        if (left.captionText.text == up.captionText.text
            || left.captionText.text == down.captionText.text
            || left.captionText.text == right.captionText.text)
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
            switch (left.captionText.text)
            {
                case "A":
                    GlobalScript.left = KeyCode.A;
                    break;
                case "B":
                    GlobalScript.left = KeyCode.B;
                    break;
                case "C":
                    GlobalScript.left = KeyCode.C;
                    break;
                case "D":
                    GlobalScript.left = KeyCode.D;
                    break;
                case "E":
                    GlobalScript.left = KeyCode.E;
                    break;
                case "F":
                    GlobalScript.left = KeyCode.F;
                    break;
                case "G":
                    GlobalScript.left = KeyCode.G;
                    break;
                case "H":
                    GlobalScript.left = KeyCode.H;
                    break;
                case "I":
                    GlobalScript.left = KeyCode.I;
                    break;
                case "J":
                    GlobalScript.left = KeyCode.J;
                    break;
                case "K":
                    GlobalScript.left = KeyCode.K;
                    break;
                case "L":
                    GlobalScript.left = KeyCode.L;
                    break;
                case "M":
                    GlobalScript.left = KeyCode.M;
                    break;
                case "N":
                    GlobalScript.left = KeyCode.N;
                    break;
                case "O":
                    GlobalScript.left = KeyCode.O;
                    break;
                case "P":
                    GlobalScript.left = KeyCode.P;
                    break;
                case "Q":
                    GlobalScript.left = KeyCode.Q;
                    break;
                case "R":
                    GlobalScript.left = KeyCode.R;
                    break;
                case "S":
                    GlobalScript.left = KeyCode.S;
                    break;
                case "T":
                    GlobalScript.left = KeyCode.T;
                    break;
                case "U":
                    GlobalScript.left = KeyCode.U;
                    break;
                case "V":
                    GlobalScript.left = KeyCode.V;
                    break;
                case "W":
                    GlobalScript.left = KeyCode.W;
                    break;
                case "X":
                    GlobalScript.left = KeyCode.X;
                    break;
                case "Y":
                    GlobalScript.left = KeyCode.Y;
                    break;
                case "Z":
                    GlobalScript.left = KeyCode.Z;
                    break;
                case "Up":
                    GlobalScript.left = KeyCode.UpArrow;
                    break;
                case "Down":
                    GlobalScript.left = KeyCode.DownArrow;
                    break;
                case "Left":
                    GlobalScript.left = KeyCode.LeftArrow;
                    break;
                case "Right":
                    GlobalScript.left = KeyCode.RightArrow;
                    break;
                default:
                    GlobalScript.left = KeyCode.A;
                    break;
            }
        }

        left.RefreshShownValue();
    }

    public void ChangeRightKey()
    {
        if (right.captionText.text == up.captionText.text
            || right.captionText.text == down.captionText.text
            || right.captionText.text == left.captionText.text)
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
            switch (right.captionText.text)
            {
                case "A":
                    GlobalScript.right = KeyCode.A;
                    break;
                case "B":
                    GlobalScript.right = KeyCode.B;
                    break;
                case "C":
                    GlobalScript.right = KeyCode.C;
                    break;
                case "D":
                    GlobalScript.right = KeyCode.D;
                    break;
                case "E":
                    GlobalScript.right = KeyCode.E;
                    break;
                case "F":
                    GlobalScript.right = KeyCode.F;
                    break;
                case "G":
                    GlobalScript.right = KeyCode.G;
                    break;
                case "H":
                    GlobalScript.right = KeyCode.H;
                    break;
                case "I":
                    GlobalScript.right = KeyCode.I;
                    break;
                case "J":
                    GlobalScript.right = KeyCode.J;
                    break;
                case "K":
                    GlobalScript.right = KeyCode.K;
                    break;
                case "L":
                    GlobalScript.right = KeyCode.L;
                    break;
                case "M":
                    GlobalScript.right = KeyCode.M;
                    break;
                case "N":
                    GlobalScript.right = KeyCode.N;
                    break;
                case "O":
                    GlobalScript.right = KeyCode.O;
                    break;
                case "P":
                    GlobalScript.right = KeyCode.P;
                    break;
                case "Q":
                    GlobalScript.right = KeyCode.Q;
                    break;
                case "R":
                    GlobalScript.right = KeyCode.R;
                    break;
                case "S":
                    GlobalScript.right = KeyCode.S;
                    break;
                case "T":
                    GlobalScript.right = KeyCode.T;
                    break;
                case "U":
                    GlobalScript.right = KeyCode.U;
                    break;
                case "V":
                    GlobalScript.right = KeyCode.V;
                    break;
                case "W":
                    GlobalScript.right = KeyCode.W;
                    break;
                case "X":
                    GlobalScript.right = KeyCode.X;
                    break;
                case "Y":
                    GlobalScript.right = KeyCode.Y;
                    break;
                case "Z":
                    GlobalScript.right = KeyCode.Z;
                    break;
                case "Up":
                    GlobalScript.right = KeyCode.UpArrow;
                    break;
                case "Down":
                    GlobalScript.right = KeyCode.DownArrow;
                    break;
                case "Left":
                    GlobalScript.right = KeyCode.LeftArrow;
                    break;
                case "Right":
                    GlobalScript.right = KeyCode.RightArrow;
                    break;
                default:
                    GlobalScript.right = KeyCode.D;
                    break;
            }
        }

        right.RefreshShownValue();
    }
}
