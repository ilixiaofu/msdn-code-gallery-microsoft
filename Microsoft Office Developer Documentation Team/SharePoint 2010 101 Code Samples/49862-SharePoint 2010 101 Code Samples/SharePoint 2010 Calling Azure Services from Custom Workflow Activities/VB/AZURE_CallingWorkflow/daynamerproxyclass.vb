﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
 System.ServiceModel.ServiceContractAttribute(ConfigurationName:="IDayNamer")>  _
Public Interface IDayNamer
    
    <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDayNamer/TodayIs", ReplyAction:="http://tempuri.org/IDayNamer/TodayIsResponse")>  _
    Function TodayIs() As String
    
    <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IDayNamer/TodayAdd", ReplyAction:="http://tempuri.org/IDayNamer/TodayAddResponse")>  _
    Function TodayAdd(ByVal daysToAdd As Integer) As String
End Interface

<System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
Public Interface IDayNamerChannel
    Inherits IDayNamer, System.ServiceModel.IClientChannel
End Interface

<System.Diagnostics.DebuggerStepThroughAttribute(),  _
 System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
Partial Public Class DayNamerClient
    Inherits System.ServiceModel.ClientBase(Of IDayNamer)
    Implements IDayNamer
    
    Public Sub New()
        MyBase.New
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String)
        MyBase.New(endpointConfigurationName)
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(endpointConfigurationName, remoteAddress)
    End Sub
    
    Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
        MyBase.New(binding, remoteAddress)
    End Sub
    
    Public Function TodayIs() As String Implements IDayNamer.TodayIs
        Return MyBase.Channel.TodayIs
    End Function
    
    Public Function TodayAdd(ByVal daysToAdd As Integer) As String Implements IDayNamer.TodayAdd
        Return MyBase.Channel.TodayAdd(daysToAdd)
    End Function
End Class
