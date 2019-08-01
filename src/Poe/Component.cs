using PoeHUD.Hud;

namespace PoeHUD.Poe
{
    public abstract class Component : StructuredRemoteMemoryObject<EnumOffsets.Component>
    {
        protected Entity Owner => GetObject<Entity>(Structure.owner);
    }
}