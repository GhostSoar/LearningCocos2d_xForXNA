using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class AnimateScene:CCScene
    {
        public AnimateScene()
        {
            CCLayer _animateLayer =new AnimateLayer();
            this.addChild(_animateLayer);
        }
    }
}
