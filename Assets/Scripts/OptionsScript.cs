using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    public Text upText, downText, leftText, rightText;
    public Button up, down, left, right;
    Event key;

    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject == up)
        {
            key = Event.current;

            if (key.isKey)
            {
                ChangeUpKey(key.keyCode);
            }
        }

        if (EventSystem.current.currentSelectedGameObject == down)
        {
            key = Event.current;

            if (key.isKey)
            {
                ChangeDownKey(key.keyCode);
            }
        }

        if (EventSystem.current.currentSelectedGameObject == left)
        {
            key = Event.current;

            if (key.isKey)
            {
                ChangeLeftKey(key.keyCode);
            }
        }

        if (EventSystem.current.currentSelectedGameObject == right)
        {
            key = Event.current;

            if (key.isKey)
            {
                ChangeRightKey(key.keyCode);
            }
        }
    }

    public void ChangeUpKey(KeyCode input)
    {
        switch (input)
        {
            case KeyCode.A:
                GlobalScript.up = KeyCode.A;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.B:
                GlobalScript.up = KeyCode.B;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.C:
                GlobalScript.up = KeyCode.C;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.D:
                GlobalScript.up = KeyCode.D;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.E:
                GlobalScript.up = KeyCode.E;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.F:
                GlobalScript.up = KeyCode.F;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.G:
                GlobalScript.up = KeyCode.G;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.H:
                GlobalScript.up = KeyCode.H;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.I:
                GlobalScript.up = KeyCode.I;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.J:
                GlobalScript.up = KeyCode.J;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.K:
                GlobalScript.up = KeyCode.K;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.L:
                GlobalScript.up = KeyCode.L;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.M:
                GlobalScript.up = KeyCode.M;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.N:
                GlobalScript.up = KeyCode.N;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.O:
                GlobalScript.up = KeyCode.O;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.P:
                GlobalScript.up = KeyCode.P;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.Q:
                GlobalScript.up = KeyCode.Q;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.R:
                GlobalScript.up = KeyCode.R;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.S:
                GlobalScript.up = KeyCode.S;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.T:
                GlobalScript.up = KeyCode.T;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.U:
                GlobalScript.up = KeyCode.U;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.V:
                GlobalScript.up = KeyCode.V;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.W:
                GlobalScript.up = KeyCode.W;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.X:
                GlobalScript.up = KeyCode.X;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.Y:
                GlobalScript.up = KeyCode.Y;
                upText.text = GlobalScript.up.ToString();
                break;
            case KeyCode.Z:
                GlobalScript.up = KeyCode.Z;
                upText.text = GlobalScript.up.ToString();
                break;
            default:
                break;
        }
    }

    public void ChangeDownKey(KeyCode input)
    {
        switch (input)
        {
            case KeyCode.A:
                GlobalScript.down = KeyCode.A;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.B:
                GlobalScript.down = KeyCode.B;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.C:
                GlobalScript.down = KeyCode.C;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.D:
                GlobalScript.down = KeyCode.D;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.E:
                GlobalScript.down = KeyCode.E;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.F:
                GlobalScript.down = KeyCode.F;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.G:
                GlobalScript.down = KeyCode.G;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.H:
                GlobalScript.down = KeyCode.H;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.I:
                GlobalScript.down = KeyCode.I;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.J:
                GlobalScript.down = KeyCode.J;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.K:
                GlobalScript.down = KeyCode.K;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.L:
                GlobalScript.down = KeyCode.L;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.M:
                GlobalScript.down = KeyCode.M;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.N:
                GlobalScript.down = KeyCode.N;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.O:
                GlobalScript.down = KeyCode.O;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.P:
                GlobalScript.down = KeyCode.P;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.Q:
                GlobalScript.down = KeyCode.Q;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.R:
                GlobalScript.down = KeyCode.R;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.S:
                GlobalScript.down = KeyCode.S;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.T:
                GlobalScript.down = KeyCode.T;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.U:
                GlobalScript.down = KeyCode.U;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.V:
                GlobalScript.down = KeyCode.V;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.W:
                GlobalScript.down = KeyCode.W;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.X:
                GlobalScript.down = KeyCode.X;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.Y:
                GlobalScript.down = KeyCode.Y;
                downText.text = GlobalScript.down.ToString();
                break;
            case KeyCode.Z:
                GlobalScript.down = KeyCode.Z;
                downText.text = GlobalScript.down.ToString();
                break;
            default:
                break;
        }
    }

    public void ChangeLeftKey(KeyCode input)
    {
        switch (input)
        {
            case KeyCode.A:
                GlobalScript.left = KeyCode.A;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.B:
                GlobalScript.left = KeyCode.B;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.C:
                GlobalScript.left = KeyCode.C;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.D:
                GlobalScript.left = KeyCode.D;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.E:
                GlobalScript.left = KeyCode.E;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.F:
                GlobalScript.left = KeyCode.F;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.G:
                GlobalScript.left = KeyCode.G;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.H:
                GlobalScript.left = KeyCode.H;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.I:
                GlobalScript.left = KeyCode.I;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.J:
                GlobalScript.left = KeyCode.J;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.K:
                GlobalScript.left = KeyCode.K;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.L:
                GlobalScript.left = KeyCode.L;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.M:
                GlobalScript.left = KeyCode.M;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.N:
                GlobalScript.left = KeyCode.N;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.O:
                GlobalScript.left = KeyCode.O;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.P:
                GlobalScript.left = KeyCode.P;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.Q:
                GlobalScript.left = KeyCode.Q;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.R:
                GlobalScript.left = KeyCode.R;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.S:
                GlobalScript.left = KeyCode.S;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.T:
                GlobalScript.left = KeyCode.T;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.U:
                GlobalScript.left = KeyCode.U;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.V:
                GlobalScript.left = KeyCode.V;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.W:
                GlobalScript.left = KeyCode.W;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.X:
                GlobalScript.left = KeyCode.X;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.Y:
                GlobalScript.left = KeyCode.Y;
                leftText.text = GlobalScript.left.ToString();
                break;
            case KeyCode.Z:
                GlobalScript.left = KeyCode.Z;
                leftText.text = GlobalScript.left.ToString();
                break;
            default:
                break;
        }
    }

    public void ChangeRightKey(KeyCode input)
    {
        switch (input)
        {
            case KeyCode.A:
                GlobalScript.right = KeyCode.A;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.B:
                GlobalScript.right = KeyCode.B;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.C:
                GlobalScript.right = KeyCode.C;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.D:
                GlobalScript.right = KeyCode.D;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.E:
                GlobalScript.right = KeyCode.E;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.F:
                GlobalScript.right = KeyCode.F;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.G:
                GlobalScript.right = KeyCode.G;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.H:
                GlobalScript.right = KeyCode.H;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.I:
                GlobalScript.right = KeyCode.I;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.J:
                GlobalScript.right = KeyCode.J;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.K:
                GlobalScript.right = KeyCode.K;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.L:
                GlobalScript.right = KeyCode.L;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.M:
                GlobalScript.right = KeyCode.M;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.N:
                GlobalScript.right = KeyCode.N;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.O:
                GlobalScript.right = KeyCode.O;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.P:
                GlobalScript.right = KeyCode.P;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.Q:
                GlobalScript.right = KeyCode.Q;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.R:
                GlobalScript.right = KeyCode.R;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.S:
                GlobalScript.right = KeyCode.S;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.T:
                GlobalScript.right = KeyCode.T;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.U:
                GlobalScript.right = KeyCode.U;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.V:
                GlobalScript.right = KeyCode.V;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.W:
                GlobalScript.right = KeyCode.W;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.X:
                GlobalScript.right = KeyCode.X;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.Y:
                GlobalScript.right = KeyCode.Y;
                rightText.text = GlobalScript.right.ToString();
                break;
            case KeyCode.Z:
                GlobalScript.right = KeyCode.Z;
                rightText.text = GlobalScript.right.ToString();
                break;
            default:
                rightText.text = "No";
                break;
        }
    }
}
