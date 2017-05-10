using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.依赖倒置
//需求增加了，要用不同的播放器，播放不同的文件，我们要抽象出来，减少耦合。

//耦合关系就是依赖关系，如果依赖关系相当繁杂，牵一发而动全身，很难维护；依赖关系越少，耦合关系就越低，系统就越稳定，所以我们要减少依赖。

//幸亏Robert Martin大师提出了面向对象设计原则----依赖倒置原则： 　　

//A.上层模块不应该依赖于下层模块，它们共同依赖于一个抽象。 　
//B.抽象不能依赖于具象，具象依赖于抽象。
//理解：A.上层是使用者，下层是被使用者，这就导致的结果是上层依赖下层了，下层变动了，自然就会影响到上层了，导致系统不稳定，甚至是牵一发而动全身。那怎么减少依赖呢？就是上层和下层都去依赖另一个抽象，这个抽象比较稳定，整个就来说就比较稳定了。
//B.面向对象编程时面向抽象或者面向借口编程，抽象一般比较稳定，实现抽象的具体肯定是要依赖抽象的，抽象不应该去依赖别的具体，应该依赖抽象。
namespace IOC2
{

    class PlayMediaBox2
    {
        public void playMedia()
        {  
           //依赖倒置
            IMediaFile fileType = new MediaFileMp4();
            IPlayer player = new BaoFengPlayer();

            //下面这行代码以后比较稳定，不需要修改，如要使用不同的播放器播放不同的文件，只需要上面代码修改媒体文件类和播放器类
            player.play(fileType);
        }
    }
    /// <summary>
    /// 媒体文件接口
    /// </summary>
  public interface IMediaFile
    {
        string getFile();
    }
    /// <summary>
    /// MP4媒体文件
    /// </summary>
    public class MediaFileMp4:IMediaFile
    {
        public string getFile()
        {
          return  "获取.mp4文件";
        }
    }
    /// <summary>
    /// MOV媒体文件
    /// </summary>
    public class MediaFileWov : IMediaFile
    {
        public string getFile()
        {
            return "";
        }
    }


    /// <summary>
    /// 播放器接口
    /// </summary>
    public interface IPlayer
    {
        void play(IMediaFile file);
    }
    /// <summary>
    /// 暴风媒体播放器
    /// </summary>
    public class BaoFengPlayer:IPlayer
    {   
        public void play(IMediaFile file)
        {
            
            Console.WriteLine("暴风播放器播放媒体文件:" + file.getFile());
        }
    }
    /// <summary>
    /// 迅雷播放器
    /// </summary>
    public class XunLeiPlayer : IPlayer
    {
        public void play(IMediaFile file)
        {
            Console.WriteLine("迅雷播放器播放媒体文件:" + file.getFile());
        }
    }
}
