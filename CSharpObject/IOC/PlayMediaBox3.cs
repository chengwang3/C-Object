using System;
using System.Configuration;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//控制反转(IOC)
//控制反转IoC是Inversion of Control的缩写，是说对象的控制权进行转移，转移到第三方，比如转移交给了IoC容器，它就是一个创建工厂，你要什么对象，它就给你什么对象，有了IoC容器，依赖关系就变了，原先的依赖关系就没了，它们都依赖IoC容器了，通过IoC容器来建立它们之间的关系。
namespace IOC3
{
    class PlayMediaBox3
    {
        public void playMedia()
        {
            //具体的对象名写在配置文件里，这时候客户端代码也不用变了，只需要改配置文件就好了，稳定性又有了提高，
            IMediaFile fileType = new MediaFileMp4(); //Assembly.Load(ConfigurationManager.AppSettings["AssemName"]).CreateInstance(ConfigurationManager.AppSettings["MediaFileMp4"]); 
            IPlayer player = new BaoFengPlayer();//  //Assembly.Load(ConfigurationManager.AppSettings["AssemName"]).CreateInstance(ConfigurationManager.AppSettings["BaoFengPlayer"]); ;

           
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
