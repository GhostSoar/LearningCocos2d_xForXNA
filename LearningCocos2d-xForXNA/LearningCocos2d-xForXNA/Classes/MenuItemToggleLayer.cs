using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;
using cocos2d.menu_nodes;

namespace LearningCocos2d_xForXNA.Classes
{
    class MenuItemToggleLayer:CCLayer
    {
        public MenuItemToggleLayer()
        {
            //文字Toggle
            CCMenuItemToggle _menuItemToggle1 = CCMenuItemToggle.itemWithTarget(this, 
                this.MenuItemToggle1Handle, 
                CCMenuItemFont.itemFromString("On"), 
                CCMenuItemFont.itemFromString("Off"));

            CCMenuItemFont.FontName="Yahei";//中文显示
            CCMenuItemToggle _menuItemToggle2 = CCMenuItemToggle.itemWithTarget(this,
                this.MenuItemToggle2Handle,
                CCMenuItemFont.itemFromString("开"),
                CCMenuItemFont.itemFromString("关"));

            //图片Toggle
            CCMenuItemToggle _menuItemToggle3 = CCMenuItemToggle.itemWithTarget(this,
                this.MenuItemToggle3Handle,
                CCMenuItemSprite.itemFromNormalSprite(CCSprite.spriteWithFile("img/bg_Sea1Mini"), CCSprite.spriteWithFile("img/bg_Sea1Mini")),
                CCMenuItemSprite.itemFromNormalSprite(CCSprite.spriteWithFile("img/bg_Sea2Mini"), CCSprite.spriteWithFile("img/bg_Sea2Mini")));

            CCMenu menu = CCMenu.menuWithItems(_menuItemToggle1, _menuItemToggle2, _menuItemToggle3);
            menu.alignItemsVertically();
            this.addChild(menu);

        }

        public void MenuItemToggle1Handle(CCObject sender)
        { }

        public void MenuItemToggle2Handle(CCObject sender)
        { }

        public void MenuItemToggle3Handle(CCObject sender)
        { }
    }
}
