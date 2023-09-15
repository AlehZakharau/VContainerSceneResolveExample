using VContainer;
using VContainer.Unity;

namespace DefaultNamespace
{
    public class ChildScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<Messenger>();
            builder.Register<TestMessage>(Lifetime.Scoped);
            base.Configure(builder);
        }
    }
}