using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//上面说到控制反转，是一个思想概念，但是也要具体实现的，上面的配置文件也是一种实现方式。依赖注入提出了具体的思想。
//依赖注入DI是Dependency Injection缩写，它提出了“哪些东东的控制权被反转了，被转移了？”，它也给出了答案：“依赖对象的创建获得被反转”。
//所谓依赖注入，就是由IoC容器在运行期间，动态地将某种依赖关系注入到对象之中。
namespace IOC4
{
    class PlayMediaBox4
    {
        IMediaFile _file;
        IPlayer _play;
        public PlayMediaBox4(IMediaFile file, IPlayer play)
        {
            this._file = file;
            this._play = play;
        }

        public void playMedia()
        {
            _play.play(_file);
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
    public class MediaFileMp4 : IMediaFile
    {
        public string getFile()
        {
            return "获取.mp4文件";
        }
    }
    /// <summary>
    /// MOV媒体文件
    /// </summary>
    public class MediaFileWov : IMediaFile
    {
        public string getFile()
        {
            return "获取.wov文件";
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
    public class BaoFengPlayer : IPlayer
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
