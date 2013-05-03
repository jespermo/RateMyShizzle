﻿using System;
using System.Linq;
using System.Web.Mvc;
using Castle.Core;
using Castle.Core.Internal;
using Castle.MicroKernel;
using Castle.Windsor;
using NUnit.Framework;
using RateMyShizzle.App_Start.Control;
using RateMyShizzle.Controllers;

namespace RateMyShizzle.Tests
{
    [TestFixture]
    public class DITest
    {
        private IWindsorContainer _containerWithControllers;

        public DITest()
        {
            _containerWithControllers = new WindsorContainer()
                .Install(new ControllerInstaller());
        }
        [Test]
        public void AllControllersImplementIController()
        {
            var allHandlers = GetAllHandlers(_containerWithControllers);
            var controllerHandlers = GetHandlersFor(typeof(IController), _containerWithControllers);

            Assert.IsNotEmpty(allHandlers);
            Assert.AreEqual(allHandlers, controllerHandlers);
        }
        [Test]
        public void AllControllersAreRegistered()
        {
            // Is<TType> is an helper, extension method from Windsor in the Castle.Core.Internal namespace
            // which behaves like 'is' keyword in C# but at a Type, not instance level
            var allControllers = GetPublicClassesFromApplicationAssembly(c => c.Is<IController>());
            var registeredControllers = GetImplementationTypesFor(typeof(IController), _containerWithControllers);
            Assert.AreEqual(allControllers, registeredControllers);
        }

        [Test]
        public void AllAndOnlyControllersHaveControllersSuffix()
        {
            var allControllers = GetPublicClassesFromApplicationAssembly(c => c.Name.EndsWith("Controller"));
            var registeredControllers = GetImplementationTypesFor(typeof(IController), _containerWithControllers);
            Assert.AreEqual(allControllers, registeredControllers);
        }

        [Test]
        public void AllAndOnlyControllersLiveInControllersNamespace()
        {
            var allControllers = GetPublicClassesFromApplicationAssembly(c => c.Namespace.Contains("Controllers"));
            var registeredControllers = GetImplementationTypesFor(typeof(IController), _containerWithControllers);
            Assert.AreEqual(allControllers, registeredControllers);
        }

        [Test]
        public void AllControllersAreTransient()
        {
            var nonTransientControllers = GetHandlersFor(typeof(IController), _containerWithControllers)
                .Where(controller => controller.ComponentModel.LifestyleType != LifestyleType.Transient)
                .ToArray();

            Assert.IsEmpty(nonTransientControllers);
        }

        [Test]
        public void AllControllersExposeThemselvesAsService()
        {
            var controllersWithWrongName = GetHandlersFor(typeof(IController), _containerWithControllers)
                .Where(controller => controller.ComponentModel.Services.Single() != controller.ComponentModel.Implementation)
                .ToArray();

            Assert.IsEmpty(controllersWithWrongName);
        }
        private Type[] GetImplementationTypesFor(Type type, IWindsorContainer container)
        {
            return GetHandlersFor(type, container)
                .Select(h => h.ComponentModel.Implementation)
                .OrderBy(t => t.Name)
                .ToArray();
        }

        private Type[] GetPublicClassesFromApplicationAssembly(Predicate<Type> where)
        {
            return typeof(HomeController).Assembly.GetExportedTypes()
                .Where(t => t.IsClass)
                .Where(t => t.IsAbstract == false)
                .Where(where.Invoke)
                .OrderBy(t => t.Name)
                .ToArray();
        }


        private IHandler[] GetAllHandlers(IWindsorContainer container)
        {
            return GetHandlersFor(typeof(object), container);
        }

        private IHandler[] GetHandlersFor(Type type, IWindsorContainer container)
        {
            return container.Kernel.GetAssignableHandlers(type);
        }
    
    }
}
