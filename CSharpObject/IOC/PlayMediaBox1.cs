using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    //1.依赖：依赖就是有联系，有地方使用到它就是有依赖它，一个系统不可能完全避免依赖。如果你的一个类或者模块在项目中没有用到它，恭喜你，可以从项目中剔除它或者排除它了，因为没有一个地方会依赖它
    public class PlayMediaBox1
    {
       public void playMedia()
        {  //依赖媒体播放器和媒体文件
            MediaFile fileType = new MediaFile();
            Player player = new Player();
            player.play(fileType.filePath);
        }
    }

    /// <summary>
    /// 媒体文件
    /// </summary>
    public class MediaFile
    {
        public string filePath { get; set; }
    }
    /// <summary>
    /// 媒体播放器
    /// </summary>
    public class Player
    {   //依赖媒体文件
        public void play(string filePath)
        {
            Console.WriteLine("播放媒体文件:" + filePath);
        }
    }
}
