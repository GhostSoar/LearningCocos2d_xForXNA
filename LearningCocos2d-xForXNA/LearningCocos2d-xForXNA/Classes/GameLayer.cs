using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class GameLayer:CCLayer
    {
        Random rnd=new Random();//随机变量
        const int likelihoodGold = 70;//产生Gold的比例
        const int likelihoodBomb = 30;//产生Bomb的比例
        CCLabelTTF lblScore;//文本，记录游戏得分
        int score;//得分
        Wolf wolf;//主角
        List<Gold> golds = new List<Gold>();//用于存储Gold对象
        List<Bomb> bombs = new List<Bomb>();//用于存储Bomb对象
        public GameLayer()
        {
            base.isTouchEnabled = true;//开启触屏事件
            CCDirector.sharedDirector().deviceOrientation = ccDeviceOrientation.kCCDeviceOrientationPortraitUpsideDown;//设置朝向，竖屏

            //得分
            score = 0;
            lblScore = CCLabelTTF.labelWithString(string.Format("得分：{0}",score), "Yahei", 30);
            lblScore.position = new CCPoint(100, 100);
            this.addChild(lblScore);

            wolf = new Wolf();
            wolf.runing(this);//Sprite跑动动画

            this.schedule(CreateGoldOrBomb, 3.0f);//每隔3.0秒调用函数，类似线程
            this.schedule(collide);//默认下1.0/60s执行
            
        }

        /// <summary>
        /// 创建Gold对象
        /// </summary>
        /// <param name="dt">时间间隔</param>
        public void CreateGoldOrBomb(float dt)
        {
            int random = rnd.Next(1, 100);//产生1-100间随机数
            if (random < 30)//产生Bomb
            {
                Bomb bomb = new Bomb(this);
                bombs.Add(bomb);
            }
            else//产生Gold
            {
                Gold gold = new Gold(this);
                golds.Add(gold);
            }
        }

        /// <summary>
        /// 碰撞检测
        /// </summary>
        /// <param name="dt"></param>
        public void collide(float dt)
        {
            for (int i = 0; i < golds.Count; i++)//遍历golds
            {
                if (golds[i].collideWithWolf(wolf))//调用Gold判断碰撞的方法，如果碰撞返回true，否则返回false
                {
                    removeChild(golds[i], true);//将碰撞的Gold节点移除
                    golds.RemoveAt(i);//移除泛型golds中节点
                    lblScore.setString(string.Format("得分：{0}", (++score).ToString().Trim()));//得分
                }
            }
            for (int i = 0; i < bombs.Count; i++)//遍历bombs
            {
                if (bombs[i].collideWithWolf(wolf))//调用Bomb判断碰撞的方法，如果碰撞返回true，否则返回false
                {
                    removeChild(bombs[i], true);//将碰撞的Bomb节点移除
                    bombs.RemoveAt(i);//移除泛型bombs中节点
                    lblScore.setString(string.Format("得分：{0}", (--score).ToString().Trim()));//扣分
                }
            }
        }
    }
}
