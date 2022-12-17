using StrongInject;

namespace stronginject_example;

[Register(typeof(DataSource))]
[Register(typeof(Foo))]
[Register(typeof(Bar))]
public partial class Container : IContainer<DataSource>, IContainer<Foo>, IContainer<Bar>
{
}
