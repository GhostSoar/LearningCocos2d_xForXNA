using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class SpriteDefinedTouchScene:CCScene
    {
        public SpriteDefinedTouchScene()
        {
            CCLayer spriteDefinedTouchLayer = new SpriteDefinedTouchLayer();
            this.addChild(spriteDefinedTouchLayer);
        }
    }
}
