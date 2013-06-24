using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class MenuItemLabelScene:CCScene
    {
        /// <summary>
        /// 构造方法
        /// </summary>
        public MenuItemLabelScene()
        {
            CCLayer _menuItemLabelLayer = new MenuItemLabelLayer();//Layer对象
            this.addChild(_menuItemLabelLayer);//Scene中添加Layer
        }
    }
}
