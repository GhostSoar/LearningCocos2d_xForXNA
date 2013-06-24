using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class WolfGameSettingScene:CCScene
    {
        public WolfGameSettingScene()
        {
            CCLayer _wolfGameSettingLayer = new WolfGameSettingLayer();
            this.addChild(_wolfGameSettingLayer);
        }
    }
}
