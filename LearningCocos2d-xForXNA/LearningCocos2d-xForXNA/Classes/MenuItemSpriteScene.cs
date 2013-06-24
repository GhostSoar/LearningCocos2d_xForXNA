using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class MenuItemSpriteScene:CCScene
    {
        public MenuItemSpriteScene()
        {
            CCLayer _menuItemSpriteLayer = new MenuItemSpriteLayer();
            this.addChild(_menuItemSpriteLayer);
        }
    }
}
