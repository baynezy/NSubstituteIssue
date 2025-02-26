namespace Target;

public interface IExample<out TEntity>
{
    internal TEntity Create();
}