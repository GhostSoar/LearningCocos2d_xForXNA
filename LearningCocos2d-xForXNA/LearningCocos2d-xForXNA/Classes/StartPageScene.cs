using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class StartPageScene:CCScene
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public StartPageScene()
        {
            CCLayer _startPageLayer = new StartPageLayer();//StartPageLayer对象
            this.addChild(_startPageLayer);//将Layer对象添加到Scene下
        }
    }
}
