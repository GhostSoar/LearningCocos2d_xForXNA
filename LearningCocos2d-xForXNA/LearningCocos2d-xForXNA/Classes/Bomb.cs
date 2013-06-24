using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class Bomb:CCSprite
    {
        public Bomb(CCLayer layer)
        {
            Random rnd = new Random();
            float posionX = 100 * (float)rnd.Next(1, 4);//Gold起始位置X坐标值
            this.initWithFile("img/Wolf/Others/bomb");
            this.position = new CCPoint(posionX, 850);//Gold起始位置
            layer.addChild(this);
            this.runAction(CCMoveTo.actionWithDuration(5.0f, new CCPoint(posionX, -50)));//运动，垂直向下运动
        }

        /// <summary>
        /// 创建检测碰撞Rect
        /// </summary>
        /// <returns>返回用于检测碰撞的Rect</returns>
        public CCRect rect()
        {
            CCSize s = Texture.getContentSize();//Bomb纹理的大小
            return new CCRect(this.position.x, this.position.y, this.contentSize.width/2, this.contentSize.height/2);//设置Rect
        }

        /// <summary>
        /// 检测是否与Wolf对象碰撞
        /// </summary>
        /// <param name="wolf"></param>
        /// <returns>碰撞返回true，否则返回false</returns>
        public bool collideWithWolf(Wolf wolf)
        {
            CCRect wolfRect = wolf.rect();
            if(CCRect.CCRectIntersetsRect(wolfRect,rect()))//通过Rect是否相交判断是否碰撞
            {
                return true;
            }
            return false;
        }
    }
}
