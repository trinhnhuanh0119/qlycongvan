using DataAccess.Repositories;
using DataAccess.Services;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Unity;

namespace webAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            
            var container = new UnityContainer();

            container.RegisterType<ICCQBHRepository, CCQBHRepository>();
            container.RegisterType<ICQBHRepository, CQBHRepository>();
            container.RegisterType<ICapSoRepository, CapSoRepository>();
            container.RegisterType<ICV_DiRepository, CV_DiRepository>();
            container.RegisterType<IDoKhanRepository, DoKhanRepository>();
            container.RegisterType<IDoMatRepository, DoMatRepository>();
            container.RegisterType<IDVRepository, DVRepository>();
            container.RegisterType<IKhoLuuTruRepository, KhoLuuTruRepository>();
            container.RegisterType<ILoaiBQRepository, LoaiBQRepository>();
            container.RegisterType<ILuuTruRepository, LuuTruRepository>();
            container.RegisterType<ILVBRepository, LVBRepository>();
            container.RegisterType<IMenuRepository, MenuRepository>();
            container.RegisterType<INBHRepository, NBHRepository>();
            container.RegisterType<INNDRepository, NNDRepository>();
            container.RegisterType<INNVBRepository, NNVBRepository>();
            container.RegisterType<IPhongRepository, PhongRepository>();
            container.RegisterType<ISVBRepository, SVBRepository>();
            container.RegisterType<ITDKRepository, TDKRepository>();
            container.RegisterType<IUsersRepository, UsersRepository>();
            container.RegisterType<IConnectionFactory, ConnectionFactory>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<ICCQBHService, CCQBHService>();
            container.RegisterType<ICQBHService, CQBHService>();
            container.RegisterType<ICapSoService, CapSoService>();
            container.RegisterType<CV_DiService, CV_DiService>();
            container.RegisterType<DoKhanService, DoKhanService>();
            container.RegisterType<IDoMatService, DoMatService>();
            container.RegisterType<IDVService, DVService>();
            container.RegisterType<IKhoLuuTruService, KhoLuuTruService>();
            container.RegisterType<ILoaiBQService, LoaiBQService>();
            container.RegisterType<ILuuTruService, LuuTruService>();
            container.RegisterType<ILVBService, LVBService>();
            container.RegisterType<IMenuService, MenuService>();
            container.RegisterType<INBHService, NBHService>();
            container.RegisterType<INNDService, NNDService>();
            container.RegisterType<INNVBService, NNVBService>();
            container.RegisterType<IPhongService, PhongService>();
            container.RegisterType<ISVBService, SVBService>();
            container.RegisterType<ITDKService, TDKService>();
            container.RegisterType<IUsersService, UsersService>();
            config.DependencyResolver = new UnityResolver(container);
            

            // Web API configuration and services  
            // Configure Web API to use only bearer token authentication.  
            //config.SuppressDefaultHostAuthentication();
            //config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes  
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
        
    }
} 

