﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace WSPC
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="WSPC.WSPanelControlSoap")>  _
    Public Interface WSPanelControlSoap
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorld(ByVal request As WSPC.HelloWorldRequest) As WSPC.HelloWorldResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorldAsync(ByVal request As WSPC.HelloWorldRequest) As System.Threading.Tasks.Task(Of WSPC.HelloWorldResponse)
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Users del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/UserNew", ReplyAction:="*")>  _
        Function UserNew(ByVal request As WSPC.UserNewRequest) As WSPC.UserNewResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/UserNew", ReplyAction:="*")>  _
        Function UserNewAsync(ByVal request As WSPC.UserNewRequest) As System.Threading.Tasks.Task(Of WSPC.UserNewResponse)
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Users del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/UpdaterNew", ReplyAction:="*")>  _
        Function UpdaterNew(ByVal request As WSPC.UpdaterNewRequest) As WSPC.UpdaterNewResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/UpdaterNew", ReplyAction:="*")>  _
        Function UpdaterNewAsync(ByVal request As WSPC.UpdaterNewRequest) As System.Threading.Tasks.Task(Of WSPC.UpdaterNewResponse)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorld", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As WSPC.HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As WSPC.HelloWorldRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute()>  _
    Partial Public Class HelloWorldRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class HelloWorldResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="HelloWorldResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As WSPC.HelloWorldResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As WSPC.HelloWorldResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class HelloWorldResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public HelloWorldResult As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal HelloWorldResult As String)
            MyBase.New
            Me.HelloWorldResult = HelloWorldResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class UserNewRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="UserNew", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As WSPC.UserNewRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As WSPC.UserNewRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UserNewRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public Users As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Users As String)
            MyBase.New
            Me.Users = Users
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class UserNewResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="UserNewResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As WSPC.UserNewResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As WSPC.UserNewResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UserNewResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public UserNewResult As Integer
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal UserNewResult As Integer)
            MyBase.New
            Me.UserNewResult = UserNewResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class UpdaterNewRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="UpdaterNew", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As WSPC.UpdaterNewRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As WSPC.UpdaterNewRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UpdaterNewRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public Users As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Users As String)
            MyBase.New
            Me.Users = Users
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class UpdaterNewResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="UpdaterNewResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As WSPC.UpdaterNewResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As WSPC.UpdaterNewResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class UpdaterNewResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public UpdaterNewResult As Integer
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal UpdaterNewResult As Integer)
            MyBase.New
            Me.UpdaterNewResult = UpdaterNewResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface WSPanelControlSoapChannel
        Inherits WSPC.WSPanelControlSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class WSPanelControlSoapClient
        Inherits System.ServiceModel.ClientBase(Of WSPC.WSPanelControlSoap)
        Implements WSPC.WSPanelControlSoap
        
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
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSPC_WSPanelControlSoap_HelloWorld(ByVal request As WSPC.HelloWorldRequest) As WSPC.HelloWorldResponse Implements WSPC.WSPanelControlSoap.HelloWorld
            Return MyBase.Channel.HelloWorld(request)
        End Function
        
        Public Function HelloWorld() As String
            Dim inValue As WSPC.HelloWorldRequest = New WSPC.HelloWorldRequest()
            inValue.Body = New WSPC.HelloWorldRequestBody()
            Dim retVal As WSPC.HelloWorldResponse = CType(Me,WSPC.WSPanelControlSoap).HelloWorld(inValue)
            Return retVal.Body.HelloWorldResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSPC_WSPanelControlSoap_HelloWorldAsync(ByVal request As WSPC.HelloWorldRequest) As System.Threading.Tasks.Task(Of WSPC.HelloWorldResponse) Implements WSPC.WSPanelControlSoap.HelloWorldAsync
            Return MyBase.Channel.HelloWorldAsync(request)
        End Function
        
        Public Function HelloWorldAsync() As System.Threading.Tasks.Task(Of WSPC.HelloWorldResponse)
            Dim inValue As WSPC.HelloWorldRequest = New WSPC.HelloWorldRequest()
            inValue.Body = New WSPC.HelloWorldRequestBody()
            Return CType(Me,WSPC.WSPanelControlSoap).HelloWorldAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSPC_WSPanelControlSoap_UserNew(ByVal request As WSPC.UserNewRequest) As WSPC.UserNewResponse Implements WSPC.WSPanelControlSoap.UserNew
            Return MyBase.Channel.UserNew(request)
        End Function
        
        Public Function UserNew(ByVal Users As String) As Integer
            Dim inValue As WSPC.UserNewRequest = New WSPC.UserNewRequest()
            inValue.Body = New WSPC.UserNewRequestBody()
            inValue.Body.Users = Users
            Dim retVal As WSPC.UserNewResponse = CType(Me,WSPC.WSPanelControlSoap).UserNew(inValue)
            Return retVal.Body.UserNewResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSPC_WSPanelControlSoap_UserNewAsync(ByVal request As WSPC.UserNewRequest) As System.Threading.Tasks.Task(Of WSPC.UserNewResponse) Implements WSPC.WSPanelControlSoap.UserNewAsync
            Return MyBase.Channel.UserNewAsync(request)
        End Function
        
        Public Function UserNewAsync(ByVal Users As String) As System.Threading.Tasks.Task(Of WSPC.UserNewResponse)
            Dim inValue As WSPC.UserNewRequest = New WSPC.UserNewRequest()
            inValue.Body = New WSPC.UserNewRequestBody()
            inValue.Body.Users = Users
            Return CType(Me,WSPC.WSPanelControlSoap).UserNewAsync(inValue)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSPC_WSPanelControlSoap_UpdaterNew(ByVal request As WSPC.UpdaterNewRequest) As WSPC.UpdaterNewResponse Implements WSPC.WSPanelControlSoap.UpdaterNew
            Return MyBase.Channel.UpdaterNew(request)
        End Function
        
        Public Function UpdaterNew(ByVal Users As String) As Integer
            Dim inValue As WSPC.UpdaterNewRequest = New WSPC.UpdaterNewRequest()
            inValue.Body = New WSPC.UpdaterNewRequestBody()
            inValue.Body.Users = Users
            Dim retVal As WSPC.UpdaterNewResponse = CType(Me,WSPC.WSPanelControlSoap).UpdaterNew(inValue)
            Return retVal.Body.UpdaterNewResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function WSPC_WSPanelControlSoap_UpdaterNewAsync(ByVal request As WSPC.UpdaterNewRequest) As System.Threading.Tasks.Task(Of WSPC.UpdaterNewResponse) Implements WSPC.WSPanelControlSoap.UpdaterNewAsync
            Return MyBase.Channel.UpdaterNewAsync(request)
        End Function
        
        Public Function UpdaterNewAsync(ByVal Users As String) As System.Threading.Tasks.Task(Of WSPC.UpdaterNewResponse)
            Dim inValue As WSPC.UpdaterNewRequest = New WSPC.UpdaterNewRequest()
            inValue.Body = New WSPC.UpdaterNewRequestBody()
            inValue.Body.Users = Users
            Return CType(Me,WSPC.WSPanelControlSoap).UpdaterNewAsync(inValue)
        End Function
    End Class
End Namespace
