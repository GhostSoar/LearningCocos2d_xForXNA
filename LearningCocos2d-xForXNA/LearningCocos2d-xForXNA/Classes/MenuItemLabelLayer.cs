using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cocos2d;

namespace LearningCocos2d_xForXNA.Classes
{
    class MenuItemLabelLayer:CCLayer
    {
        public MenuItemLabelLayer()
        {
            CCMenuItemFont _menuItemFont1 = CCMenuItemFont.itemFromString("START");//添加“START”菜单按钮，未添加事件处理，点击会有错误
            _menuItemFont1.FontNameObj = "Arial";//字体纹理（Content）
            
            //中文显示时，记得添加中文字符到message.txt,上一讲中提及
            CCMenuItemFont.FontName = "Yahei";//注意，中文显示时，此句必须在下句前面，否则编译出错
            CCMenuItemFont _menuItemFont2 = CCMenuItemFont.itemFromString("开始", this, this.menuItemFont2Handle);//参数除文字外，还添加事件处理
            
            CCMenu menu = CCMenu.menuWithItems(_menuItemFont1,_menuItemFont2);//将MenuItem添加到CCMenu
            menu.alignItemsVertically();//菜单垂直排列
            this.addChild(menu);//menu添加到Layer
        }

        /// <summary>
        /// menuItemFont2点击事件处理函数
        /// </summary>
        /// <param name="sender"></param>
        public void menuItemFont2Handle(CCObject sender)
        {

        }
    }
}
