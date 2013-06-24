using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class StartPageLayer:CCLayer
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public StartPageLayer()
        {
            //创建一个Lable标签，显示文字StartPage
            //Arial为内容管道中的字体纹理
            //30为字体大小
            CCLabelTTF lbl_Start = CCLabelTTF.labelWithString("StartPage", "Arial", 30);
            CCSize size = CCDirector.sharedDirector().getWinSize();//通过CCDirector（导演）获取窗口大小
            lbl_Start.position = new CCPoint(size.width / 2, size.height / 2);//设置lbl_Start的显示位置
            this.addChild(lbl_Start);//将其添加到Layer下

            CCSprite img_SGQ = CCSprite.spriteWithFile("img/imgSGQ");//读取内容管道（Content）中图片
            img_SGQ.position = new CCPoint(size.width / 2, size.height / 3);//设置图片位置
            this.addChild(img_SGQ);//将其添加到Layer下

            //中文显示
            CCLabelTTF lbl_Chinese = CCLabelTTF.labelWithString("铁道部", "Yahei", 30);//可在Yahei.spritefont纹理中修改大小
            lbl_Chinese.position = new CCPoint(size.width / 2, size.height / 1.5f);//设置lbl_Chinese的显示位置
            this.addChild(lbl_Chinese);//将其添加到Layer下

        }
    }
}
