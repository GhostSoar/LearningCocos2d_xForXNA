using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class MenuItemImageLayer:CCLayer
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public MenuItemImageLayer()
        {
            CCMenuItemImage _menuItemImage1 = CCMenuItemImage.itemFromNormalImage("img/btn-about-normal", "img/btn-about-selected", this, MenuItemImage1Handle);
            CCMenu menu = CCMenu.menuWithItems(_menuItemImage1);
            this.addChild(menu);
        }

        public void MenuItemImage1Handle(CCObject sender)
        { }
    }
}
