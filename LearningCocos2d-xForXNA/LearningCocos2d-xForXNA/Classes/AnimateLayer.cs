using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class AnimateLayer:CCLayer
    {
        public AnimateLayer()
        {
            CCDirector.sharedDirector().deviceOrientation = ccDeviceOrientation.kCCDeviceOrientationPortraitUpsideDown;//设置朝向，竖屏

            #region 单帧动画CCSpriteFrame
            //CCSize s = CCDirector.sharedDirector().getWinSize();
            //CCTexture2D texture = CCTextureCache.sharedTextureCache().addImage("img/Wolf/Sprite/aoao");//2D纹理
            //// 记录单帧信息
            //CCSpriteFrame frame0 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 0, 0, 74, 105));
            //CCSpriteFrame frame1 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 1, 0, 74, 105));
            //CCSpriteFrame frame2 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 2, 0, 74, 105));
            //CCSpriteFrame frame3 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 3, 0, 74, 105));
            //CCSpriteFrame frame4 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 4, 0, 74, 105));
            //CCSpriteFrame frame5 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 5, 0, 74, 105));
            //CCSpriteFrame frame6 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 6, 0, 74, 105));
            //CCSpriteFrame frame7 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 7, 0, 74, 105));
            //CCSpriteFrame frame8 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 8, 0, 74, 105));
            //CCSpriteFrame frame9 = CCSpriteFrame.frameWithTexture(texture, new CCRect(74 * 9, 0, 74, 105));
            //// 起始帧
            //CCSprite sprite = CCSprite.spriteWithSpriteFrame(frame0);
            //sprite.position = (new CCPoint(s.width / 2, s.height / 2));
            //addChild(sprite);
            ////生成逐帧数组
            //List<CCSpriteFrame> animFrames = new List<CCSpriteFrame>(10);
            //animFrames.Add(frame0);
            //animFrames.Add(frame1);
            //animFrames.Add(frame2);
            //animFrames.Add(frame3);
            //animFrames.Add(frame4);
            //animFrames.Add(frame5);
            //animFrames.Add(frame6);
            //animFrames.Add(frame7);
            //animFrames.Add(frame8);
            //animFrames.Add(frame9);
            ////动画Animate
            //CCAnimation animation = CCAnimation.animationWithFrames(animFrames, 0.2f);//Animation动画信息
            //CCAnimate animate = CCAnimate.actionWithAnimation(animation, false);
            //CCActionInterval seq = (CCActionInterval)(CCSequence.actions(animate));//动画间隔

            //sprite.runAction(CCRepeatForever.actionWithAction(seq));
            #endregion

            #region 动画帧集合
            //CCSize s = CCDirector.sharedDirector().getWinSize();
            //// 创建批处理节点，读取plist文件
            //CCSpriteBatchNode batch = CCSpriteBatchNode.batchNodeWithFile("plist/images/aoao");//批处理节点贴图
            //addChild(batch, 0, 1);
            //CCSpriteFrameCache.sharedSpriteFrameCache().addSpriteFramesWithFile("plist/aoao");//读取plsit文件
            ////起始精灵
            //CCSprite sprite1 = CCSprite.spriteWithSpriteFrameName("aoao1.png");
            //sprite1.position = (new CCPoint(s.width / 3, s.height / 2));
            //batch.addChild(sprite1);
            //// 创建逐帧数组
            //List<CCSpriteFrame> animFrames = new List<CCSpriteFrame>();
            //string str = "";
            //for (int i = 2; i < 11; i++)
            //{
            //    string temp = "";
            //    temp = i.ToString();
            //    str = string.Format("aoao{0}.png", temp);
            //    CCSpriteFrame frame = CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(str);
            //    animFrames.Add(frame);
            //}
            ////动画Animate
            //CCAnimation animation = CCAnimation.animationWithFrames(animFrames, 0.2f);//Animation动画信息
            //sprite1.runAction(CCRepeatForever.actionWithAction(CCAnimate.actionWithAnimation(animation, false)));//执行动画
            #endregion

            CCSize s = CCDirector.sharedDirector().getWinSize();
            // 创建批处理节点，读取plist文件
            CCSpriteBatchNode batch = CCSpriteBatchNode.batchNodeWithFile("plist/images/wolf_move");//批处理节点贴图
            addChild(batch, 0, 1);
            CCSpriteFrameCache.sharedSpriteFrameCache().addSpriteFramesWithFile("plist/wolf_move");//读取plsit文件
            //起始精灵
            CCSprite sprite1 = CCSprite.spriteWithSpriteFrameName("wolf_move1.png");
            sprite1.position = (new CCPoint(s.width / 3, s.height / 2));
            batch.addChild(sprite1);
            // 创建逐帧数组
            List<CCSpriteFrame> animFrames = new List<CCSpriteFrame>();
            string str = "";
            for (int i = 2; i < 8; i++)
            {
                string temp = "";
                temp = i.ToString();
                str = string.Format("wolf_move{0}.png", temp);
                CCSpriteFrame frame = CCSpriteFrameCache.sharedSpriteFrameCache().spriteFrameByName(str);
                animFrames.Add(frame);
            }
            //动画Animate
            CCAnimation animation = CCAnimation.animationWithFrames(animFrames, 0.2f);//Animation动画信息
            sprite1.runAction(CCRepeatForever.actionWithAction(CCAnimate.actionWithAnimation(animation, false)));//执行动画
        }
    }
}
