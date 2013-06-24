using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class MoveScene:CCScene
    {
        public MoveScene()
        {
            CCLayer _moveLayer = new MoveLayer();
            this.addChild(_moveLayer);
        }
    }
}
