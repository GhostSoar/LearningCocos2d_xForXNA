using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class TouchableSprite : CCSprite, ICCTargetedTouchDelegate
    {
        public new bool  spriteWithSpriteFrameName(string pszSpriteFrameName)
        {
            base.initWithSpriteFrameName(pszSpriteFrameName);
            return true;
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
        {}

        public virtual void ccTouchEnded(CCTouch touch, CCEvent eventer)
        {               
            CCPoint touchPoint = touch.locationInView(touch.view());
            CCPoint convertedLocation = CCDirector.sharedDirector().convertToGL(touchPoint);

            //执行运动
            CCActionInterval move = CCMoveTo.actionWithDuration(3, convertedLocation);
            CCActionInterval move_ease_inout = CCEaseInOut.actionWithAction(move);//ease缓冲
            base.runAction(move_ease_inout);
        }
        
        public void ccTouchCancelled(CCTouch pTouch, CCEvent pEvent)
        {
            throw new NotImplementedException();
        }
    }
}
