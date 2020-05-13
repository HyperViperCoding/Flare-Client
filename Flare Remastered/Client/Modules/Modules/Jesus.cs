﻿using Flare_Remastered.Client.Categories;
using Flare_Remastered.SparkSDK;

namespace Flare_Remastered.Client.Modules.Modules
{
    public class Jesus : Module
    {
        public Jesus() : base("Jesus", CategoryHandler.registry.categories[1], (char)0x07, false)
        {
            RegisterSliderSetting("Boost", 0, 02, 20);
        }

        public override void onTick()
        {
            base.onTick();
            if(Minecraft.clientInstance.localPlayer.isInWater > 0)
            {
                Minecraft.clientInstance.localPlayer.velY = (float)sliderSettings[0].value / 10;
            }
        }
    }
}