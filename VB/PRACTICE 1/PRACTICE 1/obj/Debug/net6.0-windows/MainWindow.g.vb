﻿#ExternalChecksum("..\..\..\MainWindow.xaml","{ff1816ec-aa5e-4d10-87f7-6f4963833460}","63F92C6C9D29E7F4BA77C83BD01DAB4CBC115F9C")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports PRACTICE_1
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Controls.Ribbon
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''MainWindow
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class MainWindow
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",11)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents COLORCOMBO As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",18)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents AngleTextBox As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",19)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents AngleSlider As System.Windows.Controls.Slider
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",20)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents GreenTextBox As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",21)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BlueTextBox As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",22)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents RedTextBox As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",23)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents FINALNUMBER As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",24)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ADDBUTTON As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",25)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents GreenSlider As System.Windows.Controls.Slider
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",26)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents RedSlider As System.Windows.Controls.Slider
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\MainWindow.xaml",27)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BlueSlider As System.Windows.Controls.Slider
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/PRACTICE 1;component/mainwindow.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\MainWindow.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            
            #ExternalSource("..\..\..\MainWindow.xaml",10)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.Button_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.COLORCOMBO = CType(target,System.Windows.Controls.ComboBox)
            Return
        End If
        If (connectionId = 3) Then
            
            #ExternalSource("..\..\..\MainWindow.xaml",17)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.Button_Click_1)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            Me.AngleTextBox = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 5) Then
            Me.AngleSlider = CType(target,System.Windows.Controls.Slider)
            
            #ExternalSource("..\..\..\MainWindow.xaml",19)
            AddHandler Me.AngleSlider.ValueChanged, New System.Windows.RoutedPropertyChangedEventHandler(Of Double)(AddressOf Me.AngleSlider_ValueChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 6) Then
            Me.GreenTextBox = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 7) Then
            Me.BlueTextBox = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 8) Then
            Me.RedTextBox = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 9) Then
            Me.FINALNUMBER = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 10) Then
            Me.ADDBUTTON = CType(target,System.Windows.Controls.Button)
            Return
        End If
        If (connectionId = 11) Then
            Me.GreenSlider = CType(target,System.Windows.Controls.Slider)
            
            #ExternalSource("..\..\..\MainWindow.xaml",25)
            AddHandler Me.GreenSlider.ValueChanged, New System.Windows.RoutedPropertyChangedEventHandler(Of Double)(AddressOf Me.GreenSlider_ValueChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 12) Then
            Me.RedSlider = CType(target,System.Windows.Controls.Slider)
            
            #ExternalSource("..\..\..\MainWindow.xaml",26)
            AddHandler Me.RedSlider.ValueChanged, New System.Windows.RoutedPropertyChangedEventHandler(Of Double)(AddressOf Me.RedSlider_ValueChanged)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 13) Then
            Me.BlueSlider = CType(target,System.Windows.Controls.Slider)
            
            #ExternalSource("..\..\..\MainWindow.xaml",27)
            AddHandler Me.BlueSlider.ValueChanged, New System.Windows.RoutedPropertyChangedEventHandler(Of Double)(AddressOf Me.BlueSlider_ValueChanged)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

