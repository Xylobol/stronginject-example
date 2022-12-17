using StrongInject;

namespace stronginject_example;

[Register(typeof(DataSource))]
public partial class Container : IContainer<DataSource>
{
}
