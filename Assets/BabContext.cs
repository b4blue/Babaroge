﻿using strange.extensions.command.api;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using UnityEngine;
using signals;

public class BabContext : MVCSContext
{
    public BabContext(MonoBehaviour view) : base(view)
    {
    }

    public BabContext(MonoBehaviour view, ContextStartupFlags flags) : base(view, flags)
    {
    }

    protected override void addCoreComponents()
    {
        base.addCoreComponents();
        injectionBinder.Unbind<ICommandBinder>();
        injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
    }

    override public IContext Start()
    {
        base.Start();
        StartSignal startSignal = injectionBinder.GetInstance<StartSignal>();
        startSignal.Dispatch();
        return this;
    }

    protected override void mapBindings()
    {
        //Injection binding.
        //Map a mock model and a mock service, both as Singletons
        // injectionBinder.Bind<IExampleModel>().To<ExampleModel>().ToSingleton();
        // injectionBinder.Bind<IExampleService>().To<ExampleService>().ToSingleton();

        //View/Mediator binding
        //This Binding instantiates a new ExampleMediator whenever as ExampleView
        //Fires its Awake method. The Mediator communicates to/from the View
        //and to/from the App. This keeps dependencies between the view and the app
        //separated.
        //  mediationBinder.Bind<ExampleView>().To<ExampleMediator>();

        //Event/Command binding
        //  commandBinder.Bind(ExampleEvent.REQUEST_WEB_SERVICE).To<CallWebServiceCommand>();
        //The START event is fired as soon as mappings are complete.
        //Note how we've bound it "Once". This means that the mapping goes away as soon as the command fires.
        commandBinder.Bind<StartSignal>().To<BabStartCommand>().Once();

    }
}
