﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="datasave")>  _
Partial Public Class DataClasses_pieceparaDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "可扩展性方法定义"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertpiecepara(instance As piecepara)
    End Sub
  Partial Private Sub Updatepiecepara(instance As piecepara)
    End Sub
  Partial Private Sub Deletepiecepara(instance As piecepara)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.逆转测试.My.MySettings.Default.datasaveConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property piecepara() As System.Data.Linq.Table(Of piecepara)
		Get
			Return Me.GetTable(Of piecepara)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.piecepara")>  _
Partial Public Class piecepara
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _工件类别 As String
	
	Private _反驱力最大值上限 As String
	
	Private _反驱力最大值下限 As String
	
	Private _反驱力最小值上限 As String
	
	Private _反驱力最小值下限 As String
	
	Private _反驱力波动量上限 As String
	
	Private _反驱力波动量下限 As String
	
	Private _反驱力平均值上限 As String
	
	Private _反驱力平均值下限 As String
	
	Private _左右波动量差值上限 As String
	
	Private _左右波动量差值下限 As String
	
	Private _反驱动位移上限 As String
	
	Private _反驱动位移下限 As String
	
	Private _齿条径向间隙上限 As String
	
	Private _齿条径向间隙下限 As String
	
	Private _齿条径向力上限 As String
	
	Private _齿条径向力下限 As String
	
	Private _间隙检测抽检间隔 As String
	
	Private _测试速度 As String
	
	Private _换向力 As String
	
	Private _扫条码使能 As String
	
	Private _左反驱力标定 As String
	
	Private _右反驱力标定 As String
	
	Private _位移标定 As String
	
	Private _径向力标定 As String
	
	Private _径向间隙标定 As String
	
	Private _零点偏置 As String
	
	Private _左反驱力调整 As String
	
	Private _右反驱力调整 As String
	
	Private _最大换向力 As String
	
	Private _有效测试位移百分比 As String
	
	Private _反驱力调整系数 As String
	
	Private _间隙检测调整系数 As String
	
	Private _零位判断基准电压 As String
	
	Private _间隙检测位置 As String
	
	Private _左右平均力差值上限 As String
	
	Private _左右平均力差值下限 As String
	
	Private _间隙下拉力补偿参数 As String
	
	Private _间隙上拉力补偿参数 As String
	
	Private _下拉间隙补偿参数 As String
	
	Private _上拉间隙补偿参数 As String
	
	Private _超时设置 As String
	
	Private _回中补偿电压 As String
	
	Private _图像滤波百分比 As String
	
	Private _阈值补偿 As String
	
	Private _是否滤波 As String
	
	Private _量化点数 As String
	
	Private _中位记号笔使能 As String
	
	Private _右反驱位移补偿参数 As String
	
	Private _左反驱位移补偿参数 As String
	
    #Region "可扩展性方法定义"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub On工件类别Changing(value As String)
    End Sub
    Partial Private Sub On工件类别Changed()
    End Sub
    Partial Private Sub On反驱力最大值上限Changing(value As String)
    End Sub
    Partial Private Sub On反驱力最大值上限Changed()
    End Sub
    Partial Private Sub On反驱力最大值下限Changing(value As String)
    End Sub
    Partial Private Sub On反驱力最大值下限Changed()
    End Sub
    Partial Private Sub On反驱力最小值上限Changing(value As String)
    End Sub
    Partial Private Sub On反驱力最小值上限Changed()
    End Sub
    Partial Private Sub On反驱力最小值下限Changing(value As String)
    End Sub
    Partial Private Sub On反驱力最小值下限Changed()
    End Sub
    Partial Private Sub On反驱力波动量上限Changing(value As String)
    End Sub
    Partial Private Sub On反驱力波动量上限Changed()
    End Sub
    Partial Private Sub On反驱力波动量下限Changing(value As String)
    End Sub
    Partial Private Sub On反驱力波动量下限Changed()
    End Sub
    Partial Private Sub On反驱力平均值上限Changing(value As String)
    End Sub
    Partial Private Sub On反驱力平均值上限Changed()
    End Sub
    Partial Private Sub On反驱力平均值下限Changing(value As String)
    End Sub
    Partial Private Sub On反驱力平均值下限Changed()
    End Sub
    Partial Private Sub On左右波动量差值上限Changing(value As String)
    End Sub
    Partial Private Sub On左右波动量差值上限Changed()
    End Sub
    Partial Private Sub On左右波动量差值下限Changing(value As String)
    End Sub
    Partial Private Sub On左右波动量差值下限Changed()
    End Sub
    Partial Private Sub On反驱动位移上限Changing(value As String)
    End Sub
    Partial Private Sub On反驱动位移上限Changed()
    End Sub
    Partial Private Sub On反驱动位移下限Changing(value As String)
    End Sub
    Partial Private Sub On反驱动位移下限Changed()
    End Sub
    Partial Private Sub On齿条径向间隙上限Changing(value As String)
    End Sub
    Partial Private Sub On齿条径向间隙上限Changed()
    End Sub
    Partial Private Sub On齿条径向间隙下限Changing(value As String)
    End Sub
    Partial Private Sub On齿条径向间隙下限Changed()
    End Sub
    Partial Private Sub On齿条径向力上限Changing(value As String)
    End Sub
    Partial Private Sub On齿条径向力上限Changed()
    End Sub
    Partial Private Sub On齿条径向力下限Changing(value As String)
    End Sub
    Partial Private Sub On齿条径向力下限Changed()
    End Sub
    Partial Private Sub On间隙检测抽检间隔Changing(value As String)
    End Sub
    Partial Private Sub On间隙检测抽检间隔Changed()
    End Sub
    Partial Private Sub On测试速度Changing(value As String)
    End Sub
    Partial Private Sub On测试速度Changed()
    End Sub
    Partial Private Sub On换向力Changing(value As String)
    End Sub
    Partial Private Sub On换向力Changed()
    End Sub
    Partial Private Sub On扫条码使能Changing(value As String)
    End Sub
    Partial Private Sub On扫条码使能Changed()
    End Sub
    Partial Private Sub On左反驱力标定Changing(value As String)
    End Sub
    Partial Private Sub On左反驱力标定Changed()
    End Sub
    Partial Private Sub On右反驱力标定Changing(value As String)
    End Sub
    Partial Private Sub On右反驱力标定Changed()
    End Sub
    Partial Private Sub On位移标定Changing(value As String)
    End Sub
    Partial Private Sub On位移标定Changed()
    End Sub
    Partial Private Sub On径向力标定Changing(value As String)
    End Sub
    Partial Private Sub On径向力标定Changed()
    End Sub
    Partial Private Sub On径向间隙标定Changing(value As String)
    End Sub
    Partial Private Sub On径向间隙标定Changed()
    End Sub
    Partial Private Sub On零点偏置Changing(value As String)
    End Sub
    Partial Private Sub On零点偏置Changed()
    End Sub
    Partial Private Sub On左反驱力调整Changing(value As String)
    End Sub
    Partial Private Sub On左反驱力调整Changed()
    End Sub
    Partial Private Sub On右反驱力调整Changing(value As String)
    End Sub
    Partial Private Sub On右反驱力调整Changed()
    End Sub
    Partial Private Sub On最大换向力Changing(value As String)
    End Sub
    Partial Private Sub On最大换向力Changed()
    End Sub
    Partial Private Sub On有效测试位移百分比Changing(value As String)
    End Sub
    Partial Private Sub On有效测试位移百分比Changed()
    End Sub
    Partial Private Sub On反驱力调整系数Changing(value As String)
    End Sub
    Partial Private Sub On反驱力调整系数Changed()
    End Sub
    Partial Private Sub On间隙检测调整系数Changing(value As String)
    End Sub
    Partial Private Sub On间隙检测调整系数Changed()
    End Sub
    Partial Private Sub On零位判断基准电压Changing(value As String)
    End Sub
    Partial Private Sub On零位判断基准电压Changed()
    End Sub
    Partial Private Sub On间隙检测位置Changing(value As String)
    End Sub
    Partial Private Sub On间隙检测位置Changed()
    End Sub
    Partial Private Sub On左右平均力差值上限Changing(value As String)
    End Sub
    Partial Private Sub On左右平均力差值上限Changed()
    End Sub
    Partial Private Sub On左右平均力差值下限Changing(value As String)
    End Sub
    Partial Private Sub On左右平均力差值下限Changed()
    End Sub
    Partial Private Sub On间隙下拉力补偿参数Changing(value As String)
    End Sub
    Partial Private Sub On间隙下拉力补偿参数Changed()
    End Sub
    Partial Private Sub On间隙上拉力补偿参数Changing(value As String)
    End Sub
    Partial Private Sub On间隙上拉力补偿参数Changed()
    End Sub
    Partial Private Sub On下拉间隙补偿参数Changing(value As String)
    End Sub
    Partial Private Sub On下拉间隙补偿参数Changed()
    End Sub
    Partial Private Sub On上拉间隙补偿参数Changing(value As String)
    End Sub
    Partial Private Sub On上拉间隙补偿参数Changed()
    End Sub
    Partial Private Sub On超时设置Changing(value As String)
    End Sub
    Partial Private Sub On超时设置Changed()
    End Sub
    Partial Private Sub On回中补偿电压Changing(value As String)
    End Sub
    Partial Private Sub On回中补偿电压Changed()
    End Sub
    Partial Private Sub On图像滤波百分比Changing(value As String)
    End Sub
    Partial Private Sub On图像滤波百分比Changed()
    End Sub
    Partial Private Sub On阈值补偿Changing(value As String)
    End Sub
    Partial Private Sub On阈值补偿Changed()
    End Sub
    Partial Private Sub On是否滤波Changing(value As String)
    End Sub
    Partial Private Sub On是否滤波Changed()
    End Sub
    Partial Private Sub On量化点数Changing(value As String)
    End Sub
    Partial Private Sub On量化点数Changed()
    End Sub
    Partial Private Sub On中位记号笔使能Changing(value As String)
    End Sub
    Partial Private Sub On中位记号笔使能Changed()
    End Sub
    Partial Private Sub On右反驱位移补偿参数Changing(value As String)
    End Sub
    Partial Private Sub On右反驱位移补偿参数Changed()
    End Sub
    Partial Private Sub On左反驱位移补偿参数Changing(value As String)
    End Sub
    Partial Private Sub On左反驱位移补偿参数Changed()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_工件类别", DbType:="NVarChar(255) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property 工件类别() As String
		Get
			Return Me._工件类别
		End Get
		Set
			If (String.Equals(Me._工件类别, value) = false) Then
				Me.On工件类别Changing(value)
				Me.SendPropertyChanging
				Me._工件类别 = value
				Me.SendPropertyChanged("工件类别")
				Me.On工件类别Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱力最大值上限", DbType:="NVarChar(255)")>  _
	Public Property 反驱力最大值上限() As String
		Get
			Return Me._反驱力最大值上限
		End Get
		Set
			If (String.Equals(Me._反驱力最大值上限, value) = false) Then
				Me.On反驱力最大值上限Changing(value)
				Me.SendPropertyChanging
				Me._反驱力最大值上限 = value
				Me.SendPropertyChanged("反驱力最大值上限")
				Me.On反驱力最大值上限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱力最大值下限", DbType:="NVarChar(255)")>  _
	Public Property 反驱力最大值下限() As String
		Get
			Return Me._反驱力最大值下限
		End Get
		Set
			If (String.Equals(Me._反驱力最大值下限, value) = false) Then
				Me.On反驱力最大值下限Changing(value)
				Me.SendPropertyChanging
				Me._反驱力最大值下限 = value
				Me.SendPropertyChanged("反驱力最大值下限")
				Me.On反驱力最大值下限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱力最小值上限", DbType:="NVarChar(255)")>  _
	Public Property 反驱力最小值上限() As String
		Get
			Return Me._反驱力最小值上限
		End Get
		Set
			If (String.Equals(Me._反驱力最小值上限, value) = false) Then
				Me.On反驱力最小值上限Changing(value)
				Me.SendPropertyChanging
				Me._反驱力最小值上限 = value
				Me.SendPropertyChanged("反驱力最小值上限")
				Me.On反驱力最小值上限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱力最小值下限", DbType:="NVarChar(255)")>  _
	Public Property 反驱力最小值下限() As String
		Get
			Return Me._反驱力最小值下限
		End Get
		Set
			If (String.Equals(Me._反驱力最小值下限, value) = false) Then
				Me.On反驱力最小值下限Changing(value)
				Me.SendPropertyChanging
				Me._反驱力最小值下限 = value
				Me.SendPropertyChanged("反驱力最小值下限")
				Me.On反驱力最小值下限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱力波动量上限", DbType:="NVarChar(255)")>  _
	Public Property 反驱力波动量上限() As String
		Get
			Return Me._反驱力波动量上限
		End Get
		Set
			If (String.Equals(Me._反驱力波动量上限, value) = false) Then
				Me.On反驱力波动量上限Changing(value)
				Me.SendPropertyChanging
				Me._反驱力波动量上限 = value
				Me.SendPropertyChanged("反驱力波动量上限")
				Me.On反驱力波动量上限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱力波动量下限", DbType:="NVarChar(255)")>  _
	Public Property 反驱力波动量下限() As String
		Get
			Return Me._反驱力波动量下限
		End Get
		Set
			If (String.Equals(Me._反驱力波动量下限, value) = false) Then
				Me.On反驱力波动量下限Changing(value)
				Me.SendPropertyChanging
				Me._反驱力波动量下限 = value
				Me.SendPropertyChanged("反驱力波动量下限")
				Me.On反驱力波动量下限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱力平均值上限", DbType:="NVarChar(255)")>  _
	Public Property 反驱力平均值上限() As String
		Get
			Return Me._反驱力平均值上限
		End Get
		Set
			If (String.Equals(Me._反驱力平均值上限, value) = false) Then
				Me.On反驱力平均值上限Changing(value)
				Me.SendPropertyChanging
				Me._反驱力平均值上限 = value
				Me.SendPropertyChanged("反驱力平均值上限")
				Me.On反驱力平均值上限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱力平均值下限", DbType:="NVarChar(255)")>  _
	Public Property 反驱力平均值下限() As String
		Get
			Return Me._反驱力平均值下限
		End Get
		Set
			If (String.Equals(Me._反驱力平均值下限, value) = false) Then
				Me.On反驱力平均值下限Changing(value)
				Me.SendPropertyChanging
				Me._反驱力平均值下限 = value
				Me.SendPropertyChanged("反驱力平均值下限")
				Me.On反驱力平均值下限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左右波动量差值上限", DbType:="NVarChar(255)")>  _
	Public Property 左右波动量差值上限() As String
		Get
			Return Me._左右波动量差值上限
		End Get
		Set
			If (String.Equals(Me._左右波动量差值上限, value) = false) Then
				Me.On左右波动量差值上限Changing(value)
				Me.SendPropertyChanging
				Me._左右波动量差值上限 = value
				Me.SendPropertyChanged("左右波动量差值上限")
				Me.On左右波动量差值上限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左右波动量差值下限", DbType:="NVarChar(255)")>  _
	Public Property 左右波动量差值下限() As String
		Get
			Return Me._左右波动量差值下限
		End Get
		Set
			If (String.Equals(Me._左右波动量差值下限, value) = false) Then
				Me.On左右波动量差值下限Changing(value)
				Me.SendPropertyChanging
				Me._左右波动量差值下限 = value
				Me.SendPropertyChanged("左右波动量差值下限")
				Me.On左右波动量差值下限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱动位移上限", DbType:="NVarChar(255)")>  _
	Public Property 反驱动位移上限() As String
		Get
			Return Me._反驱动位移上限
		End Get
		Set
			If (String.Equals(Me._反驱动位移上限, value) = false) Then
				Me.On反驱动位移上限Changing(value)
				Me.SendPropertyChanging
				Me._反驱动位移上限 = value
				Me.SendPropertyChanged("反驱动位移上限")
				Me.On反驱动位移上限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱动位移下限", DbType:="NVarChar(255)")>  _
	Public Property 反驱动位移下限() As String
		Get
			Return Me._反驱动位移下限
		End Get
		Set
			If (String.Equals(Me._反驱动位移下限, value) = false) Then
				Me.On反驱动位移下限Changing(value)
				Me.SendPropertyChanging
				Me._反驱动位移下限 = value
				Me.SendPropertyChanged("反驱动位移下限")
				Me.On反驱动位移下限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_齿条径向间隙上限", DbType:="NVarChar(255)")>  _
	Public Property 齿条径向间隙上限() As String
		Get
			Return Me._齿条径向间隙上限
		End Get
		Set
			If (String.Equals(Me._齿条径向间隙上限, value) = false) Then
				Me.On齿条径向间隙上限Changing(value)
				Me.SendPropertyChanging
				Me._齿条径向间隙上限 = value
				Me.SendPropertyChanged("齿条径向间隙上限")
				Me.On齿条径向间隙上限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_齿条径向间隙下限", DbType:="NVarChar(255)")>  _
	Public Property 齿条径向间隙下限() As String
		Get
			Return Me._齿条径向间隙下限
		End Get
		Set
			If (String.Equals(Me._齿条径向间隙下限, value) = false) Then
				Me.On齿条径向间隙下限Changing(value)
				Me.SendPropertyChanging
				Me._齿条径向间隙下限 = value
				Me.SendPropertyChanged("齿条径向间隙下限")
				Me.On齿条径向间隙下限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_齿条径向力上限", DbType:="NVarChar(255)")>  _
	Public Property 齿条径向力上限() As String
		Get
			Return Me._齿条径向力上限
		End Get
		Set
			If (String.Equals(Me._齿条径向力上限, value) = false) Then
				Me.On齿条径向力上限Changing(value)
				Me.SendPropertyChanging
				Me._齿条径向力上限 = value
				Me.SendPropertyChanged("齿条径向力上限")
				Me.On齿条径向力上限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_齿条径向力下限", DbType:="NVarChar(255)")>  _
	Public Property 齿条径向力下限() As String
		Get
			Return Me._齿条径向力下限
		End Get
		Set
			If (String.Equals(Me._齿条径向力下限, value) = false) Then
				Me.On齿条径向力下限Changing(value)
				Me.SendPropertyChanging
				Me._齿条径向力下限 = value
				Me.SendPropertyChanged("齿条径向力下限")
				Me.On齿条径向力下限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_间隙检测抽检间隔", DbType:="NVarChar(255)")>  _
	Public Property 间隙检测抽检间隔() As String
		Get
			Return Me._间隙检测抽检间隔
		End Get
		Set
			If (String.Equals(Me._间隙检测抽检间隔, value) = false) Then
				Me.On间隙检测抽检间隔Changing(value)
				Me.SendPropertyChanging
				Me._间隙检测抽检间隔 = value
				Me.SendPropertyChanged("间隙检测抽检间隔")
				Me.On间隙检测抽检间隔Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_测试速度", DbType:="NVarChar(255)")>  _
	Public Property 测试速度() As String
		Get
			Return Me._测试速度
		End Get
		Set
			If (String.Equals(Me._测试速度, value) = false) Then
				Me.On测试速度Changing(value)
				Me.SendPropertyChanging
				Me._测试速度 = value
				Me.SendPropertyChanged("测试速度")
				Me.On测试速度Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_换向力", DbType:="NVarChar(255)")>  _
	Public Property 换向力() As String
		Get
			Return Me._换向力
		End Get
		Set
			If (String.Equals(Me._换向力, value) = false) Then
				Me.On换向力Changing(value)
				Me.SendPropertyChanging
				Me._换向力 = value
				Me.SendPropertyChanged("换向力")
				Me.On换向力Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_扫条码使能", DbType:="NVarChar(255)")>  _
	Public Property 扫条码使能() As String
		Get
			Return Me._扫条码使能
		End Get
		Set
			If (String.Equals(Me._扫条码使能, value) = false) Then
				Me.On扫条码使能Changing(value)
				Me.SendPropertyChanging
				Me._扫条码使能 = value
				Me.SendPropertyChanged("扫条码使能")
				Me.On扫条码使能Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左反驱力标定", DbType:="NVarChar(255)")>  _
	Public Property 左反驱力标定() As String
		Get
			Return Me._左反驱力标定
		End Get
		Set
			If (String.Equals(Me._左反驱力标定, value) = false) Then
				Me.On左反驱力标定Changing(value)
				Me.SendPropertyChanging
				Me._左反驱力标定 = value
				Me.SendPropertyChanged("左反驱力标定")
				Me.On左反驱力标定Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_右反驱力标定", DbType:="NVarChar(255)")>  _
	Public Property 右反驱力标定() As String
		Get
			Return Me._右反驱力标定
		End Get
		Set
			If (String.Equals(Me._右反驱力标定, value) = false) Then
				Me.On右反驱力标定Changing(value)
				Me.SendPropertyChanging
				Me._右反驱力标定 = value
				Me.SendPropertyChanged("右反驱力标定")
				Me.On右反驱力标定Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_位移标定", DbType:="NVarChar(255)")>  _
	Public Property 位移标定() As String
		Get
			Return Me._位移标定
		End Get
		Set
			If (String.Equals(Me._位移标定, value) = false) Then
				Me.On位移标定Changing(value)
				Me.SendPropertyChanging
				Me._位移标定 = value
				Me.SendPropertyChanged("位移标定")
				Me.On位移标定Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_径向力标定", DbType:="NVarChar(255)")>  _
	Public Property 径向力标定() As String
		Get
			Return Me._径向力标定
		End Get
		Set
			If (String.Equals(Me._径向力标定, value) = false) Then
				Me.On径向力标定Changing(value)
				Me.SendPropertyChanging
				Me._径向力标定 = value
				Me.SendPropertyChanged("径向力标定")
				Me.On径向力标定Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_径向间隙标定", DbType:="NVarChar(255)")>  _
	Public Property 径向间隙标定() As String
		Get
			Return Me._径向间隙标定
		End Get
		Set
			If (String.Equals(Me._径向间隙标定, value) = false) Then
				Me.On径向间隙标定Changing(value)
				Me.SendPropertyChanging
				Me._径向间隙标定 = value
				Me.SendPropertyChanged("径向间隙标定")
				Me.On径向间隙标定Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_零点偏置", DbType:="NVarChar(255)")>  _
	Public Property 零点偏置() As String
		Get
			Return Me._零点偏置
		End Get
		Set
			If (String.Equals(Me._零点偏置, value) = false) Then
				Me.On零点偏置Changing(value)
				Me.SendPropertyChanging
				Me._零点偏置 = value
				Me.SendPropertyChanged("零点偏置")
				Me.On零点偏置Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左反驱力调整", DbType:="NVarChar(255)")>  _
	Public Property 左反驱力调整() As String
		Get
			Return Me._左反驱力调整
		End Get
		Set
			If (String.Equals(Me._左反驱力调整, value) = false) Then
				Me.On左反驱力调整Changing(value)
				Me.SendPropertyChanging
				Me._左反驱力调整 = value
				Me.SendPropertyChanged("左反驱力调整")
				Me.On左反驱力调整Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_右反驱力调整", DbType:="NVarChar(255)")>  _
	Public Property 右反驱力调整() As String
		Get
			Return Me._右反驱力调整
		End Get
		Set
			If (String.Equals(Me._右反驱力调整, value) = false) Then
				Me.On右反驱力调整Changing(value)
				Me.SendPropertyChanging
				Me._右反驱力调整 = value
				Me.SendPropertyChanged("右反驱力调整")
				Me.On右反驱力调整Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_最大换向力", DbType:="NVarChar(255)")>  _
	Public Property 最大换向力() As String
		Get
			Return Me._最大换向力
		End Get
		Set
			If (String.Equals(Me._最大换向力, value) = false) Then
				Me.On最大换向力Changing(value)
				Me.SendPropertyChanging
				Me._最大换向力 = value
				Me.SendPropertyChanged("最大换向力")
				Me.On最大换向力Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_有效测试位移百分比", DbType:="NVarChar(255)")>  _
	Public Property 有效测试位移百分比() As String
		Get
			Return Me._有效测试位移百分比
		End Get
		Set
			If (String.Equals(Me._有效测试位移百分比, value) = false) Then
				Me.On有效测试位移百分比Changing(value)
				Me.SendPropertyChanging
				Me._有效测试位移百分比 = value
				Me.SendPropertyChanged("有效测试位移百分比")
				Me.On有效测试位移百分比Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_反驱力调整系数", DbType:="NVarChar(255)")>  _
	Public Property 反驱力调整系数() As String
		Get
			Return Me._反驱力调整系数
		End Get
		Set
			If (String.Equals(Me._反驱力调整系数, value) = false) Then
				Me.On反驱力调整系数Changing(value)
				Me.SendPropertyChanging
				Me._反驱力调整系数 = value
				Me.SendPropertyChanged("反驱力调整系数")
				Me.On反驱力调整系数Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_间隙检测调整系数", DbType:="NVarChar(255)")>  _
	Public Property 间隙检测调整系数() As String
		Get
			Return Me._间隙检测调整系数
		End Get
		Set
			If (String.Equals(Me._间隙检测调整系数, value) = false) Then
				Me.On间隙检测调整系数Changing(value)
				Me.SendPropertyChanging
				Me._间隙检测调整系数 = value
				Me.SendPropertyChanged("间隙检测调整系数")
				Me.On间隙检测调整系数Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_零位判断基准电压", DbType:="NVarChar(255)")>  _
	Public Property 零位判断基准电压() As String
		Get
			Return Me._零位判断基准电压
		End Get
		Set
			If (String.Equals(Me._零位判断基准电压, value) = false) Then
				Me.On零位判断基准电压Changing(value)
				Me.SendPropertyChanging
				Me._零位判断基准电压 = value
				Me.SendPropertyChanged("零位判断基准电压")
				Me.On零位判断基准电压Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_间隙检测位置", DbType:="NVarChar(255)")>  _
	Public Property 间隙检测位置() As String
		Get
			Return Me._间隙检测位置
		End Get
		Set
			If (String.Equals(Me._间隙检测位置, value) = false) Then
				Me.On间隙检测位置Changing(value)
				Me.SendPropertyChanging
				Me._间隙检测位置 = value
				Me.SendPropertyChanged("间隙检测位置")
				Me.On间隙检测位置Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左右平均力差值上限", DbType:="NVarChar(255)")>  _
	Public Property 左右平均力差值上限() As String
		Get
			Return Me._左右平均力差值上限
		End Get
		Set
			If (String.Equals(Me._左右平均力差值上限, value) = false) Then
				Me.On左右平均力差值上限Changing(value)
				Me.SendPropertyChanging
				Me._左右平均力差值上限 = value
				Me.SendPropertyChanged("左右平均力差值上限")
				Me.On左右平均力差值上限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左右平均力差值下限", DbType:="NVarChar(255)")>  _
	Public Property 左右平均力差值下限() As String
		Get
			Return Me._左右平均力差值下限
		End Get
		Set
			If (String.Equals(Me._左右平均力差值下限, value) = false) Then
				Me.On左右平均力差值下限Changing(value)
				Me.SendPropertyChanging
				Me._左右平均力差值下限 = value
				Me.SendPropertyChanged("左右平均力差值下限")
				Me.On左右平均力差值下限Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_间隙下拉力补偿参数", DbType:="NVarChar(255)")>  _
	Public Property 间隙下拉力补偿参数() As String
		Get
			Return Me._间隙下拉力补偿参数
		End Get
		Set
			If (String.Equals(Me._间隙下拉力补偿参数, value) = false) Then
				Me.On间隙下拉力补偿参数Changing(value)
				Me.SendPropertyChanging
				Me._间隙下拉力补偿参数 = value
				Me.SendPropertyChanged("间隙下拉力补偿参数")
				Me.On间隙下拉力补偿参数Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_间隙上拉力补偿参数", DbType:="NVarChar(255)")>  _
	Public Property 间隙上拉力补偿参数() As String
		Get
			Return Me._间隙上拉力补偿参数
		End Get
		Set
			If (String.Equals(Me._间隙上拉力补偿参数, value) = false) Then
				Me.On间隙上拉力补偿参数Changing(value)
				Me.SendPropertyChanging
				Me._间隙上拉力补偿参数 = value
				Me.SendPropertyChanged("间隙上拉力补偿参数")
				Me.On间隙上拉力补偿参数Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_下拉间隙补偿参数", DbType:="NVarChar(255)")>  _
	Public Property 下拉间隙补偿参数() As String
		Get
			Return Me._下拉间隙补偿参数
		End Get
		Set
			If (String.Equals(Me._下拉间隙补偿参数, value) = false) Then
				Me.On下拉间隙补偿参数Changing(value)
				Me.SendPropertyChanging
				Me._下拉间隙补偿参数 = value
				Me.SendPropertyChanged("下拉间隙补偿参数")
				Me.On下拉间隙补偿参数Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_上拉间隙补偿参数", DbType:="NVarChar(255)")>  _
	Public Property 上拉间隙补偿参数() As String
		Get
			Return Me._上拉间隙补偿参数
		End Get
		Set
			If (String.Equals(Me._上拉间隙补偿参数, value) = false) Then
				Me.On上拉间隙补偿参数Changing(value)
				Me.SendPropertyChanging
				Me._上拉间隙补偿参数 = value
				Me.SendPropertyChanged("上拉间隙补偿参数")
				Me.On上拉间隙补偿参数Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_超时设置", DbType:="NVarChar(255)")>  _
	Public Property 超时设置() As String
		Get
			Return Me._超时设置
		End Get
		Set
			If (String.Equals(Me._超时设置, value) = false) Then
				Me.On超时设置Changing(value)
				Me.SendPropertyChanging
				Me._超时设置 = value
				Me.SendPropertyChanged("超时设置")
				Me.On超时设置Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_回中补偿电压", DbType:="NVarChar(255)")>  _
	Public Property 回中补偿电压() As String
		Get
			Return Me._回中补偿电压
		End Get
		Set
			If (String.Equals(Me._回中补偿电压, value) = false) Then
				Me.On回中补偿电压Changing(value)
				Me.SendPropertyChanging
				Me._回中补偿电压 = value
				Me.SendPropertyChanged("回中补偿电压")
				Me.On回中补偿电压Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_图像滤波百分比", DbType:="NVarChar(255)")>  _
	Public Property 图像滤波百分比() As String
		Get
			Return Me._图像滤波百分比
		End Get
		Set
			If (String.Equals(Me._图像滤波百分比, value) = false) Then
				Me.On图像滤波百分比Changing(value)
				Me.SendPropertyChanging
				Me._图像滤波百分比 = value
				Me.SendPropertyChanged("图像滤波百分比")
				Me.On图像滤波百分比Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_阈值补偿", DbType:="NVarChar(255)")>  _
	Public Property 阈值补偿() As String
		Get
			Return Me._阈值补偿
		End Get
		Set
			If (String.Equals(Me._阈值补偿, value) = false) Then
				Me.On阈值补偿Changing(value)
				Me.SendPropertyChanging
				Me._阈值补偿 = value
				Me.SendPropertyChanged("阈值补偿")
				Me.On阈值补偿Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_是否滤波", DbType:="NVarChar(255)")>  _
	Public Property 是否滤波() As String
		Get
			Return Me._是否滤波
		End Get
		Set
			If (String.Equals(Me._是否滤波, value) = false) Then
				Me.On是否滤波Changing(value)
				Me.SendPropertyChanging
				Me._是否滤波 = value
				Me.SendPropertyChanged("是否滤波")
				Me.On是否滤波Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_量化点数", DbType:="NVarChar(255)")>  _
	Public Property 量化点数() As String
		Get
			Return Me._量化点数
		End Get
		Set
			If (String.Equals(Me._量化点数, value) = false) Then
				Me.On量化点数Changing(value)
				Me.SendPropertyChanging
				Me._量化点数 = value
				Me.SendPropertyChanged("量化点数")
				Me.On量化点数Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_中位记号笔使能", DbType:="NVarChar(255)")>  _
	Public Property 中位记号笔使能() As String
		Get
			Return Me._中位记号笔使能
		End Get
		Set
			If (String.Equals(Me._中位记号笔使能, value) = false) Then
				Me.On中位记号笔使能Changing(value)
				Me.SendPropertyChanging
				Me._中位记号笔使能 = value
				Me.SendPropertyChanged("中位记号笔使能")
				Me.On中位记号笔使能Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_右反驱位移补偿参数", DbType:="NVarChar(255)")>  _
	Public Property 右反驱位移补偿参数() As String
		Get
			Return Me._右反驱位移补偿参数
		End Get
		Set
			If (String.Equals(Me._右反驱位移补偿参数, value) = false) Then
				Me.On右反驱位移补偿参数Changing(value)
				Me.SendPropertyChanging
				Me._右反驱位移补偿参数 = value
				Me.SendPropertyChanged("右反驱位移补偿参数")
				Me.On右反驱位移补偿参数Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左反驱位移补偿参数", DbType:="NVarChar(255)")>  _
	Public Property 左反驱位移补偿参数() As String
		Get
			Return Me._左反驱位移补偿参数
		End Get
		Set
			If (String.Equals(Me._左反驱位移补偿参数, value) = false) Then
				Me.On左反驱位移补偿参数Changing(value)
				Me.SendPropertyChanging
				Me._左反驱位移补偿参数 = value
				Me.SendPropertyChanged("左反驱位移补偿参数")
				Me.On左反驱位移补偿参数Changed
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
