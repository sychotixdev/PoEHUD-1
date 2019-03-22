using PoeHUD.Poe;

namespace PoeHUD.Models.Interfaces
{
    public interface IEntity
    {
        string Path { get; }
        long Id { get; }
        bool IsValid { get; }
        bool IsHostile { get; }
        long Address { get; }

        bool HasComponent<T>() where T : RemoteMemoryObject, new();

        T GetComponent<T>() where T : RemoteMemoryObject, new();
    }
}