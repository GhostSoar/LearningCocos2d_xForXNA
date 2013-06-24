using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class MenuItemImageScene:CCScene
    {
        public MenuItemImageScene()
        {
            CCLayer _menuItemImageLayer = new MenuItemImageLayer();
            this.addChild(_menuItemImageLayer);
        }
    }
}
