using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class WolfGameSettingLayer:CCLayer
    {
        public WolfGameSettingLayer()
        {
            CCSprite backGround = CCSprite.spriteWithFile("img/Wolf/Setting/img_background");
            backGround.anchorPoint = new CCPoint(0, 0);
            backGround.position = new CCPoint(0, 0);
            this.addChild(backGround, -1);

            CCMenuItemFont.FontName = "Wolf/WolfGameSettingMenuTitle";
            #region 音效
            CCMenuItemFont toggleSoundTitle = CCMenuItemFont.itemFromString("音效");
            toggleSoundTitle.Enabled = false;//不可用
            CCMenuItemToggle toggleSound = CCMenuItemToggle.itemWithTarget(this,
                this.toggleSoundClickHandle,
                CCMenuItemFont.itemFromString("开"),
                CCMenuItemFont.itemFromString("关"));
            #endregion
            #region 背景
            CCMenuItemFont toggleBgTitle = CCMenuItemFont.itemFromString("背景");
            toggleBgTitle.Enabled = false;//不可用
            CCMenuItemToggle toggleBg = CCMenuItemToggle.itemWithTarget(this,
                this.toggleBgClickHandle,
                CCMenuItemSprite.itemFromNormalSprite(CCSprite.spriteWithFile("img/bg_Sea1Mini"), CCSprite.spriteWithFile("img/bg_Sea1Mini")),
                CCMenuItemSprite.itemFromNormalSprite(CCSprite.spriteWithFile("img/bg_Sea2Mini"), CCSprite.spriteWithFile("img/bg_Sea2Mini")));
            #endregion
            CCMenu menu = CCMenu.menuWithItems(toggleSoundTitle, toggleSound, toggleBgTitle, toggleBg);
            menu.alignItemsVerticallyWithPadding(10);
            this.addChild(menu);
            #region 返回按钮
            CCLabelTTF label = CCLabelTTF.labelWithString("返回", "Wolf/WolfGameSettingMenuTitle", 20);
            CCMenuItemLabel btnBack = CCMenuItemLabel.itemWithLabel(label, this, new SEL_MenuHandler(BackClickHandle));
            label.Color = new ccColor3B(255, 0, 0);
            CCSize s = CCDirector.sharedDirector().getWinSize();
            btnBack.position = new CCPoint(0, -s.height/2+30);
            CCMenu menuBack = CCMenu.menuWithItem(btnBack);
            this.addChild(menuBack);
            #endregion
        }

        public void toggleSoundClickHandle(CCObject sender)
        {}

        public void toggleBgClickHandle(CCObject sender)
        {}

        public void BackClickHandle(CCObject sender)
        {
            //CCScene _wolfMenuScene = new WolfMenuScene();
            //CCDirector.sharedDirector().replaceScene(_wolfMenuScene);
            CCDirector.sharedDirector().popScene();
        }
    }
}
