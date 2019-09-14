using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace XplatCollect.ViewModels
{
    public sealed class HomePageViewModel : BindableBase
    {
        //Atributo:
        private string title;
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value); //Framework
        }
    }
}
