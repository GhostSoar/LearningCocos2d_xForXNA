using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class SpriteDefinedTouchLayer:CCLayer
    {
        TouchableSprite sprite1;
        public SpriteDefinedTouchLayer()
        {
            base.isTouchEnabled = true;//开启触屏事件
            CCDirector.sharedDirector().deviceOrientation = ccDeviceOrientation.kCCDeviceOrientationPortraitUpsideDown;//设置朝向，竖屏
            #region  Sprite跑动动画
            CCSize s = CCDirector.sharedDirector().getWinSize();
            // 创建批处理节点，读取plist文件
            CCSpriteBatchNode batch = CCSpriteBatchNode.batchNodeWithFile("plist/images/wolf_move");//批处理节点贴图
            addChild(batch, 0, 1);
            CCSpriteFrameCache.sharedSpriteFrameCache().addSpriteFramesWithFile("plist/wolf_move");//读取plsit文件
            //起始精灵
            sprite1 = new TouchableSprite();
            sprite1.initWithSpriteFrameName("wolf_move1.png");
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
            #endregion
        }
    }
}
