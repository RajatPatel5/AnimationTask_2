using UnityEngine;

public class BlendTreeParameterPrinter : MonoBehaviour
{
    public Animator animator;
    public string parameterNameX;
    public string parameterNameY;

    void Update()
    {
        float ValueX = animator.GetFloat(parameterNameX);
        float ValueY = animator.GetFloat(parameterNameY);

        if (Input.GetKey(KeyCode.W))
        {
            ValueY += 0.02f;
            animator.SetFloat(parameterNameY, ValueY);
            Debug.Log(ValueY);
        }

        else if(Input.GetKey(KeyCode.S))
        {
            ValueY -= 0.02f;
            animator.SetFloat(parameterNameY, ValueY); 
            Debug.Log(ValueY);
        }

        else if(Input.GetKey(KeyCode.D)) 
        {
            ValueX += 0.02f;
            animator.SetFloat(parameterNameX, ValueX);
            Debug.Log(ValueX);  
        }

        else if( Input.GetKey(KeyCode.A)) 
        {
            ValueX -= 0.02f;
            animator.SetFloat (parameterNameX, ValueX);
            Debug.Log(ValueX);
        }

        if(Input.GetKeyUp(KeyCode.W)) 
        {
            ValueY  = 0;
            animator.SetFloat(parameterNameY, ValueY);
            Debug.Log(ValueY);
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            ValueY = 0;
            animator.SetFloat(parameterNameY, ValueY);
        }
        else if(Input.GetKeyUp (KeyCode.D))
        {
            ValueX = 0;
            animator.SetFloat(parameterNameX, ValueX);
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            ValueX = 0;
            animator.SetFloat(parameterNameX, ValueX);
        }
    }


}
