using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabStartCommand : Command
{

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    public override void Execute()
    {
        Debug.Log("::BabStartCommand executed");
        /*GameObject go = new GameObject();
        go.name = "ExampleView";
        go.AddComponent<ExampleView>();
        go.transform.parent = contextView.transform;*/
    }
}
