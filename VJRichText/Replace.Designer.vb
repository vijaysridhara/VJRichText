<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Replace
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cboFind = New System.Windows.Forms.ComboBox
        Me.butCancel = New System.Windows.Forms.Button
        Me.butOK = New System.Windows.Forms.Button
        Me.chkMatchcase = New System.Windows.Forms.CheckBox
        Me.chkWholeword = New System.Windows.Forms.CheckBox
        Me.lblFind = New System.Windows.Forms.Label
        Me.cboRep = New System.Windows.Forms.ComboBox
        Me.lblReplace = New System.Windows.Forms.Label
        Me.butReplace = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.rbtDown = New System.Windows.Forms.RadioButton
        Me.rbtUp = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'cboFind
        '
        Me.cboFind.FormattingEnabled = True
        Me.cboFind.Location = New System.Drawing.Point(74, 9)
        Me.cboFind.Name = "cboFind"
        Me.cboFind.Size = New System.Drawing.Size(147, 21)
        Me.cboFind.TabIndex = 1
        '
        'butCancel
        '
        Me.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancel.Location = New System.Drawing.Point(224, 90)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(83, 25)
        Me.butCancel.TabIndex = 8
        Me.butCancel.Text = "&Cancel"
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(224, 9)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(83, 25)
        Me.butOK.TabIndex = 6
        Me.butOK.Text = "&Find"
        '
        'chkMatchcase
        '
        Me.chkMatchcase.AutoSize = True
        Me.chkMatchcase.Location = New System.Drawing.Point(95, 63)
        Me.chkMatchcase.Name = "chkMatchcase"
        Me.chkMatchcase.Size = New System.Drawing.Size(78, 17)
        Me.chkMatchcase.TabIndex = 5
        Me.chkMatchcase.Text = "&Match case"
        '
        'chkWholeword
        '
        Me.chkWholeword.AutoSize = True
        Me.chkWholeword.Location = New System.Drawing.Point(10, 63)
        Me.chkWholeword.Name = "chkWholeword"
        Me.chkWholeword.Size = New System.Drawing.Size(79, 17)
        Me.chkWholeword.TabIndex = 4
        Me.chkWholeword.Text = "&Whole word"
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.Location = New System.Drawing.Point(1, 12)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(49, 13)
        Me.lblFind.TabIndex = 0
        Me.lblFind.Text = "Fi&nd what"
        '
        'cboRep
        '
        Me.cboRep.FormattingEnabled = True
        Me.cboRep.Location = New System.Drawing.Point(74, 36)
        Me.cboRep.Name = "cboRep"
        Me.cboRep.Size = New System.Drawing.Size(147, 21)
        Me.cboRep.TabIndex = 3
        '
        'lblReplace
        '
        Me.lblReplace.AutoSize = True
        Me.lblReplace.Location = New System.Drawing.Point(1, 39)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(65, 13)
        Me.lblReplace.TabIndex = 2
        Me.lblReplace.Text = "Re&place with"
        '
        'butReplace
        '
        Me.butReplace.Location = New System.Drawing.Point(224, 36)
        Me.butReplace.Name = "butReplace"
        Me.butReplace.Size = New System.Drawing.Size(83, 25)
        Me.butReplace.TabIndex = 7
        Me.butReplace.Text = "&Replace"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 25)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Replace &all"
        '
        'rbtDown
        '
        Me.rbtDown.AutoSize = True
        Me.rbtDown.Checked = True
        Me.rbtDown.Location = New System.Drawing.Point(65, 88)
        Me.rbtDown.Name = "rbtDown"
        Me.rbtDown.Size = New System.Drawing.Size(49, 17)
        Me.rbtDown.TabIndex = 12
        Me.rbtDown.Text = "&Down"
        '
        'rbtUp
        '
        Me.rbtUp.AutoSize = True
        Me.rbtUp.Location = New System.Drawing.Point(10, 88)
        Me.rbtUp.Name = "rbtUp"
        Me.rbtUp.Size = New System.Drawing.Size(35, 17)
        Me.rbtUp.TabIndex = 11
        Me.rbtUp.TabStop = False
        Me.rbtUp.Text = "&Up"
        '
        'Replace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancel
        Me.ClientSize = New System.Drawing.Size(319, 122)
        Me.ControlBox = False
        Me.Controls.Add(Me.rbtDown)
        Me.Controls.Add(Me.rbtUp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.butReplace)
        Me.Controls.Add(Me.cboRep)
        Me.Controls.Add(Me.lblReplace)
        Me.Controls.Add(Me.cboFind)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.chkMatchcase)
        Me.Controls.Add(Me.chkWholeword)
        Me.Controls.Add(Me.lblFind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Replace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Replace"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboFind As System.Windows.Forms.ComboBox
    Friend WithEvents butCancel As System.Windows.Forms.Button
    Friend WithEvents butOK As System.Windows.Forms.Button
    Friend WithEvents chkMatchcase As System.Windows.Forms.CheckBox
    Friend WithEvents chkWholeword As System.Windows.Forms.CheckBox
    Friend WithEvents lblFind As System.Windows.Forms.Label
    Friend WithEvents cboRep As System.Windows.Forms.ComboBox
    Friend WithEvents lblReplace As System.Windows.Forms.Label
    Friend WithEvents butReplace As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rbtDown As System.Windows.Forms.RadioButton
    Friend WithEvents rbtUp As System.Windows.Forms.RadioButton
End Class
