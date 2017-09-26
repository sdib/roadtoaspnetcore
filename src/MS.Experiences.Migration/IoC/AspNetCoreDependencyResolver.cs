namespace MS.Experiences.Migration
{
    public class AspNetCoreDependencyResolver : IDependencyResolver
    {
        public T Resolve<T>()
        {
            throw new System.NotImplementedException();
        }
    }
}