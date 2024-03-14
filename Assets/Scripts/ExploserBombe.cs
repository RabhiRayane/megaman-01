﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploserBombe : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
	}

    // Détecte les colisions de l'objert Bombe
    // Active l'animation de l'objet lorsque le terrain est touché
    // Détruit l'Objet après un delais (à la fin de son animation) 
    void OnCollisionEnter2D(Collision2D infoCollision)
    {
        // Si le terrain est touché alors active l'animation de l'objet et détruit le
        if (infoCollision.gameObject.name == "gazon") 
        {
            GetComponent<Animator>().enabled = true;
            Destroy(gameObject, 0.2f);
        }
    }
}
