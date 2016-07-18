using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PersonalInformationSystem.Models;
using AutoMapper;
using System.Reflection;

namespace PersonalInformationSystem
{

    //public static class MapConfiguration
    //{
    //    public static void ConfigureAutoMap()
    //    {
    //        //Sundar Setup OfficeName

    //        AutoMapper.Mapper.CreateMap<StudentInfoModel, StudentInfo>().IgnoreAllNonExisting();
    //        AutoMapper.Mapper.CreateMap<StudentInfo, StudentInfoModel>().IgnoreAllNonExisting();

    //        AutoMapper.Mapper.AssertConfigurationIsValid();


    //    }

    //    public static IMappingExpression<TSource, TDestination> IgnoreAllNonExisting<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
    //    {
    //        var flags = BindingFlags.Public | BindingFlags.Instance;
    //        var sourceType = typeof(TSource);
    //        var destinationProperties = typeof(TDestination).GetProperties(flags);

    //        foreach (var property in destinationProperties)
    //        {
    //            if (sourceType.GetProperty(property.Name, flags) == null)
    //            {
    //                expression.ForMember(property.Name, opt => opt.Ignore());
    //            }
    //        }
    //        return expression;
    //    }
    //}

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //MapConfiguration.ConfigureAutoMap();
           // AuthConfig.RegisterAuth();

        }
    }
}
