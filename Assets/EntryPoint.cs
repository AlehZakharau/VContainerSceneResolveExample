using DefaultNamespace;
using VContainer;
using VContainer.Unity;

public class EntryPoint : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<SceneLoader>(Lifetime.Singleton);
        builder.Register<LifetimeScope>(Lifetime.Singleton);
        base.Configure(builder);
    }
}
