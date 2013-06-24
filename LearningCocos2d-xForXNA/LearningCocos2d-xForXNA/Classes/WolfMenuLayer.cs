using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class WolfMenuLayer:CCLayer
    {
        public WolfMenuLayer()
        {
            //背景
            CCDirector.sharedDirector().deviceOrientation = ccDeviceOrientation.kCCDeviceOrientationPortraitUpsideDown;//设置朝向，竖屏
            CCSprite background = CCSprite.spriteWithFile("img/Wolf/Menu/img_background");
            //background.position = new CCPoint(CCDirector.sharedDirector().getWinSize().width / 2, CCDirector.sharedDirector().getWinSize().height / 2);
            background.anchorPoint = new CCPoint(0, 0);//设置锚点在图片右上角
            background.position = new CCPoint(0, 0);//图片位置
            this.addChild(background, -1);

            //菜单按钮
            string strBtnMenuItemSprite = "img/Wolf/Menu/btn_Menu";
            CCSprite btnStartNormal = CCSprite.spriteWithFile(strBtnMenuItemSprite, new CCRect(0, 42 * 0, 125, 42));
            CCSprite btnStartSelected = CCSprite.spriteWithFile(strBtnMenuItemSprite, new CCRect(0, 42 * 1, 125, 42));
            CCSprite btnSettingNormal = CCSprite.spriteWithFile(strBtnMenuItemSprite, new CCRect(0, 42 * 2, 125, 42));
            CCSprite btnSettingSelected = CCSprite.spriteWithFile(strBtnMenuItemSprite, new CCRect(0, 42 * 3, 125, 42));
            CCSprite btnRecordNormal = CCSprite.spriteWithFile(strBtnMenuItemSprite, new CCRect(0, 42 * 4, 125, 42));
            CCSprite btnRecordSelected = CCSprite.spriteWithFile(strBtnMenuItemSprite, new CCRect(0, 42 * 5, 125, 42));
            CCSprite btnHelpNormal = CCSprite.spriteWithFile(strBtnMenuItemSprite, new CCRect(0, 42 * 6, 125, 42));
            CCSprite btnHelpSelected = CCSprite.spriteWithFile(strBtnMenuItemSprite, new CCRect(0, 42 * 7, 125, 42));

            CCMenuItemSprite btnStart = CCMenuItemSprite.itemFromNormalSprite(btnStartNormal, btnStartSelected, this, this.btnStartClickHandle);
            CCMenuItemSprite btnSetting = CCMenuItemSprite.itemFromNormalSprite(btnSettingNormal, btnSettingSelected, this, this.btnSettingClickHandle);
            CCMenuItemSprite btnRecord = CCMenuItemSprite.itemFromNormalSprite(btnRecordNormal, btnRecordSelected, this, this.btnRecordClickHandle);
            CCMenuItemSprite btnHelp = CCMenuItemSprite.itemFromNormalSprite(btnHelpNormal, btnHelpSelected, this, this.btnHelpClickHandle);

            CCMenu menu = CCMenu.menuWithItems(btnStart, btnSetting, btnRecord, btnHelp);
            menu.alignItemsVertically();
            this.addChild(menu, 0);

        }

        public void btnStartClickHandle(CCObject sender)
        {}

        public void btnSettingClickHandle(CCObject sender)
        {
            //CCScene _wolfGameSettingScene = new WolfGameSettingScene();
            //CCDirector.sharedDirector().replaceScene(_wolfGameSettingScene);
            CCScene _wolfGameSettingScene = new WolfGameSettingScene();
            CCScene transScene = CCTransitionZoomFlipX.transitionWithDuration(12f, _wolfGameSettingScene, tOrientation.kOrientationLeftOver);//场景切换特效
            CCDirector.sharedDirector().pushScene(transScene);
        }

        public void btnRecordClickHandle(CCObject sender)
        { }

        public void btnHelpClickHandle(CCObject sender)
        { }
    }
}
