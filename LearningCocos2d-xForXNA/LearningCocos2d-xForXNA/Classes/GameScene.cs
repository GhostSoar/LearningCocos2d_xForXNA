using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class GameScene:CCScene
    {
        public GameScene()
        {
            CCLayer gameLayer = new GameLayer();
            this.addChild(gameLayer);
        }
    }
}
