namespace CallOfDuty.Interfaces
{
    public interface ILoadObjectFromPath<T>
    {
        T GetObject(string path);
    }
}