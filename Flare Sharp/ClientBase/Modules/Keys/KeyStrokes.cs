using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.ClientBase.Keybinds;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Keys.Keys
{
    public class KeyStrokes : Keys
    {
        public KeyStrokes() : base("KeyStrokes", CategoryHandler.registry.categories[1], 'w', false)
        {
            KeybindHandler.clientKeyUpEvent += UpKeyHeld;
        }
        public void UpKeyHeld(object sender, clientKeyEvent e)
        {
            if (e.key == keybind)
            {
                enabled = false;
            }
        }
    }
}