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
Imports System.Windows.Forms

Public Class RichTextPlus
    Private Bold As Boolean
    Private Italic As Boolean
    Private FSize As Integer
    Private Underline As Boolean
    Private CurrentFont As String
    Private CurrentForeColor As System.Drawing.Color
    Private CurrentBackColor As System.Drawing.Color
    Private SBold As Boolean
    Private SItalic As Boolean
    Private SFSize As Integer
    Private SUnderline As Boolean
    Private SFont As String
    Private def_Font = "Verdana"
    Private def_Size = 10
    Private SelectedForeColor As System.Drawing.Color
    Private SelectedBackColor As System.Drawing.Color
    Private isSetting As Boolean
    Event EditOutsideClicked(ByVal sender As RichTextPlus, ByVal e As EventArgs)
    Event Exceptionraised(ByVal sender As RichTextPlus, ByVal e As Exception)
    Private findtxt As String, whw As Boolean, mtch As Boolean
    Event OpenClicked(ByVal sender As Object, ByVal e As EventArgs)
    Event SaveClicked(ByVal sender As Object, ByVal e As EventArgs)
    Private fnd As New Find
    Private rep As New Replace
    Private fndDirRev As Boolean
    Private curpos As Integer
    Private schOpt As Windows.Forms.RichTextBoxFinds
    Private findran As Boolean
    Event AcceptsTabChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event BorderStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event CausesValidationChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs)
    Shadows Event Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Event ContentsResized(ByVal sender As Object, ByVal e As System.Windows.Forms.ContentsResizedEventArgs)
    Shadows Event ContextMenuChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event ContextMenuStripChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs)
    Shadows Event ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs)
    Shadows Event CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event Disposed(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
    Shadows Event DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
    Shadows Event EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event Enter(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event FontChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs)
    Event HideSelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event HScroll(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event ImeChange(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event ImeModeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs)
    Shadows Event KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Shadows Event KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    Shadows Event KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    Shadows Event Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs)
    Shadows Event Leave(ByVal sender As Object, ByVal e As System.EventArgs)
    Event LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs)
    Shadows Event LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event MarginChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Shadows Event MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Shadows Event MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Shadows Event MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Shadows Event MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Shadows Event MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
    Shadows Event Move(ByVal sender As Object, ByVal e As System.EventArgs)
    Event MultilineChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    'Shadows Event ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Event ProtectedEx(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event QueryAccessibilityHelp(ByVal sender As Object, ByVal e As System.Windows.Forms.QueryAccessibilityHelpEventArgs)
    Event ReadOnlyChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    'Shadows Event Resize(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Event SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event SystemColorsChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event TabStopChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event Validated(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
    'Shadows Event VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Shadows Event VScroll(ByVal sender As Object, ByVal e As System.EventArgs)
   
   
    Public Property ShowFind() As Boolean
        Get
            Return butFind.Visible
        End Get
        Set(ByVal value As Boolean)
            butFind.Visible = value
        End Set
    End Property
    Public Property ShowReplace() As Boolean
        Get
            Return butFindReplace.Visible
        End Get
        Set(ByVal value As Boolean)
            butFindReplace.Visible = value
        End Set
    End Property
    Public Function FindText(ByVal txt As String, ByVal wh As Boolean, ByVal mth As Boolean, ByVal dirRev As Boolean) As Integer
        If findtxt = txt And ra.SelectedText = txt Then
            If dirRev Then
                If ra.SelectionStart > 0 Then
                    curpos = ra.SelectionStart - 1
                Else
                    curpos = ra.SelectionStart
                End If
            Else
                If ra.SelectionStart < Len(ra.Text) And ra.SelectionStart > -1 Then
                    curpos = ra.SelectionStart + 1
                Else
                    curpos = ra.SelectionStart
                End If
            End If
        Else
            curpos = ra.SelectionStart
        End If
        findtxt = txt : whw = wh : mtch = mth : fndDirRev = dirRev
        'Dim opt As Windows.Forms.RichTextBoxFinds
        If whw And mtch And dirRev Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase Or Windows.Forms.RichTextBoxFinds.WholeWord Or Windows.Forms.RichTextBoxFinds.Reverse
        ElseIf whw And dirRev Then
            schOpt = Windows.Forms.RichTextBoxFinds.WholeWord Or Windows.Forms.RichTextBoxFinds.Reverse
        ElseIf mtch And dirRev Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase Or Windows.Forms.RichTextBoxFinds.Reverse
        ElseIf whw And mtch Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase Or Windows.Forms.RichTextBoxFinds.WholeWord
        ElseIf whw Then
            schOpt = Windows.Forms.RichTextBoxFinds.WholeWord
        ElseIf mtch Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase
        ElseIf dirRev Then
            schOpt = Windows.Forms.RichTextBoxFinds.Reverse
        Else
            schOpt = Windows.Forms.RichTextBoxFinds.None
        End If
        curpos = ra.Find(findtxt, curpos, schOpt)
        Return curpos
    End Function
    Public Function ReplaceAll(ByVal txt As String, ByVal repltxt As String, ByVal wh As Boolean, ByVal mth As Boolean) As Integer
        findtxt = txt : whw = wh : mtch = mth
        curpos = 0
        Dim cnt As Integer
        If whw And mtch Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase Or Windows.Forms.RichTextBoxFinds.WholeWord
        ElseIf whw Then
            schOpt = Windows.Forms.RichTextBoxFinds.WholeWord
        ElseIf mtch Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase
        Else
            schOpt = Windows.Forms.RichTextBoxFinds.None
        End If
        curpos = ra.Find(findtxt, curpos, schOpt)
        While curpos > -1
            ra.SelectedText = repltxt
            cnt = cnt + 1
            curpos = ra.Find(findtxt, curpos, schOpt)
        End While
        Return cnt
    End Function
    Public Function ReplaceText(ByVal txt As String, ByVal repltxt As String, ByVal wh As Boolean, ByVal mth As Boolean, ByVal dirRev As Boolean) As Integer
        findtxt = txt : whw = wh : mtch = mth : fndDirRev = dirRev
        If whw And mtch And dirRev Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase Or Windows.Forms.RichTextBoxFinds.WholeWord Or Windows.Forms.RichTextBoxFinds.Reverse
        ElseIf whw And dirRev Then
            schOpt = Windows.Forms.RichTextBoxFinds.WholeWord Or Windows.Forms.RichTextBoxFinds.Reverse
        ElseIf mtch And dirRev Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase Or Windows.Forms.RichTextBoxFinds.Reverse
        ElseIf whw And mtch Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase Or Windows.Forms.RichTextBoxFinds.WholeWord
        ElseIf whw Then
            schOpt = Windows.Forms.RichTextBoxFinds.WholeWord
        ElseIf mtch Then
            schOpt = Windows.Forms.RichTextBoxFinds.MatchCase
        ElseIf dirRev Then
            schOpt = Windows.Forms.RichTextBoxFinds.Reverse
        Else
            schOpt = Windows.Forms.RichTextBoxFinds.None
        End If
        curpos = ra.Find(findtxt, curpos, schOpt)
        If curpos > -1 Then
            ra.SelectedText = repltxt
            curpos = ra.SelectionStart
        End If
        FindText(txt, wh, mth, fndDirRev)
    End Function
    Public Sub FindNext()
        If findtxt <> "" Then
            If ra.SelectedText.Length > 0 Then
                curpos = ra.SelectionStart + 1
                ra.Find(findtxt, curpos, schOpt)
            Else

                curpos = ra.SelectionStart
                ra.Find(findtxt, curpos, schOpt)
            End If
        End If
    End Sub
    Public Overloads Property BackColor() As System.Drawing.Color
        Get
            Return ra.BackColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            ra.BackColor = value
        End Set
    End Property
    Public Overloads Property BorderStyle() As Windows.Forms.BorderStyle
        Get
            Return ra.BorderStyle
        End Get
        Set(ByVal value As Windows.Forms.BorderStyle)
            ra.BorderStyle = value
        End Set
    End Property
    Public Overloads Property ForeColor() As System.Drawing.Color
        Get
            Return ra.ForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            ra.ForeColor = value
        End Set
    End Property
    'Public Sub x()
    '    ra.AppendText (text as string)
    '    ra.BeginInvoke (method as delegate)
    '    ra.BeginInvoke (method as system.delegate,ParamArr args() as object)
    '    ra.CanPaste(clipFormat as system.windows.forms.dataformats.format) as boolean
    '    ra.ClearUndo()
    '    ra.Contains (ctl as system.windows.forms.control) as boolean
    '    ra.Copy()
    '    ra.CreateControl()
    '    ra.CreateGraphics as system.drawing.graphics
    '    ra.CreateObjRef requestedType as system.type) as system.runtime.remoting.objref
    '    ra.Cut()
    '    ra.DeselectAll()
    '    ra.DoDragDrop (data as object,allowedEffects as windows.forms.dragDropEffect)as windows.forms.dragdropeffects
    '    ra.DrawToBitmap(bitmap as drawing.Bitmap,targetBounds as System.drawing.rectangle)
    '    ra.EndInvoke (asyncResult as System.iAsyncResult) as object
    '    ra.Find (str as STring) as integer
    '    ra.Find(str as STring,options as System.Windows.Forms.RichTextBoxFinds) as integer 
    '    ra.Find(str as STring,start as Integer,options as System.Windows.Forms.RichTextBoxFinds) as integer
    '    ra.Find(str as STring,start as Integer,en as integer, as options as System.Windows.Forms.RichTextBoxFinds) as integer
    '    ra.Find(characterSet() as char) as integer
    '    ra.Find(characterSet() as char,start as integer) as integer
    '    ra.Find(characterSet() as char,start as integer,en as integer) integer
    '    ra.FindForm as system.windows.forms.form
    '    ra.Focus as boolean
    '    ra.GetCharFromPosition(pt system.drawing.Point) as char
    '    ra.GetCharIndexFromPosition(pt as System.Drawing.point) as integer
    '    ra.GetChildAtPoint(pt as System.drawing.point,skipValue as system.windows.from.GetChildpointSkip) as windows.forms.control
    '    ra.GetContainerControl() as Windows.Forms.IContainerControl
    '    ra.GetFirstCharIndexFromLine(lineNumber as inter) as integer
    '    ra.GetFirstCharIndexOfCurrentLine () as integer
    '    ra.GetHashCode () as integer 
    '    ra.GetLifetimeService() as object
    '    ra.GetLineFromCharIndex(index as Integer) as integer
    '    ra.GetPositionFromCharIndex(index as Integer) as system.drawing.point
    '    ra.LoadFile (path as STring)
    '    ra.LoadFile(path as string,fileType as Windows.forms.richtextboxstreamtype)
    '    ra.LoadFile(data as System.io.stream,filetype as windows.forms.richtextboxstreamtype)
    '    ra.Paste()
    '    ra.Paste (clipFormat as window.forms.dataformats.format)
    '    ra.Redo()
    '    ra.Refresh()
    '    ra.ResetText()
    '    ra.SaveFile(path as string)
    '    ra.SaveFile(path as string,filType as system.windows.forms.richtextboxstreamtype)
    '    ra.SaveFile(data as system.io.stream,filetype as system.windows.forms.richtextboxstreamtype)
    '    ra.ScrollToCaret()
    '    ra.scro()
    'End Sub
    Public Overloads Property Font() As System.Drawing.Font
        Get
            Return ra.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            ra.Font = value
            cboFonts.Text = value.FontFamily.Name
            cboSize.Text = Int(value.SizeInPoints)
        End Set
    End Property
    Public ReadOnly Property RichArea() As RichTextBox
        Get
            Return ra
        End Get
    End Property
    Public Property AutoWordSelection() As Boolean
        Get
            Return ra.AutoWordSelection
        End Get
        Set(ByVal value As Boolean)
            ra.AutoWordSelection = value
        End Set
    End Property
    Public Property BulletIndent() As Integer
        Get
            Return ra.BulletIndent
        End Get
        Set(ByVal value As Integer)
            ra.BulletIndent = value
        End Set
    End Property
    Public Overloads Property CausesValidation() As Boolean
        Get
            Return ra.CausesValidation
        End Get
        Set(ByVal value As Boolean)
            ra.CausesValidation = value
        End Set
    End Property
    Public Shadows Property ContextMenuStrip() As Windows.Forms.ContextMenuStrip
        Get
            Return ra.ContextMenuStrip
        End Get
        Set(ByVal value As Windows.Forms.ContextMenuStrip)
            ra.ContextMenuStrip = value
        End Set
    End Property

    Public Overloads Property Cursor() As System.Windows.Forms.Cursor
        Get
            Return ra.Cursor
        End Get
        Set(ByVal value As System.Windows.Forms.Cursor)
            ra.Cursor = value
        End Set
    End Property

    Public Property DetectURLs() As Boolean
        Get
            Return ra.DetectUrls
        End Get
        Set(ByVal value As Boolean)
            ra.DetectUrls = value
        End Set
    End Property
    Public Property EnableDragDrop() As Boolean
        Get
            Return ra.EnableAutoDragDrop
        End Get
        Set(ByVal value As Boolean)
            ra.EnableAutoDragDrop = value
        End Set
    End Property
    Public Property HideSelection() As Boolean
        Get
            Return ra.HideSelection
        End Get
        Set(ByVal value As Boolean)
            ra.HideSelection = value
        End Set
    End Property
    Public Property Lines() As String()
        Get
            Return ra.Lines
        End Get
        Set(ByVal value() As String)
            ra.Lines = value
        End Set
    End Property
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Overloads Property Text() As String
        Get
            Return ra.Text

        End Get
        Set(ByVal value As String)
            On Error Resume Next
            'If value = "---" Then
            'value = MyNull
            ' End If
            ra.Text = value
        End Set
    End Property
    Public Property Rtf() As String
        Get
            Return ra.Rtf
        End Get
        Set(ByVal value As String)
            ra.Rtf = value
        End Set
    End Property
    Public Property MaxLength() As Long
        Get
            Return ra.MaxLength
        End Get
        Set(ByVal value As Long)
            ra.MaxLength = value
        End Set
    End Property
    Public Property MultiLine() As Boolean
        Get
            Return ra.Multiline
        End Get
        Set(ByVal value As Boolean)
            ra.Multiline = value
        End Set
    End Property
    Public Property ReadOnlyEx() As Boolean
        Get
            Return ra.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            ra.ReadOnly = value
        End Set
    End Property
    Public Property RichTextShortcutsEnabled() As Boolean
        Get
            Return ra.RichTextShortcutsEnabled
        End Get
        Set(ByVal value As Boolean)
            ra.RichTextShortcutsEnabled = value
        End Set
    End Property
    Public Property RightMargin() As Integer
        Get
            Return ra.RightMargin
        End Get
        Set(ByVal value As Integer)
            ra.RightMargin = value
        End Set
    End Property
    Public Overloads Property RightToLeft() As Windows.Forms.RightToLeft
        Get
            Return ra.RightToLeft
        End Get
        Set(ByVal value As Windows.Forms.RightToLeft)
            ra.RightToLeft = value
        End Set
    End Property
    Public Overloads Property ScrollBars() As Windows.Forms.RichTextBoxScrollBars
        Get
            Return ra.ScrollBars
        End Get
        Set(ByVal value As Windows.Forms.RichTextBoxScrollBars)
            ra.ScrollBars = value
        End Set
    End Property
    Public Overloads Property ShortCutsEnabled() As Boolean
        Get
            Return ra.ShortcutsEnabled
        End Get
        Set(ByVal value As Boolean)
            ra.ShortcutsEnabled = value
        End Set
    End Property
    Public Property ShowSelectionMargin() As Boolean
        Get
            Return ra.ShowSelectionMargin
        End Get
        Set(ByVal value As Boolean)
            ra.ShowSelectionMargin = value
        End Set
    End Property
    Public Property WordWrap() As Boolean
        Get
            Return ra.WordWrap
        End Get
        Set(ByVal value As Boolean)
            ra.WordWrap = value
        End Set
    End Property
    Public Property ToolbarRenderMode() As Windows.Forms.ToolStripRenderMode
        Get
            Return tlstpRich.RenderMode
        End Get
        Set(ByVal value As Windows.Forms.ToolStripRenderMode)
            tlstpRich.RenderMode = value
        End Set
    End Property
    Public Sub Clear()
        ra.Clear()
    End Sub
    Private Sub RichTxt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        For Each fnt As System.Drawing.FontFamily In System.Drawing.FontFamily.Families
            cboFonts.Items.Add(fnt.Name)
        Next
        For i As Integer = 8 To 72
            cboSize.Items.Add(i)
        Next
        CurrentForeColor = System.Drawing.Color.Black
        CurrentBackColor = System.Drawing.Color.White
        butBackColor.BackColor = CurrentBackColor
        butForeColor.ForeColor = CurrentForeColor
        CurrentFont = def_Font
        FSize = def_Size
        cboFonts.Text = CurrentFont
        cboSize.Text = FSize
    End Sub



    Private Sub cboFonts_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFonts.SelectedIndexChanged
        If ra.SelectedText = "" Then
            SetCurrentFont()
        Else
            SetSelectedFont()
        End If
    End Sub
    Private Function IfEmpty(ByVal check As Object, ByVal assign As Object) As Object
        Dim ret As Object
        ret = ""
        If TypeOf (check) Is String Or TypeOf (check) Is Date Then
            If check = vbNullString Or check Is DBNull.Value Then
                ret = assign
            Else
                ret = check
            End If
        ElseIf TypeOf (check) Is Date Then
        End If
        Return ret
    End Function
    Private Sub SetCurrentFont()
        isSetting = True
        CurrentFont = cboFonts.Text
        FSize = IfEmpty(cboSize.Text, 10)
        Dim fst As System.Drawing.FontStyle
        If Bold Then
            fst = fst Or System.Drawing.FontStyle.Bold
        End If
        If Italic Then
            fst = fst Or System.Drawing.FontStyle.Italic
        End If
        If Underline Then
            fst = fst Or System.Drawing.FontStyle.Underline
        End If
        CurrentForeColor = butForeColor.ForeColor
        CurrentBackColor = butBackColor.BackColor
        Dim fnt As New System.Drawing.Font(CurrentFont, FSize, fst, System.Drawing.GraphicsUnit.Point)
        ra.SelectionBackColor = CurrentBackColor
        ra.SelectionColor = CurrentForeColor
        ra.SelectionFont = fnt
        isSetting = False
    End Sub
    Private Sub SetSelectedFont()
        isSetting = True
        Dim fst As System.Drawing.FontStyle
        If SBold Then
            fst = fst Or System.Drawing.FontStyle.Bold
        End If
        If SItalic Then
            fst = fst Or System.Drawing.FontStyle.Italic
        End If
        If SUnderline Then
            fst = fst Or System.Drawing.FontStyle.Underline
        End If
        SFont = cboFonts.Text
        SFSize = IfEmpty(cboSize.Text, 10)
        SelectedForeColor = butForeColor.ForeColor
        SelectedBackColor = butBackColor.BackColor
        Dim fnt As New System.Drawing.Font(SFont, SFSize, fst, System.Drawing.GraphicsUnit.Point)
        ra.SelectionColor = SelectedForeColor
        ra.SelectionBackColor = SelectedBackColor
        ra.SelectionFont = fnt
        isSetting = False
    End Sub

    Private Sub cboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.SelectedIndexChanged
        If ra.SelectedText = "" Then
            SetCurrentFont()
        Else
            SetSelectedFont()
        End If
    End Sub

    Private Sub butBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butBold.Click
        If ra.SelectedText = "" Then
            Bold = Not Bold
            SetCurrentFont()
        Else
            SBold = Not SBold
            SetSelectedFont()
        End If
    End Sub

    Private Sub butItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butItalic.Click
        If ra.SelectedText = "" Then
            Italic = Not Italic
            SetCurrentFont()
        Else
            SItalic = Not SItalic
            SetSelectedFont()
        End If
    End Sub

    Private Sub butUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butUnderline.Click
        If ra.SelectedText = "" Then
            Underline = Not Underline
            SetCurrentFont()
        Else
            SUnderline = Not SUnderline
            SetSelectedFont()
        End If
    End Sub

    Private Sub butBullets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butBullets.Click
        If ra.SelectedText <> "" Then
            If ra.SelectionBullet = True Then
                ra.SelectionBullet = False
            Else
                ra.SelectionBullet = True
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub GetSelectedFont()
        If isSetting Then Exit Sub
        Dim fnt As System.Drawing.Font
        fnt = ra.SelectionFont
        If fnt Is Nothing Then Exit Sub
        SelectedBackColor = ra.SelectionBackColor
        butBackColor.BackColor = SelectedBackColor
        SelectedForeColor = ra.SelectionColor
        butForeColor.ForeColor = SelectedForeColor
        SBold = fnt.Bold
        SItalic = fnt.Italic
        SFont = fnt.FontFamily.Name
        SUnderline = fnt.Underline
        SFSize = fnt.SizeInPoints
        cboSize.Text = SFSize
        cboFonts.Text = SFont
    End Sub
    Private Sub GetCurrentFont()
        If isSetting Then Exit Sub
        Dim fnt As System.Drawing.Font
        fnt = ra.SelectionFont
        If fnt Is Nothing Then Exit Sub
        CurrentBackColor = ra.SelectionBackColor
        butBackColor.BackColor = CurrentBackColor
        SelectedForeColor = ra.SelectionColor
        butForeColor.ForeColor = SelectedForeColor
        Bold = fnt.Bold
        Italic = fnt.Italic
        Underline = fnt.Underline
        FSize = fnt.SizeInPoints
        cboSize.Text = FSize
        cboFonts.Text = CurrentFont
    End Sub

    Private Sub butForeColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butForeColor.Click
        If ra.SelectedText = "" Then
            CurrentForeColor = butForeColor.ForeColor
            SetCurrentFont()
        Else
            SelectedForeColor = butForeColor.ForeColor
            SetSelectedFont()
        End If
    End Sub

    Private Sub butForeColor_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles butForeColor.DropDownOpening
        cdColor.Color = butForeColor.ForeColor
        If cdColor.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            butForeColor.ForeColor = cdColor.Color
            butForeColor_Click(sender, e)
        End If
    End Sub

    Private Sub butBackColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butBackColor.Click
        If ra.SelectedText = "" Then
            CurrentBackColor = butBackColor.BackColor
            SetCurrentFont()
        Else
            SelectedBackColor = butBackColor.BackColor
            SetSelectedFont()
        End If
    End Sub

    Private Sub ra_AcceptsTabChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.AcceptsTabChanged

    End Sub

    Private Sub ra_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.BackColorChanged
        RaiseEvent BackColorChanged(sender, e)

    End Sub

    Private Sub ra_BindingContextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.BindingContextChanged
        RaiseEvent BindingContextChanged(sender, e)
    End Sub

    Private Sub ra_BorderStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.BorderStyleChanged
        RaiseEvent BorderStyleChanged(sender, e)
    End Sub

    Private Sub ra_CausesValidationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.CausesValidationChanged
        RaiseEvent CausesValidationChanged(sender, e)
    End Sub

    Private Sub ra_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles ra.ChangeUICues
        RaiseEvent ChangeUICues(sender, e)
    End Sub

    Private Sub ra_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.Click
        RaiseEvent Click(sender, e)
    End Sub

    Private Sub ra_ContentsResized(ByVal sender As Object, ByVal e As System.Windows.Forms.ContentsResizedEventArgs) Handles ra.ContentsResized
        RaiseEvent ContentsResized(sender, e)
    End Sub

    Private Sub ra_ContextMenuChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.ContextMenuChanged
        RaiseEvent ContextMenuChanged(sender, e)
    End Sub

    Private Sub ra_ContextMenuStripChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.ContextMenuStripChanged
        RaiseEvent ContextMenuStripChanged(sender, e)
    End Sub

    Private Sub ra_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles ra.ControlAdded
        RaiseEvent ControlAdded(sender, e)
    End Sub

    Private Sub ra_ControlRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles ra.ControlRemoved
        RaiseEvent ControlRemoved(sender, e)
    End Sub

    Private Sub ra_CursorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.CursorChanged
        RaiseEvent CursorChanged(sender, e)
    End Sub

    Private Sub ra_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.Disposed
        RaiseEvent Disposed(sender, e)
    End Sub


    Private Sub ra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.DoubleClick
        RaiseEvent DoubleClick(sender, e)
    End Sub

    Private Sub ra_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ra.DragDrop
        RaiseEvent DragDrop(sender, e)
    End Sub

    Private Sub ra_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ra.DragEnter
        RaiseEvent DragEnter(sender, e)
    End Sub

    Private Sub ra_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.EnabledChanged
        RaiseEvent EnabledChanged(sender, e)
    End Sub

    Private Sub ra_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.Enter
        RaiseEvent Enter(sender, e)
    End Sub

    Private Sub ra_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.FontChanged
        RaiseEvent FontChanged(sender, e)
    End Sub

    Private Sub ra_ForeColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.ForeColorChanged
        RaiseEvent ForeColorChanged(sender, e)
    End Sub

    Private Sub ra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.GotFocus
        RaiseEvent GotFocus(sender, e)
    End Sub

    Private Sub ra_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.HandleCreated
        RaiseEvent HandleCreated(sender, e)
    End Sub

    Private Sub ra_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.HandleDestroyed
        RaiseEvent HandleDestroyed(sender, e)
    End Sub

    Private Sub ra_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles ra.HelpRequested
        RaiseEvent HelpRequested(sender, hlpevent)
    End Sub

    Private Sub ra_HideSelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.HideSelectionChanged
        RaiseEvent HideSelectionChanged(sender, e)
    End Sub

    Private Sub ra_HScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.HScroll
        RaiseEvent HScroll(sender, e)
    End Sub

    Private Sub ra_ImeChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.ImeChange
        RaiseEvent ImeChange(sender, e)
    End Sub

    Private Sub ra_ImeModeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.ImeModeChanged
        RaiseEvent ImeModeChanged(sender, e)
    End Sub

    Private Sub ra_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles ra.Invalidated
        RaiseEvent Invalidated(sender, e)
    End Sub





    Private Sub rtbProject_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ra.KeyDown
        If e.Control = True Then
            Select Case e.KeyCode
                Case System.Windows.Forms.Keys.B
                    butBold_Click(sender, New System.EventArgs)
                Case System.Windows.Forms.Keys.I
                    butItalic_Click(sender, New EventArgs)
                Case System.Windows.Forms.Keys.U
                    butUnderline_Click(sender, New EventArgs)
                Case System.Windows.Forms.Keys.Add
                    If ra.SelectedText = "" Then
                        If FSize < 40 Then FSize = FSize + 1
                        cboSize.Text = FSize
                    Else
                        If SFSize < 40 Then SFSize = SFSize + 1
                        cboSize.Text = SFSize
                    End If
                Case System.Windows.Forms.Keys.Subtract
                    If ra.SelectedText = "" Then
                        If FSize > 8 Then FSize = FSize - 1
                        cboSize.Text = FSize
                    Else
                        If SFSize > 8 Then SFSize = SFSize - 1
                        cboSize.Text = SFSize
                    End If
                Case Windows.Forms.Keys.F
                    fnd.Show(ra.SelectedText, whw, mtch, fndDirRev, Me, Me)
                Case Windows.Forms.Keys.H
                    rep.Show(ra.SelectedText, whw, mtch, fndDirRev, Me, Me)
            End Select
        ElseIf e.KeyCode = Windows.Forms.Keys.F3 Then
            FindNext()
        End If
        RaiseEvent KeyDown(sender, e)
    End Sub

    Private Sub RichArea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ra.KeyPress
        curpos = ra.SelectionStart
        findran = False
        RaiseEvent KeyPress(sender, e)

    End Sub

    Private Sub rtbProject_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ra.KeyUp
        If ra.SelectedText <> "" Then
            GetSelectedFont()
        Else
            GetCurrentFont()
        End If
        RaiseEvent KeyUp(sender, e)
    End Sub

    Private Sub ra_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles ra.Layout
        RaiseEvent Layout(sender, e)
    End Sub

    Private Sub ra_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.Leave
        RaiseEvent Leave(sender, e)
    End Sub

    Private Sub ra_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles ra.LinkClicked
        RaiseEvent LinkClicked(sender, e)
    End Sub

    Private Sub ra_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.LocationChanged
        RaiseEvent LocationChanged(sender, e)
    End Sub

    Private Sub ra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.LostFocus
        RaiseEvent LostFocus(sender, e)
    End Sub

    Private Sub ra_MarginChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.MarginChanged
        RaiseEvent MarginChanged(sender, e)
    End Sub

    Private Sub ra_ModifiedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.ModifiedChanged
        RaiseEvent ModifiedChanged(sender, e)
    End Sub

    Private Sub ra_MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.MouseCaptureChanged
        RaiseEvent MouseCaptureChanged(sender, e)
    End Sub

    Private Sub RichArea_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ra.MouseClick
        curpos = ra.SelectionStart
        RaiseEvent MouseClick(sender, e)
        findran = False
    End Sub

    Private Sub rtbProject_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ra.MouseDoubleClick
        If ra.SelectedText <> "" Then
            GetSelectedFont()
        Else
            GetCurrentFont()
        End If
        RaiseEvent MouseDoubleClick(sender, e)
    End Sub

    Private Sub ra_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ra.MouseDown
        RaiseEvent MouseDown(sender, e)
    End Sub

    Private Sub ra_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.MouseEnter
        RaiseEvent MouseUp(sender, e)
    End Sub

    Private Sub ra_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.MouseHover
        RaiseEvent MouseHover(sender, e)
    End Sub

    Private Sub ra_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.MouseLeave
        RaiseEvent MouseLeave(sender, e)
    End Sub

    Private Sub ra_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ra.MouseMove
        RaiseEvent MouseMove(sender, e)
    End Sub

    Private Sub rtbProject_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ra.MouseUp
        If ra.SelectedText <> "" Then
            GetSelectedFont()
        Else
            GetCurrentFont()
        End If
        RaiseEvent MouseUp(sender, e)
    End Sub

    Private Sub ra_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ra.MouseWheel
        RaiseEvent MouseWheel(sender, e)
    End Sub

    Private Sub ra_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.Move
        RaiseEvent Move(sender, e)
    End Sub

    Private Sub ra_MultilineChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.MultilineChanged
        RaiseEvent MultilineChanged(sender, e)
    End Sub


    Private Sub ra_Protected(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.Protected
        RaiseEvent ProtectedEx(sender, e)
    End Sub

    Private Sub ra_QueryAccessibilityHelp(ByVal sender As Object, ByVal e As System.Windows.Forms.QueryAccessibilityHelpEventArgs) Handles ra.QueryAccessibilityHelp
        RaiseEvent QueryAccessibilityHelp(sender, e)
    End Sub

    Private Sub ra_ReadOnlyChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.ReadOnlyChanged
        RaiseEvent ReadOnlyChanged(sender, e)
    End Sub

    Private Sub ra_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.RegionChanged
        RaiseEvent RegionChanged(sender, e)
    End Sub


    Private Sub ra_RightToLeftChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.RightToLeftChanged
        RaiseEvent RightToLeftChanged(sender, e)
    End Sub

    Private Sub ra_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.SelectionChanged
        RaiseEvent SelectionChanged(sender, e)
    End Sub


    Private Sub ra_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.StyleChanged
        RaiseEvent StyleChanged(sender, e)
    End Sub

    Private Sub ra_SystemColorsChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.SystemColorsChanged
        RaiseEvent SystemColorsChanged(sender, e)
    End Sub

    Private Sub ra_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.TabIndexChanged
        RaiseEvent TabIndexChanged(sender, e)
    End Sub

    Private Sub ra_TabStopChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.TabStopChanged
        RaiseEvent TabStopChanged(sender, e)
    End Sub


    Private Sub rtbProject_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.TextChanged
        If ra.SelectedText <> "" Then
            GetSelectedFont()
        Else
            GetCurrentFont()
        End If
        curpos = ra.SelectionStart
        findran = False
        RaiseEvent TextChanged(sender, e)
    End Sub

    Private Sub butBackColor_DropDownOpening(ByVal sender As Object, ByVal e As System.EventArgs) Handles butBackColor.DropDownOpening
        cdColor.Color = butBackColor.BackColor
        If cdColor.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            butBackColor.BackColor = cdColor.Color
            butBackColor_Click(sender, e)
        End If
    End Sub

    Private Sub butUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butUndo.Click
        If ra.CanUndo Then
            ra.Undo()
        End If
    End Sub

    Private Sub butRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRedo.Click
        If ra.CanRedo Then
            ra.Redo()
        End If
    End Sub
    Public Property ToolBarVisible() As Boolean
        Get
            Return tlstpRich.Visible
        End Get
        Set(ByVal value As Boolean)
            tlstpRich.Visible = value
            cboSize.Visible = value
        End Set
    End Property
    Public Property EditorButton() As Boolean
        Get
            Return butShowinRichEditor.Visible
        End Get
        Set(ByVal value As Boolean)
            butShowinRichEditor.Visible = value
        End Set
    End Property


    Private Sub ctxRich_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ctxRich.Opening
        If ra.CanUndo Then
            UndoToolStripMenuItem.Enabled = True
        Else
            UndoToolStripMenuItem.Enabled = False
        End If
        If ra.CanRedo Then
            RedoToolStripMenuItem.Enabled = True
        Else
            RedoToolStripMenuItem.Enabled = False
        End If


        If ra.SelectedText = "" Then
            CutToolStripMenuItem.Enabled = False
            CopyToolStripMenuItem.Enabled = False
        Else
            CutToolStripMenuItem.Enabled = True
            CopyToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        ra.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        ra.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        System.Windows.Forms.Clipboard.SetText(ra.SelectedRtf, System.Windows.Forms.TextDataFormat.Rtf)
        ra.SelectedRtf = ""


    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        System.Windows.Forms.Clipboard.SetText(ra.SelectedRtf, Windows.Forms.TextDataFormat.Rtf)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        ra.Paste()
    End Sub

    Private Sub SelectallToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectallToolStripMenuItem.Click
        ra.SelectAll()
    End Sub

    Private Sub butOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent OpenClicked(sender, e)


        'Try
        '    With ofdOpen
        '        .Filter = "Word Documents(*.doc)|*.doc|Text files(*.txt)|*.txt|All files(*.*)|*.*"
        '        .InitialDirectory = InitialDirectory
        '        If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
        '            rtbProject.LoadFile(.FileName, Windows.Forms.RichTextBoxStreamType.RichText)
        '        End If
        '    End With
        'Catch ex As Exception
        '    DisplayError(ex)
        'End Try

    End Sub

    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent SaveClicked(sender, e)
        'Try
        '    With sfdSave
        '        .Filter = "Rich text Documents(*.rtf)|*.doc|Text files(*.txt)|*.txt|All files(*.*)|*.*"
        '        .InitialDirectory = InitialDirectory
        '        If .ShowDialog = System.Windows.Forms.DialogResult.OK Then
        '            If .FileName.Substring(Len(.FileName) - 3) = "rtf" Then
        '                rtbProject.SaveFile(.FileName, Windows.Forms.RichTextBoxStreamType.RichText)
        '            ElseIf .FileName.Substring(Len(.FileName) - 3) = "txt" Then
        '                rtbProject.SaveFile(.FileName, Windows.Forms.RichTextBoxStreamType.PlainText)
        '            End If
        '        End If
        '    End With

        'Catch ex As Exception
        '    DisplayError(ex)

        'End Try
    End Sub
    Public Sub DisplayError(ByVal ex As Exception)
        RaiseEvent Exceptionraised(Me, ex)
    End Sub
 

    Private Sub butFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFind.Click
        If rep.Visible Then
            rep.Hide()
        End If
        fnd.Show(ra.SelectedText, whw, mtch, fndDirRev, Me, Me)
    End Sub
    Public Property FindTextCollection() As List(Of String)
        Get
            Return fnd.FindTextCollection
        End Get
        Set(ByVal value As List(Of String))
            fnd.FindTextCollection = value
            rep.FindTextCollection = value
        End Set
    End Property
    Public Property ReplaceTextCollection() As List(Of String)
        Get
            Return rep.ReplaceTextCollection
        End Get
        Set(ByVal value As List(Of String))
            rep.ReplaceTextCollection = value
        End Set
    End Property

    Friend Sub ClearFindCollection()
        fnd.ClearFindCollection()
    End Sub

    Private Sub butFindReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butFindReplace.Click
        If fnd.Visible Then
            fnd.Hide()
        End If
        rep.Show(ra.SelectedText, whw, mtch, fndDirRev, Me, Me)

    End Sub

    Private Sub ra_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.Validated
        RaiseEvent Validated(sender, e)
    End Sub

    Private Sub ra_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ra.Validating
        RaiseEvent Validating(sender, e)
    End Sub



    Private Sub ra_VScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles ra.VScroll
        RaiseEvent VScroll(sender, e)
    End Sub



    Private Sub cboFonts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFonts.Click

    End Sub
End Class
