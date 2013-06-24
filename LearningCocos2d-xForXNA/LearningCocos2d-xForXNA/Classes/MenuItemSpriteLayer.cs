using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class MenuItemSpriteLayer:CCLayer
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public MenuItemSpriteLayer()
        {
            CCSprite _spriteNormal1 = CCSprite.spriteWithFile("img/btn-about-normal");//正常状态下，菜单图片
            CCSprite _spriteSelected1 = CCSprite.spriteWithFile("img/btn-about-selected");//选中状态下
            CCMenuItemSprite _menuItemSprite1 = CCMenuItemSprite.itemFromNormalSprite(_spriteNormal1, _spriteSelected1, this, menuItemSprite1Handle);

            string _imgMenuSprite="img/MenuSpritePlay";
            CCSprite _spriteNormal2 = CCSprite.spriteWithFile(_imgMenuSprite, new CCRect(0, 0, 125, 42));//正常状态下，菜单图片
            CCSprite _spriteSelected2 = CCSprite.spriteWithFile(_imgMenuSprite, new CCRect(0, 42, 125, 42));//选中状态下
            CCMenuItemSprite _menuItemSprite2 = CCMenuItemSprite.itemFromNormalSprite(_spriteNormal2, _spriteSelected2, this, menuItemSprite2Handle);

            CCMenu menu = CCMenu.menuWithItems(_menuItemSprite1, _menuItemSprite2);
            menu.alignItemsHorizontally();//水平排列
            this.addChild(menu);
        }

        public void menuItemSprite1Handle(CCObject sender)
        {}

        public void menuItemSprite2Handle(CCObject sender)
        {}
    }
}
