﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NodeEditorDemo.Views.Nodes;

public class SignalView : UserControl
{
    public SignalView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}