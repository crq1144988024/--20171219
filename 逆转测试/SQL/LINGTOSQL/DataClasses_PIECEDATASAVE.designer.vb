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


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="datasave1")>  _
Partial Public Class DataClasses_PIECEDATASAVEDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "可扩展性方法定义"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub Insertpiecedatasave1(instance As piecedatasave1)
    End Sub
  Partial Private Sub Updatepiecedatasave1(instance As piecedatasave1)
    End Sub
  Partial Private Sub Deletepiecedatasave1(instance As piecedatasave1)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.逆转测试.My.MySettings.Default.datasave1ConnectionString, mappingSource)
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
	
	Public ReadOnly Property piecedatasave1() As System.Data.Linq.Table(Of piecedatasave1)
		Get
			Return Me.GetTable(Of piecedatasave1)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.piecedatasave1")>  _
Partial Public Class piecedatasave1
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _编号 As String
	
	Private _日期 As String
	
	Private _工件类别 As String
	
	Private _条码 As String
	
	Private _结果 As String
	
	Private _右反驱力最大值 As String
	
	Private _右反驱力最小值 As String
	
	Private _右反驱力波动量 As String
	
	Private _右反驱力平均值 As String
	
	Private _右反驱动位移 As String
	
	Private _左反驱力最大值 As String
	
	Private _左反驱力最小值 As String
	
	Private _左反驱力波动量 As String
	
	Private _左反驱力平均值 As String
	
	Private _左反驱动位移 As String
	
	Private _左右波动量差值 As String
	
	Private _上拉齿条径向间隙 As String
	
	Private _上拉齿条径向力 As String
	
	Private _下拉齿条径向间隙 As String
	
	Private _下拉齿条径向力 As String
	
	Private _左右反驱力平均值差值 As String
	
    #Region "可扩展性方法定义"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub On编号Changing(value As String)
    End Sub
    Partial Private Sub On编号Changed()
    End Sub
    Partial Private Sub On日期Changing(value As String)
    End Sub
    Partial Private Sub On日期Changed()
    End Sub
    Partial Private Sub On工件类别Changing(value As String)
    End Sub
    Partial Private Sub On工件类别Changed()
    End Sub
    Partial Private Sub On条码Changing(value As String)
    End Sub
    Partial Private Sub On条码Changed()
    End Sub
    Partial Private Sub On结果Changing(value As String)
    End Sub
    Partial Private Sub On结果Changed()
    End Sub
    Partial Private Sub On右反驱力最大值Changing(value As String)
    End Sub
    Partial Private Sub On右反驱力最大值Changed()
    End Sub
    Partial Private Sub On右反驱力最小值Changing(value As String)
    End Sub
    Partial Private Sub On右反驱力最小值Changed()
    End Sub
    Partial Private Sub On右反驱力波动量Changing(value As String)
    End Sub
    Partial Private Sub On右反驱力波动量Changed()
    End Sub
    Partial Private Sub On右反驱力平均值Changing(value As String)
    End Sub
    Partial Private Sub On右反驱力平均值Changed()
    End Sub
    Partial Private Sub On右反驱动位移Changing(value As String)
    End Sub
    Partial Private Sub On右反驱动位移Changed()
    End Sub
    Partial Private Sub On左反驱力最大值Changing(value As String)
    End Sub
    Partial Private Sub On左反驱力最大值Changed()
    End Sub
    Partial Private Sub On左反驱力最小值Changing(value As String)
    End Sub
    Partial Private Sub On左反驱力最小值Changed()
    End Sub
    Partial Private Sub On左反驱力波动量Changing(value As String)
    End Sub
    Partial Private Sub On左反驱力波动量Changed()
    End Sub
    Partial Private Sub On左反驱力平均值Changing(value As String)
    End Sub
    Partial Private Sub On左反驱力平均值Changed()
    End Sub
    Partial Private Sub On左反驱动位移Changing(value As String)
    End Sub
    Partial Private Sub On左反驱动位移Changed()
    End Sub
    Partial Private Sub On左右波动量差值Changing(value As String)
    End Sub
    Partial Private Sub On左右波动量差值Changed()
    End Sub
    Partial Private Sub On上拉齿条径向间隙Changing(value As String)
    End Sub
    Partial Private Sub On上拉齿条径向间隙Changed()
    End Sub
    Partial Private Sub On上拉齿条径向力Changing(value As String)
    End Sub
    Partial Private Sub On上拉齿条径向力Changed()
    End Sub
    Partial Private Sub On下拉齿条径向间隙Changing(value As String)
    End Sub
    Partial Private Sub On下拉齿条径向间隙Changed()
    End Sub
    Partial Private Sub On下拉齿条径向力Changing(value As String)
    End Sub
    Partial Private Sub On下拉齿条径向力Changed()
    End Sub
    Partial Private Sub On左右反驱力平均值差值Changing(value As String)
    End Sub
    Partial Private Sub On左右反驱力平均值差值Changed()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_编号", DbType:="NVarChar(255) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property 编号() As String
		Get
			Return Me._编号
		End Get
		Set
			If (String.Equals(Me._编号, value) = false) Then
				Me.On编号Changing(value)
				Me.SendPropertyChanging
				Me._编号 = value
				Me.SendPropertyChanged("编号")
				Me.On编号Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_日期", DbType:="NVarChar(255)")>  _
	Public Property 日期() As String
		Get
			Return Me._日期
		End Get
		Set
			If (String.Equals(Me._日期, value) = false) Then
				Me.On日期Changing(value)
				Me.SendPropertyChanging
				Me._日期 = value
				Me.SendPropertyChanged("日期")
				Me.On日期Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_工件类别", DbType:="NVarChar(255)")>  _
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
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_条码", DbType:="NVarChar(255)")>  _
	Public Property 条码() As String
		Get
			Return Me._条码
		End Get
		Set
			If (String.Equals(Me._条码, value) = false) Then
				Me.On条码Changing(value)
				Me.SendPropertyChanging
				Me._条码 = value
				Me.SendPropertyChanged("条码")
				Me.On条码Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_结果", DbType:="NVarChar(255)")>  _
	Public Property 结果() As String
		Get
			Return Me._结果
		End Get
		Set
			If (String.Equals(Me._结果, value) = false) Then
				Me.On结果Changing(value)
				Me.SendPropertyChanging
				Me._结果 = value
				Me.SendPropertyChanged("结果")
				Me.On结果Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_右反驱力最大值", DbType:="NVarChar(255)")>  _
	Public Property 右反驱力最大值() As String
		Get
			Return Me._右反驱力最大值
		End Get
		Set
			If (String.Equals(Me._右反驱力最大值, value) = false) Then
				Me.On右反驱力最大值Changing(value)
				Me.SendPropertyChanging
				Me._右反驱力最大值 = value
				Me.SendPropertyChanged("右反驱力最大值")
				Me.On右反驱力最大值Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_右反驱力最小值", DbType:="NVarChar(255)")>  _
	Public Property 右反驱力最小值() As String
		Get
			Return Me._右反驱力最小值
		End Get
		Set
			If (String.Equals(Me._右反驱力最小值, value) = false) Then
				Me.On右反驱力最小值Changing(value)
				Me.SendPropertyChanging
				Me._右反驱力最小值 = value
				Me.SendPropertyChanged("右反驱力最小值")
				Me.On右反驱力最小值Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_右反驱力波动量", DbType:="NVarChar(255)")>  _
	Public Property 右反驱力波动量() As String
		Get
			Return Me._右反驱力波动量
		End Get
		Set
			If (String.Equals(Me._右反驱力波动量, value) = false) Then
				Me.On右反驱力波动量Changing(value)
				Me.SendPropertyChanging
				Me._右反驱力波动量 = value
				Me.SendPropertyChanged("右反驱力波动量")
				Me.On右反驱力波动量Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_右反驱力平均值", DbType:="NVarChar(255)")>  _
	Public Property 右反驱力平均值() As String
		Get
			Return Me._右反驱力平均值
		End Get
		Set
			If (String.Equals(Me._右反驱力平均值, value) = false) Then
				Me.On右反驱力平均值Changing(value)
				Me.SendPropertyChanging
				Me._右反驱力平均值 = value
				Me.SendPropertyChanged("右反驱力平均值")
				Me.On右反驱力平均值Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_右反驱动位移", DbType:="NVarChar(255)")>  _
	Public Property 右反驱动位移() As String
		Get
			Return Me._右反驱动位移
		End Get
		Set
			If (String.Equals(Me._右反驱动位移, value) = false) Then
				Me.On右反驱动位移Changing(value)
				Me.SendPropertyChanging
				Me._右反驱动位移 = value
				Me.SendPropertyChanged("右反驱动位移")
				Me.On右反驱动位移Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左反驱力最大值", DbType:="NVarChar(255)")>  _
	Public Property 左反驱力最大值() As String
		Get
			Return Me._左反驱力最大值
		End Get
		Set
			If (String.Equals(Me._左反驱力最大值, value) = false) Then
				Me.On左反驱力最大值Changing(value)
				Me.SendPropertyChanging
				Me._左反驱力最大值 = value
				Me.SendPropertyChanged("左反驱力最大值")
				Me.On左反驱力最大值Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左反驱力最小值", DbType:="NVarChar(255)")>  _
	Public Property 左反驱力最小值() As String
		Get
			Return Me._左反驱力最小值
		End Get
		Set
			If (String.Equals(Me._左反驱力最小值, value) = false) Then
				Me.On左反驱力最小值Changing(value)
				Me.SendPropertyChanging
				Me._左反驱力最小值 = value
				Me.SendPropertyChanged("左反驱力最小值")
				Me.On左反驱力最小值Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左反驱力波动量", DbType:="NVarChar(255)")>  _
	Public Property 左反驱力波动量() As String
		Get
			Return Me._左反驱力波动量
		End Get
		Set
			If (String.Equals(Me._左反驱力波动量, value) = false) Then
				Me.On左反驱力波动量Changing(value)
				Me.SendPropertyChanging
				Me._左反驱力波动量 = value
				Me.SendPropertyChanged("左反驱力波动量")
				Me.On左反驱力波动量Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左反驱力平均值", DbType:="NVarChar(255)")>  _
	Public Property 左反驱力平均值() As String
		Get
			Return Me._左反驱力平均值
		End Get
		Set
			If (String.Equals(Me._左反驱力平均值, value) = false) Then
				Me.On左反驱力平均值Changing(value)
				Me.SendPropertyChanging
				Me._左反驱力平均值 = value
				Me.SendPropertyChanged("左反驱力平均值")
				Me.On左反驱力平均值Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左反驱动位移", DbType:="NVarChar(255)")>  _
	Public Property 左反驱动位移() As String
		Get
			Return Me._左反驱动位移
		End Get
		Set
			If (String.Equals(Me._左反驱动位移, value) = false) Then
				Me.On左反驱动位移Changing(value)
				Me.SendPropertyChanging
				Me._左反驱动位移 = value
				Me.SendPropertyChanged("左反驱动位移")
				Me.On左反驱动位移Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左右波动量差值", DbType:="NVarChar(255)")>  _
	Public Property 左右波动量差值() As String
		Get
			Return Me._左右波动量差值
		End Get
		Set
			If (String.Equals(Me._左右波动量差值, value) = false) Then
				Me.On左右波动量差值Changing(value)
				Me.SendPropertyChanging
				Me._左右波动量差值 = value
				Me.SendPropertyChanged("左右波动量差值")
				Me.On左右波动量差值Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_上拉齿条径向间隙", DbType:="NVarChar(255)")>  _
	Public Property 上拉齿条径向间隙() As String
		Get
			Return Me._上拉齿条径向间隙
		End Get
		Set
			If (String.Equals(Me._上拉齿条径向间隙, value) = false) Then
				Me.On上拉齿条径向间隙Changing(value)
				Me.SendPropertyChanging
				Me._上拉齿条径向间隙 = value
				Me.SendPropertyChanged("上拉齿条径向间隙")
				Me.On上拉齿条径向间隙Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_上拉齿条径向力", DbType:="NVarChar(255)")>  _
	Public Property 上拉齿条径向力() As String
		Get
			Return Me._上拉齿条径向力
		End Get
		Set
			If (String.Equals(Me._上拉齿条径向力, value) = false) Then
				Me.On上拉齿条径向力Changing(value)
				Me.SendPropertyChanging
				Me._上拉齿条径向力 = value
				Me.SendPropertyChanged("上拉齿条径向力")
				Me.On上拉齿条径向力Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_下拉齿条径向间隙", DbType:="NVarChar(255)")>  _
	Public Property 下拉齿条径向间隙() As String
		Get
			Return Me._下拉齿条径向间隙
		End Get
		Set
			If (String.Equals(Me._下拉齿条径向间隙, value) = false) Then
				Me.On下拉齿条径向间隙Changing(value)
				Me.SendPropertyChanging
				Me._下拉齿条径向间隙 = value
				Me.SendPropertyChanged("下拉齿条径向间隙")
				Me.On下拉齿条径向间隙Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_下拉齿条径向力", DbType:="NVarChar(255)")>  _
	Public Property 下拉齿条径向力() As String
		Get
			Return Me._下拉齿条径向力
		End Get
		Set
			If (String.Equals(Me._下拉齿条径向力, value) = false) Then
				Me.On下拉齿条径向力Changing(value)
				Me.SendPropertyChanging
				Me._下拉齿条径向力 = value
				Me.SendPropertyChanged("下拉齿条径向力")
				Me.On下拉齿条径向力Changed
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_左右反驱力平均值差值", DbType:="NVarChar(255)")>  _
	Public Property 左右反驱力平均值差值() As String
		Get
			Return Me._左右反驱力平均值差值
		End Get
		Set
			If (String.Equals(Me._左右反驱力平均值差值, value) = false) Then
				Me.On左右反驱力平均值差值Changing(value)
				Me.SendPropertyChanging
				Me._左右反驱力平均值差值 = value
				Me.SendPropertyChanged("左右反驱力平均值差值")
				Me.On左右反驱力平均值差值Changed
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
