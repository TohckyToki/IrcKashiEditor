﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.ComponentModel;
using System.Windows.Input;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace IrcKashiEditor {
    public sealed partial class MusicPlayer : UserControl, INotifyPropertyChanged {
        private bool _isPuase = false;

        public bool IsPause {
            get => _isPuase;
            set {
                _isPuase = value;
                CustomSymbolIcon = value ? Symbol.Pause : Symbol.Play;
                PropertyChanged(this, new PropertyChangedEventArgs("IsPause"));
                PropertyChanged(this, new PropertyChangedEventArgs("CustomSymbolIcon"));
            }
        }

        public Symbol CustomSymbolIcon { get; private set; } = Symbol.Play;

        public event PropertyChangedEventHandler PropertyChanged;

        public MusicPlayer() {
            this.InitializeComponent();
            this.DataContext = this;
        }

        private void ChangePlayState(object sender, RoutedEventArgs e) {
            IsPause = !IsPause;
        }
    }
}
