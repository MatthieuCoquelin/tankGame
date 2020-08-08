using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class TankGame : MonoBehaviour
{
    public Ennemy greenTank = new Ennemy();
    public Ennemy pinkTank = new Ennemy();
    public Ennemy whiteTank1 = new Ennemy();
    public Ennemy whiteTank2 = new Ennemy();
    public Player player = new Player();
    public Text canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (greenTank.gameObject.activeSelf == false && pinkTank.gameObject.activeSelf == false && whiteTank1.gameObject.activeSelf == false && whiteTank2.gameObject.activeSelf == false && player.gameObject.activeSelf == true)
        {
            canvas.color = Color.green;
            canvas.text = "You win";
        }
        if (player.gameObject.activeSelf == false && (greenTank.gameObject.activeSelf || pinkTank.gameObject.activeSelf || whiteTank1.gameObject.activeSelf || whiteTank2.gameObject.activeSelf))
        {
            canvas.color = Color.red;
            canvas.text = "You lose";
        }
          
        if (Input.GetKeyDown(KeyCode.Space))
            Application.LoadLevel(0);
    }
}
