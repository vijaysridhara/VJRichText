'***********************************************************************
'Copyright 2005-2022 Vijay Sridhara

'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at

'http://www.apache.org/licenses/LICENSE-2.0

'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
'***********************************************************************
Public Class Find
    Private msgLog As New List(Of String)
    Private vjrc As RichTextPlus
    Friend Property FindTextCollection() As List(Of String)
        Get
            Return msgLog
        End Get
        Set(ByVal value As List(Of String))
            msgLog = Nothing
            msgLog = value
            AddValues()
        End Set
    End Property


    Friend Overloads Sub Show(ByVal txt As String, ByVal w As Boolean, ByVal m As Boolean, ByVal drev As Boolean, ByRef ctrl As RichTextPlus, ByVal ownner As Windows.Forms.IWin32Window)
        cboFind.Text = txt
        chkWholeword.Checked = w
        chkMatchcase.Checked = m
        rbtUp.Checked = drev
        If txt = "" Then
            If msgLog.Count > 0 Then
                cboFind.Text = msgLog(msgLog.Count - 1)
            End If
        End If
        vjrc = ctrl
        Me.Show(ctrl)
    End Sub


    Friend Sub ClearFindCollection()
        msgLog.Clear()
        cboFind.Items.Clear()
    End Sub
    Private Sub AddValues()
        cboFind.Items.Clear()
        For i As Integer = 0 To msgLog.Count - 1
            cboFind.Items.Add(msgLog(i))
        Next
    End Sub


    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        On Error Resume Next
        If cboFind.Text.Trim <> "" Then
            msgLog.Add(cboFind.Text)
        End If

        vjrc.FindText(cboFind.Text, chkWholeword.Checked, chkMatchcase.Checked, rbtUp.Checked)
    End Sub

    Private Sub Find_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If msgLog.Count > 0 Then
            cboFind.Text = msgLog(msgLog.Count)
            cboFind.SelectAll()
        End If

    End Sub

    Private Sub butCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancel.Click
        Me.Hide()
    End Sub
End Class