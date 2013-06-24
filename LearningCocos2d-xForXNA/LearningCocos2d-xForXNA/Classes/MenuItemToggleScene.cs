using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class MenuItemToggleScene:CCScene
    {
        public MenuItemToggleScene()
        {
            CCLayer _menuItemToggleLayer = new MenuItemToggleLayer();
            this.addChild(_menuItemToggleLayer);
        }
    }
}
