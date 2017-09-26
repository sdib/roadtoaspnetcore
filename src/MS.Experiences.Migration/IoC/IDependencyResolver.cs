namespace MS.Experiences.Migration
{
    public interface IDependencyResolver
    {
        T Resolve<T>();
    }
}
