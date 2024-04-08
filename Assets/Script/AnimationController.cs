using UnityEngine;

public class BlendTreeParameterPrinter : MonoBehaviour
{
    public Animator animator;
    public string parameterNameX;
    public string parameterNameY;
    public float Speed = 0.6f;
    public float lerpSpeed = 7f;

    void Update()
    {
        float targetValueX = animator.GetFloat(parameterNameX);
        float targetValueY = animator.GetFloat(parameterNameY);

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        targetValueX += inputX * 1f;
        targetValueY += inputY * 1f;

        targetValueX = Mathf.Abs(inputX) < 0.01f ? 0 : targetValueX;
        targetValueY = Mathf.Abs(inputY) < 0.01f ? 0 : targetValueY;

        float currentValueX = animator.GetFloat(parameterNameX);
        float currentValueY = animator.GetFloat(parameterNameY);

        float newValueX = Mathf.Lerp(currentValueX, targetValueX, Time.deltaTime * lerpSpeed);
        float newValueY = Mathf.Lerp(currentValueY, targetValueY, Time.deltaTime * lerpSpeed);

        animator.SetFloat(parameterNameY, newValueY);
        animator.SetFloat(parameterNameX, newValueX);



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


    }
}

