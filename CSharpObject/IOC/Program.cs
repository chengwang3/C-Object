using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using IOC4;//引入PlayMediaBox4类
//哪些要依赖注入，依赖对象需要获得实例的地方，即 PlayMedia方法，需要IPlayer具体对象和IMediaFile的具体对象，找到了地方就从这里下手，为了灵活的控制这两个对象，必须是外面能够控制着两个对象的实例化，提供对外的操作是必要的，可以是属性，可以是方法，可以是构造函数，总之别的地方可以控制它，下面将会使用Unity来注入，使用的是构造函数注入
namespace IOC
{
    class Program
    {
        static UnityContainer contain1 = new UnityContainer();
        static UnityContainer contain2 = new UnityContainer();
        static void init()
        {
            //注册对象
            contain1.RegisterType<IMediaFile, MediaFileMp4>();
            contain1.RegisterType<IPlayer, BaoFengPlayer>();
            contain2.RegisterType<IMediaFile, MediaFileWov>();
            contain2.RegisterType<IPlayer, XunLeiPlayer>();
        }
        static void Main(string[] args)
        {
            init();
            //生成对象
            PlayMediaBox4 play1 = contain1.Resolve<PlayMediaBox4>();
            play1.playMedia();

            PlayMediaBox4 play2 = contain2.Resolve<PlayMediaBox4>();
            play2.playMedia();
            Console.ReadKey();
        }
    }
}
