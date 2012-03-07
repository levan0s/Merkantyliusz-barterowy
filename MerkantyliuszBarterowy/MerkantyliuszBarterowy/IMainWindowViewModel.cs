﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MerkantyliuszBarterowy
{
    public interface IMainWindowViewModel
    {
        ICommand ShowBarterViewCommand { get; }
        ICommand ShowVoyageViewCommand { get; }
    }
}
