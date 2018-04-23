Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data

Namespace EmptyWinApp
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.productReportsTableAdapter.Fill(Me.productReports._ProductReports)
		End Sub
		Private ReadOnly dummyItem As Object = New Object()
		Private Sub pivotGridControl1_CustomFilterPopupItems(ByVal sender As Object, _
					ByVal e As PivotCustomFilterPopupItemsEventArgs) _
					Handles pivotGridControl1.CustomFilterPopupItems
			If Object.ReferenceEquals(e.Field, fieldCategoryName) Then
				For i As Integer = e.Items.Count - 1 To 0 Step -1
					If Object.Equals(e.Items(i).Value, "Beverages") Then
						e.Items.RemoveAt(i)
						Exit For
					End If
				Next i
				e.Items.Insert(0, New PivotGridFilterItem(dummyItem, _
								"Dummy Item", _
								e.Field.FilterValues.Contains(dummyItem)))
			End If
		End Sub
	End Class
End Namespace