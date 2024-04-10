using UnityEditor;
using UnityEngine;

public class BlendTreeParameterPrinter : MonoBehaviour
{
    public Animator animator;
    public string parameterName_X;
    public string parameterName_Y;
    public float speed; // for speed of player 
    public float lerp_Speed;
    
    void Update()
    {
        float targetValue_X = animator.GetFloat(parameterName_X);
        float targetValue_Y = animator.GetFloat(parameterName_Y);

        // get input value from vertical and horizontal axis and return value between -1 and 1
        float input_X = Input.GetAxis("Horizontal");   
        float input_Y = Input.GetAxis("Vertical");

        targetValue_X += input_X * speed; 
        targetValue_Y += input_Y * speed;

        if (Mathf.Abs(input_X) < 0.01f)
        {
            targetValue_X = 0;
        }
        else
        {
            float temp = targetValue_X;
            targetValue_X = temp;
        }

        if (Mathf.Abs(input_Y) < 0.01f)
        {
            targetValue_Y = 0;
        }
        else
        {
            float temp = targetValue_Y;
            targetValue_Y = temp;
        }

        
        float currentValue_X = animator.GetFloat(parameterName_X);
        float currentValue_Y = animator.GetFloat(parameterName_Y);

        float newValueX = Mathf.Lerp(currentValue_X, targetValue_X, Time.deltaTime * lerp_Speed);
        float newValueY = Mathf.Lerp(currentValue_Y, targetValue_Y, Time.deltaTime * lerp_Speed);
  
        animator.SetFloat(parameterName_Y, newValueY);
        animator.SetFloat(parameterName_X, newValueX);

        if( Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            animator.SetTrigger("Punch");
        }
        
         if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            animator.SetTrigger("Kick");
        }

         if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Jump");
        }
    }
}

//   if (Input.GetKey(KeyCode.W))
//   {
//       ValueY += 0.02f;
//       animator.SetFloat(parameterNameY, ValueY);
//    
//   }
//
//   else if (Input.GetKey(KeyCode.S))
//   {
//       ValueY -= 0.02f;
//       animator.SetFloat(parameterNameY, ValueY);
//   
//   }
//
//   else if (Input.GetKey(KeyCode.D))
//   {
//       ValueX += 0.02f;
//       animator.SetFloat(parameterNameX, ValueX); 
//   }
//
//   else if (Input.GetKey(KeyCode.A))
//   {
//       ValueX -= 0.02f;
//       animator.SetFloat(parameterNameX, ValueX);
//   }
//   
//
// if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
// {
//     ValueX += 0.02f;
//     ValueY += 0.02f;
//     animator.SetFloat(parameterNameX, ValueX);
//     animator.SetFloat(parameterNameY, ValueY);
//     Debug.Log("Diagonal WD");
// }
// else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
// {
//     ValueX -= 0.02f;
//     ValueY += 0.02f;
//     animator.SetFloat(parameterNameX, ValueX);
//     animator.SetFloat(parameterNameY, ValueY);
//     Debug.Log("Diagonal WA");
// }
// else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
// {
//     ValueX += 0.02f;
//     ValueY -= 0.02f;
//     animator.SetFloat(parameterNameX, ValueX);
//     animator.SetFloat(parameterNameY, ValueY);
//     Debug.Log("Diagonal SD");
// }
// else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
// {
//     ValueX -= 0.02f;
//     ValueY -= 0.02f;
//     animator.SetFloat(parameterNameX, ValueX);
//     animator.SetFloat(parameterNameY, ValueY);
//     Debug.Log("Diagonal SA");
// }
//
//
// if (Input.GetKeyUp(KeyCode.W))
//   {
//      Debug.Log("Call");
//      ValueX = Mathf.Lerp(ValueX, 0, Speed);
//      ValueY = Mathf.Lerp(ValueY, 0, Speed);
//      animator.SetFloat(parameterNameX, ValueX);
//      animator.SetFloat(parameterNameY, ValueY);
//
//  }
//  // else if (Input.GetKeyUp(KeyCode.S))
//  // {
//  //     ValueY = 0;
//  //     animator.SetFloat(parameterNameY, ValueY);
//  // }
//  // else if (Input.GetKeyUp(KeyCode.D))
//  // {
//  //     ValueX = 0;
//  //     animator.SetFloat(parameterNameX, ValueX);
//  // }
//  // else if (Input.GetKeyUp(KeyCode.A))
//  // {
//  //    ValueX = 0;
//  //  animator.SetFloat(parameterNameX, ValueX);
//  //
//




