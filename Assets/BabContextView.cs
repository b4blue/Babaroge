using strange.extensions.context.impl;

public class BabContextView : ContextView
{

    void Awake()
    {
        context = new BabContext(this);
    }
}
