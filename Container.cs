using StrongInject;

namespace stronginject_example;

[Register(typeof(DataSource))]
[Register(typeof(Foo))]
public partial class Container : IContainer<DataSource>, IContainer<Foo>
{
}
