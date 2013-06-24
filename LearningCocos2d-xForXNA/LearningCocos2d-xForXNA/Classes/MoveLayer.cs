using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class MoveLayer:CCLayer
    {
        CCSprite sprite1;
        public MoveLayer()
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
            sprite1 = CCSprite.spriteWithSpriteFrameName("wolf_move1.png");
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

            //直线匀速
            //sprite1.runAction(CCMoveTo.actionWithDuration(5.0f, new CCPoint(0, 0)));//移动到坐标（0，0）位置


            #region CCEaseInOut
            //CCActionInterval move = CCMoveBy.actionWithDuration(3, new CCPoint(280, 0));//CCMoveBy是相当位移动作
            //CCActionInterval move_ease_inout = CCEaseInOut.actionWithAction(move);//ease缓冲
            //sprite1.runAction(move_ease_inout);
            #endregion
        }

        /// <summary>
        /// 触屏事件Ended处理函数
        /// </summary>
        /// <param name="touches"></param>
        /// <param name="event_"></param>
        public override void ccTouchesEnded(List<CCTouch> touches, CCEvent event_)
        {
            object sender = touches.First();//获取第一个触点
            CCTouch touch = (CCTouch)(sender);

            CCPoint touchLocation = touch.locationInView(touch.view());//获取触屏的坐标位置
            CCPoint convertedLocation = CCDirector.sharedDirector().convertToGL(touchLocation);//转换坐标位置

            //执行运动
            CCActionInterval move = CCMoveTo.actionWithDuration(3, convertedLocation);
            CCActionInterval move_ease_inout = CCEaseInOut.actionWithAction(move);//ease缓冲
            sprite1.runAction(move_ease_inout);
        }
    }
}
