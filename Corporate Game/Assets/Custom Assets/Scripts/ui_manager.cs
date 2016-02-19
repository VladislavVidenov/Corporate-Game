﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ui_manager : MonoBehaviour {

	public GameObject spring_text;
	public GameObject fruit_text;
	public GameObject fishing_text;
	public GameObject duct_tape_text;
    public GameObject dirty_water_text;
    public GameObject sleeping_text;

	public GameObject water_bottle_ui;
	public GameObject apple_ui;
	public GameObject fishing_ui;

    public GameObject david;

    public GameObject spring_collider;
    public GameObject dirty_water_collider;
    public GameObject fruit_collider;
    public GameObject fish_collider;
    public GameObject oil_collider;
    public GameObject duct_tape_collider;
    public GameObject tent_collider;



    



	void OnTriggerEnter (Collider transition_collider)
    {
		
		if (transition_collider.name == "spring_transition")
			spring_text.GetComponent<Text> ().enabled = true;

		if (transition_collider.name == "apple_transition")
			fruit_text.GetComponent<Text>().enabled = true;
		
		if (transition_collider.name == "fishing_transition")
			fishing_text.GetComponent<Text>().enabled = true;

        if (transition_collider.name == "dirty_water_transition")
            dirty_water_text.GetComponent<Text>().enabled = true;

        if (transition_collider.name == "sleeping_transition")
            sleeping_text.GetComponent<Text>().enabled = true;

    }

	void OnTriggerStay (Collider transition_collider)
    {
		if (transition_collider.name == "spring_transition")
        {
			if (Input.GetKeyDown (KeyCode.E))
            {
				water_bottle_ui.GetComponent<Image> ().enabled = true;
                david.GetComponent<conversation_logic>().SetWater();
                david.GetComponent<conversation_logic>().ActionCount();
                spring_collider.GetComponent<BoxCollider>().enabled = false;
                spring_text.GetComponent<Text>().enabled = false;
                dirty_water_collider.GetComponent<BoxCollider>().enabled = false;
            }
		}

		if (transition_collider.name == "apple_transition")
        {
			if (Input.GetKeyDown (KeyCode.E))
            {
				apple_ui.GetComponent<Image> ().enabled = true;
                david.GetComponent<conversation_logic>().SetFruit();
                david.GetComponent<conversation_logic>().ActionCount();
                fruit_collider.GetComponent<BoxCollider>().enabled = false;
                fruit_text.GetComponent<Text>().enabled = false;
            }
		}

		if (transition_collider.name == "fishing_transition")
        {
			if (Input.GetKeyDown (KeyCode.E))
            {
				fishing_ui.GetComponent<Image> ().enabled = true;
                david.GetComponent<conversation_logic>().SetFish();
                david.GetComponent<conversation_logic>().ActionCount();
                fish_collider.GetComponent<BoxCollider>().enabled = false;
                fishing_text.GetComponent<Text>().enabled = false;
            }
		}

        if (transition_collider.name == "dirty_water_transition")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                water_bottle_ui.GetComponent<Image>().enabled = true;
                david.GetComponent<conversation_logic>().SetDirtyWater();
                david.GetComponent<conversation_logic>().ActionCount();
                dirty_water_collider.GetComponent<BoxCollider>().enabled = false;
                dirty_water_text.GetComponent<Text>().enabled = false;
                spring_collider.GetComponent<BoxCollider>().enabled = false;
            }
        }

        if (transition_collider.name == "sleeping_transition")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                david.GetComponent<conversation_logic>().ResetActions();
                tent_collider.GetComponent<BoxCollider>().enabled = false;
                sleeping_text.GetComponent<Text>().enabled = false;
            }
        }

    }

	void OnTriggerExit (Collider transition_collider)
    {
		
		if (transition_collider.name == "spring_transition")
			spring_text.GetComponent<Text>().enabled = false;

		if (transition_collider.name == "apple_transition")
			fruit_text.GetComponent<Text>().enabled = false;
		
		if (transition_collider.name == "fishing_transition")
			fishing_text.GetComponent<Text>().enabled = false;

        if (transition_collider.name == "dirty_water_transition")
            dirty_water_text.GetComponent<Text>().enabled = false;

        if (transition_collider.name == "sleeping_transition")
            sleeping_text.GetComponent<Text>().enabled = false;
    }
		
}
