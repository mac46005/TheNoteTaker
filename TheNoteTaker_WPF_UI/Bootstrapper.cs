﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNoteTaker_WPF_UI
{
    public class Bootstrapper : BootstrapperBase
    {
        SimpleContainer _container = new SimpleContainer();

        protected override void Configure()
        {
            _container.Instance(_container);
            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>();




            GetType().Assembly.GetTypes()
                .Where(t => t.IsClass)
                .Where(t => t.Name.EndsWith("ViewModel"))
                .ToList()
                .ForEach(vm => _container.RegisterPerRequest(vm, vm.ToString(), vm));
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }
    }
}
