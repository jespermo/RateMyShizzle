using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RateMyShizzle.Models;

namespace RateMyShizzle.Providers
{
    public interface IRateProvider
    {
        Rate Rate { get; }
    }

    public class RateProvider: IRateProvider
    {
        public Rate Rate 
        { 
            get { return new Rate{Name = "test"}; }
            
        }
    }
}