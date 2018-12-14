using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour {

    public opcionesDeMovimiento Control;
    private float MovimientoHorizontal;
    public float Velocidad = 40f;
    private bool salto = false;
    private bool agachar = false;
    public GameObject bullet;
    private bool direccion;

	public Rigidbody2D rb;
	public Animator anim;
   

	// Update is called once per frame
	void Update () {
        MovimientoHorizontal = Input.GetAxisRaw("Horizontal") * Velocidad;
            if (MovimientoHorizontal > 0)
        {
            direccion = true;
        }
        if (MovimientoHorizontal < 0)
        {
            direccion = false;
        }



	anim.SetFloat("SPEED", Mathf.Abs(rb.velocity.x));


        if (Input.GetKeyDown(KeyCode.Space))
{
	GameObject b = Instantiate(bullet);
	b.transform.position = transform.position;
        if (!direccion) {
                b.GetComponent<Bullet>().speed *= -1;
            }


}



        if (Input.GetKeyDown(KeyCode.W))
        {
            salto = true;
        

        }
         if (Input.GetKey(KeyCode.S))  

        {
            agachar = true;


       }
         else
        {
            agachar = false;
        }

	}

       public void OnCrouching (bool isCrouching)
{
       anim.SetBool("IsCrouching", isCrouching);

}
    
    private void FixedUpdate()
    {
        Control.Move(MovimientoHorizontal * Time.fixedDeltaTime, agachar, salto);
        salto = false; 

         
    }


private void OnTriggerEnter2D (Collider2D Col){
	if(Col.gameObject.tag.Equals("fail")){
transform.position = new Vector2(-5.828994f, 0.6f);
}


}


}
