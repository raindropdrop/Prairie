﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("Prairie/Interactions/Trigger Interaction")]
public class TriggerInteraction : PromptInteraction
{

    public GameObject[] triggeredObjects = new GameObject[0];

	protected override void PerformAction()
    {
        foreach (GameObject target in triggeredObjects)
        {
            target.InteractAll(this.rootInteractor);
        }
    }

	override public string defaultPrompt {
		get {
			return "Trigger Something";
		}
	}

}
