using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNumber : MonoBehaviour
{
        public InputField ipVarA;
       public InputField ipVarB;
       public Text result;
       
       float varA;
       float varB; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        varA = 5;
        varB = 4;
       Debug.Log("in Start: " + SubtractNumbers(varA, varB));
       Debug.Log("in Start: " + SubtractNumbers(4, 7));
       Debug.Log(10 - SubtractNumbers(varA, varB));
       Debug.Log(100 - SubtractNumbers(4, 7));
    }
    public void SetResult()
    {
        float a = float.Parse(ipVarA.text);
        float b = float.Parse(ipVarB.text);
        Debug.Log(a + b);
        //result.text = SubtractNumbers(a,b);
    }
    
    public void TestMethodVOID(){
        Debug.Log("Test");
    }
    
     public float MultNumbers(float variableA, float variableB)
    {
        float result = variableA * variableB;
        //Debug.Log("Test sub " + result.ToString() );
        return result;
    }
    
    public float SubtractNumbers(float variableA, float variableB)
    {
        float result = variableA - variableB;
        //Debug.Log("Test sub " + result.ToString() );
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
