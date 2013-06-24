using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class WolfMenuScene:CCScene
    {
        public WolfMenuScene()
        {
            CCLayer _wolfMenuLayer = new WolfMenuLayer();
            this.addChild(_wolfMenuLayer);
        }
    }
}
