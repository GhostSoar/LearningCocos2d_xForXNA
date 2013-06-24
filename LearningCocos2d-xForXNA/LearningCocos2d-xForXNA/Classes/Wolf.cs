using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class Wolf:CCSprite, ICCTargetedTouchDelegate
    {
        /// <summary>
        /// 创建检测碰撞Rect
        /// </summary>
        /// <returns>返回用于检测碰撞的Rect</returns>
        public CCRect rect()
        {
            CCSize s = Texture.getContentSize();//Wolf纹理的大小
            return new CCRect(this.position.x, this.position.y, this.contentSize.width / 2, this.contentSize.height / 2);//设置Rect
        }

        public override void onEnter()
        {
            CCTouchDispatcher.sharedDispatcher().addTargetedDelegate(this, 0, true);
            base.onEnter();
        }

        public override void onExit()
        {
            CCTouchDispatcher.sharedDispatcher().removeDelegate(this);
            base.onExit();
        }

        public virtual bool ccTouchBegan(CCTouch touch, CCEvent eventer)
        {
            return true;
        }

        public virtual void ccTouchMoved(CCTouch touch, CCEvent eventer)
        { }

        /// <summary>
        /// 触摸屏Ended事件
        /// </summary>
        /// <param name="touch"></param>
        /// <param name="eventer"></param>
        public virtual void ccTouchEnded(CCTouch touch, CCEvent eventer)
        {
            CCPoint touchPoint = touch.locationInView(touch.view());
            CCPoint convertedLocation = CCDirector.sharedDirector().convertToGL(touchPoint);

            //执行运动
            CCActionInterval move = CCMoveTo.actionWithDuration(2, convertedLocation);
            CCActionInterval move_ease_inout = CCEaseInOut.actionWithAction(move);//ease缓冲
            base.runAction(move_ease_inout);
        }

        public void ccTouchCancelled(CCTouch pTouch, CCEvent pEvent)
        {
            throw new NotImplementedException();
        }

        public void runing(CCLayer cclayer)
        {
            #region  Sprite跑动动画
            CCSize s = CCDirector.sharedDirector().getWinSize();
            // 创建批处理节点，读取plist文件
            CCSpriteBatchNode batch = CCSpriteBatchNode.batchNodeWithFile("plist/images/wolf_move");//批处理节点贴图
            cclayer.addChild(batch, 0, 1);
            CCSpriteFrameCache.sharedSpriteFrameCache().addSpriteFramesWithFile("plist/wolf_move");//读取plsit文件
            //起始精灵
            
            this.initWithSpriteFrameName("wolf_move1.png");
            this.position = (new CCPoint(s.width / 3, s.height / 2));
            batch.addChild(this);
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
            this.runAction(CCRepeatForever.actionWithAction(CCAnimate.actionWithAnimation(animation, false)));//执行动画
            #endregion
        }
    }
}
