using UnityEngine;
public class ElevadorBalanza : MonoBehaviour 
{ 
    public Rigidbody plataformaA; 
    public Rigidbody plataformaB; 
    public float limiteInferior = 0f; 
    public float limiteSuperior = 5f; 
    private float sumaInicial; 

    void Start() 
    {
        sumaInicial = plataformaA.position.y + plataformaB.position.y;
    }
          
    void FixedUpdate() 
    { 
        float nuevaYB = sumaInicial - plataformaA.position.y; 
         
        nuevaYB = Mathf.Clamp(nuevaYB, limiteInferior, limiteSuperior);
       
        Vector3 posicionB = plataformaB.position; 

        posicionB.y = nuevaYB; 

        plataformaB.MovePosition(posicionB); 

        float velocidadA = plataformaA.linearVelocity.y;
        
         plataformaB.linearVelocity = new Vector3( 0, -velocidadA, 0 );     
    } 
}